using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Media;
using System.IO;
using SnapShot;
using System.Runtime.InteropServices;

namespace PriceIsRightParty
{
    public partial class MainForm : Form
    {
        #region Global Variables

        private const double climberVirtualMinX = 0.27;
        private const double climberVirtualMaxX = 0.718;
        private const double climberVirtualMinY = 0.612;
        private const double climberM = -0.8191964285714286;
        private const double climberB = 0.8331830357142857;

        private int screenState;
        private int PiRState;
        private int CliffState;
        private bool hasGroupLost;

        private string musicAbsolutePath;

        private SoundPlayer player;
        private MediaPlayer wmp;
        private Capture cam;

        #endregion

        public MainForm()
        {
            #region Flicker Fix

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            #endregion

            #region Monitor Setting and Sizing

            if (Properties.Settings.Default.Monitor >= Screen.AllScreens.Length || Properties.Settings.Default.Monitor < 0)
                Properties.Settings.Default.Monitor = -1;
            this.Visible = false;
            InitializeComponent();
            if (Properties.Settings.Default.Monitor == -1)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
                this.Location = Screen.PrimaryScreen.Bounds.Location;
            }
            else
            {
                this.Width = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Width;
                this.Height = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Height;
                this.Location = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location;
            }

            #endregion

            #region Restore Last Log

            if (File.Exists(Properties.Settings.Default.LogFilename) && Properties.Settings.Default.LoadPreviousLogFile)
            {
                StreamReader reader = new StreamReader(Properties.Settings.Default.LogFilename);
                string oldLog = reader.ReadToEnd();
                string[] logItems = oldLog.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < logItems.Length; i++)
                {
                    string[] itemSplit = logItems[i].Split(new char[] { '\t' });
                    string name = itemSplit[0];
                    DateTime dt = DateTime.Parse(itemSplit[1]);
                    double val = 0;
                    try
                    {
                        val = double.Parse(itemSplit[2]);
                    }
                    catch (Exception) { }
                    bool removed = itemSplit[2] == "Removed";
                    int found = -1;

                    for (int j = 0; j < chart.Series.Count; j++)
                        if (chart.Series[j].Name == name)
                            found = j;
                    if (found == -1)
                        addNewPlayer(name, dt, val, false);
                    else
                    {
                        if (removed)
                            removePlayer(name, dt, false);
                        else
                            addDataToPlayer(name, dt, val, false);
                    }
                }
                playerSelectComboBox.SelectedIndex = 0;
                reader.Close();
            }
            else
            {
                File.Open(Properties.Settings.Default.LogFilename,FileMode.Create).Close();
            }

            #endregion

            #region Dynamic Sizing and Locating

            this.background.Width = this.Width;
            this.background.Height = this.Height;
            this.background.Image = Properties.Resources.CliffhangerBackground;
            this.climberPictureBox.Image = Properties.Resources.Climber;
            this.climberPictureBox.Width = this.climberPictureBox.Image.Width;
            this.climberPictureBox.Height = this.climberPictureBox.Image.Height;
            this.climberPictureBox.Parent = this.background;
            setClimberState(0, 0.0, Properties.Settings.Default.BACTarget);

            chart.Width = this.Width;
            chart.Height = this.Height;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yy HH:mm:ss";
            controlPanel.Location = new Point(this.Width / 2 - controlPanel.Width / 2, this.Height / 2 - controlPanel.Height / 2);

            #endregion

            #region Initialize State Variables

            screenState = 0;
            PiRState = 0;
            CliffState = 0;
            hasGroupLost = false;

            #endregion

            #region Audio Initialization

            musicAbsolutePath = Application.StartupPath + Properties.Resources.MusicPath;
            player = new System.Media.SoundPlayer();
            wmp = new MediaPlayer();

            #endregion

            #region Register Event Handlers

            this.Click += new EventHandler(MainForm_Click);
            this.newPlayerNameTextBox.KeyDown += new KeyEventHandler(newPlayerNameTextBox_KeyDown);
            this.bacPercentNumericUpDown.KeyDown += new KeyEventHandler(bacPercentNumericUpDown_KeyDown);
            this.initialBACNumericUpDown.KeyDown += new KeyEventHandler(initialBACNumericUpDown_KeyDown);
            
            #endregion

            #region Image Capture Initialization

            const int VIDEODEVICE = 0; // zero based index of video capture device to use
            const int VIDEOWIDTH = 640; // Depends on video device caps
            const int VIDEOHEIGHT = 480; // Depends on video device caps
            const int VIDEOBITSPERPIXEL = 24; // BitsPerPixel values determined by device

            cam = new Capture(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, acquisitionWindow);

            #endregion

            //Show The Application
            this.Visible = true;
        }

        #region Global Key Processing

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.F1)
                advanceScreenState();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region State Helper Functions

        private void addNewPlayer(string name, DateTime currentTime, double initialBAC, bool save)
        {
            playerSelectComboBox.Items.Add(name);
            newPlayerNameTextBox.Text = "";
            initialBACNumericUpDown.Value = 0;
            if (chart.Series.IndexOf(name) < 0)
            {
                chart.Series.Add(name);
                chart.Series[chart.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series[chart.Series.Count - 1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart.Series[chart.Series.Count - 1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chart.Series[chart.Series.Count - 1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            }
            addDataToPlayer(name, currentTime, initialBAC, save);
        }

        private void addDataToPlayer(string name, DateTime currentTime, double BAC, bool save)
        {
            int playerIndex = chart.Series.IndexOf(name);
            chart.Series[playerIndex].Points.AddXY(currentTime, BAC);
            recalculateAverage(currentTime);
            if(save)
                savePoint(name, currentTime, BAC);
        }

        private void setClimberState(double x, double min, double max)
        {
            double normalizedVal = (x - min) / (max - min);
            double vmin = climberVirtualMinX;
            double vmax = climberVirtualMaxX;
            double denormalizedVal = (normalizedVal * (vmax - vmin)) + vmin;
            double py = (climberM * denormalizedVal + climberB) * this.Height;
            double px = denormalizedVal * this.Width;
            py = (py / (1920 / 1080)) * (this.Width / this.Height);
            px = (px / (1920 / 1080)) * (this.Width / this.Height);
            climberPictureBox.Location = new Point((int)px, (int)py);
        }

        private void recalculateAverage(DateTime dt)
        {
            double sum = 0.0;
            for (int i = 0; i < playerSelectComboBox.Items.Count; i++)
            {
                string playerName = (string)playerSelectComboBox.Items[i];
                int seriesIndex = chart.Series.IndexOf(playerName);
                sum += chart.Series[seriesIndex].Points[chart.Series[seriesIndex].Points.Count - 1].YValues[0];
            }
            double newAverage = sum / (playerSelectComboBox.Items.Count);
            chart.Series[0].Points.AddXY(dt, newAverage);
            setClimberState(newAverage, 0, Properties.Settings.Default.BACTarget);
            if (newAverage > Properties.Settings.Default.BACTarget && !hasGroupLost)
            {
                hasGroupLost = true;
                playSound(Sounds.crash);
                advanceScreenState();
                advanceScreenState();
                climberPictureBox.Image = null;
            }
        }

        private void removePlayer(string name, DateTime time,bool save)
        {
            int playerIndex = chart.Series.IndexOf(name);
            double lastPoint = chart.Series[playerIndex].Points[chart.Series[playerIndex].Points.Count-1].YValues[0];
            addDataToPlayer(name,time,lastPoint,false);
            chart.Series[playerIndex].Points[chart.Series[playerIndex].Points.Count-1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            chart.Series[playerIndex].Points[chart.Series[playerIndex].Points.Count - 1].MarkerSize = chart.Series[playerIndex].Points[chart.Series[playerIndex].Points.Count - 1].MarkerSize * 2;
            if(save)
                savePlayerRemoval(name, time);
        }

        #endregion

        #region Screen Changing

        private void background_Click(object sender, EventArgs e)
        {
            advanceScreenState();
        }

        private void chart_Click(object sender, EventArgs e)
        {
            advanceScreenState();
        }

        void MainForm_Click(object sender, EventArgs e)
        {
            advanceScreenState();
        }

        private void advanceScreenState()
        {
            switch (screenState)
            {
                case 0:
                    background.Visible = false;
                    climberPictureBox.Visible = false;
                    chart.Visible = true;
                    controlPanel.Visible = false;
                    screenState++;
                    break;
                case 1:
                    background.Visible = true;
                    climberPictureBox.Visible = true;
                    chart.Visible = false;
                    controlPanel.Visible = false;
                    screenState++;
                    break;
                case 2:
                    background.Visible = false;
                    climberPictureBox.Visible = false;
                    chart.Visible = false;
                    controlPanel.Visible = true;
                    screenState=0;
                    break;
            }
        }

        #endregion

        #region Control Panel

        void bacPercentNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addDataButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void newPlayerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPlayerButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void initialBACNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPlayerButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            string playerName = newPlayerNameTextBox.Text.Trim();
            DateTime time = DateTime.Now;
            if (playerName != "" && playerName!="Party Average")
            {
                bool exists = false;
                for (int i = 0; i < playerSelectComboBox.Items.Count; i++)
                    if (((string)playerSelectComboBox.Items[i]) == playerName)
                        exists = true;
                if (!exists)
                {
                    addNewPlayer(playerName, time, (double)initialBACNumericUpDown.Value,true);
                    if (playerSelectComboBox.Items.Count == 1)
                        playerSelectComboBox.SelectedIndex = 0;
                }
            }
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string playerName = (string)playerSelectComboBox.SelectedItem;
            playerSelectComboBox.Items.RemoveAt(playerSelectComboBox.SelectedIndex);
            if (playerSelectComboBox.Items.Count > 0)
            {
                playerSelectComboBox.SelectedIndex = 0;
                recalculateAverage(dt);
            }
            removePlayer(playerName, dt,true);
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (playerSelectComboBox.Items.Count > 0)
            {
                int selected = playerSelectComboBox.SelectedIndex;
                string playerName = (string)playerSelectComboBox.Items[selected];
                DateTime time = DateTime.Now;
                double val = (double)bacPercentNumericUpDown.Value;
                bacPercentNumericUpDown.Value = 0;
                addDataToPlayer(playerName, time, val,true);
            }
        }

        private void playCliffButton_Click(object sender, EventArgs e)
        {
            switch (CliffState)
            {
                case 0:
                    playSound(Sounds.Cliff);
                    CliffState++;
                    break;
                case 1:
                    playSound(Sounds.CliffEuro);
                    CliffState++;
                    break;
                case 2:
                    playSound(Sounds.CliffBass);
                    CliffState = 0;
                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wmp.Stop();
        }

        private void playPiRButton_Click(object sender, EventArgs e)
        {
            switch (PiRState)
            {
                case 0:
                    playSound(Sounds.PiR);
                    PiRState++;
                    break;
                case 1:
                    playSound(Sounds.PiRModern);
                    PiRState++;
                    break;
                case 2:
                    playSound(Sounds.PiRBeat);
                    PiRState++;
                    break;
                case 3:
                    playSound(Sounds.PiRGroove);
                    PiRState = 0;
                    break;
            }
        }

        #endregion

        #region Audio

        private enum Sounds { crash , PiR, PiRBeat, PiRModern, PiRGroove, Cliff, CliffEuro, CliffBass };

        private void playSound(Sounds s)
        {
            try
            {
                string path;
                switch (s)
                {
                    case Sounds.crash:
                        player.Stream = Properties.Resources.crash;
                        player.Play();
                        break;
                    case Sounds.PiR:
                        path = musicAbsolutePath + Properties.Resources.PiRFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.PiRBeat:
                        path = musicAbsolutePath + Properties.Resources.PiRBeatFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.PiRGroove:
                        path = musicAbsolutePath + Properties.Resources.PiRGrooveFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.PiRModern:
                        path = musicAbsolutePath + Properties.Resources.PiRModernFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.Cliff:
                        path = musicAbsolutePath + Properties.Resources.CliffFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.CliffBass:
                        path = musicAbsolutePath + Properties.Resources.CliffBassFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                    case Sounds.CliffEuro:
                        path = musicAbsolutePath + Properties.Resources.CliffEuroFilename;
                        wmp.Open(new Uri(path));
                        wmp.Play();
                        break;
                }
            }
            catch (Exception) { }
        }

        #endregion

        #region Save Function

        private void savePoint(string playerName, DateTime t, double x)
        {
            StreamWriter w = new StreamWriter(Properties.Settings.Default.LogFilename, true);
            w.Write(playerName + '\t' + t.ToLongDateString() + ' ' + t.ToLongTimeString() + '\t' + x.ToString() + "\r\n");
            w.Close();
        }

        private void savePlayerRemoval(string playerName, DateTime t)
        {
            StreamWriter w = new StreamWriter(Properties.Settings.Default.LogFilename, true);
            w.Write(playerName + '\t' + t.ToLongDateString() + ' ' + t.ToLongTimeString() + "\tRemoved\r\n");
            w.Close();
        }

        #endregion

        private void captureButton_Click(object sender, EventArgs e)
        {
            IntPtr m_ip = IntPtr.Zero;
            Cursor.Current = Cursors.WaitCursor;
            if (m_ip != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }
            m_ip = cam.Click();

            Bitmap b = new Bitmap(cam.Width, cam.Height, cam.Stride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, m_ip);

            cam.Dispose();

            acquisitionWindow.Image = b;
        }
    }
}
