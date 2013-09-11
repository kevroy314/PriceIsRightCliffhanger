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

        private string musicAbsolutePath;

        private SoundPlayer player;
        private MediaPlayer wmp;

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

            #region Dynamic Sizing and Locating

            this.background.Width = this.Width;
            this.background.Height = this.Height;
            this.background.Image = Properties.Resources.CliffhangerBackground;

            this.climberPictureBox.Width = this.climberPictureBox.Image.Width;
            this.climberPictureBox.Height = this.climberPictureBox.Image.Height;
            this.climberPictureBox.Parent = this.background;
            this.climberPictureBox.Location = new Point((int)(climberVirtualMinX * ((double)this.Width)), (int)(climberVirtualMinY * ((double)this.Height)));

            chart.Width = this.Width;
            chart.Height = this.Height;

            controlPanel.Location = new Point(this.Width / 2 - controlPanel.Width / 2, this.Height / 2 - controlPanel.Height / 2);

            #endregion

            #region Initialize State Variables

            screenState = 0;
            PiRState = 0;
            CliffState = 0;

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

        private void setClimberState(double x, double min, double max)
        {
            double normalizedVal = (x - min) / (max - min);
            double vmin = climberVirtualMinX;
            double vmax = climberVirtualMaxX;
            double denormalizedVal = (normalizedVal * (vmax - vmin)) + vmin;
            double range = max - min;
            double py = (climberM * denormalizedVal + climberB) * this.Height;
            double px = denormalizedVal * this.Width;
            climberPictureBox.Location = new Point((int)px, (int)py);
        }

        private void recalculateAverage()
        {
            double sum = 0.0;
            for (int i = 1; i < chart.Series.Count; i++)
                sum += chart.Series[i].Points[chart.Series[i].Points.Count - 1].YValues[0];
            double newAverage = sum / (chart.Series.Count - 1);
            chart.Series[0].Points.AddXY(DateTime.Now, newAverage);
            setClimberState(newAverage, 0, Properties.Settings.Default.BACTarget);
            if (newAverage > Properties.Settings.Default.BACTarget)
            {
                playSound(Sounds.crash);
                advanceScreenState();
                advanceScreenState();
                climberPictureBox.Image = null;
            }
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
                addDataButton_Click(sender, e);
        }

        void newPlayerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addPlayerButton_Click(sender, e);
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (newPlayerNameTextBox.Text.Trim() != "")
            {
                bool exists = false;
                for (int i = 0; i < playerSelectComboBox.Items.Count; i++)
                    if (((string)playerSelectComboBox.Items[i]) == newPlayerNameTextBox.Text.Trim())
                        exists = true;
                if (!exists)
                {
                    playerSelectComboBox.Items.Add(newPlayerNameTextBox.Text.Trim());
                    chart.Series.Add(newPlayerNameTextBox.Text.Trim());
                    chart.Series[chart.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart.Series[chart.Series.Count - 1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    chart.Series[chart.Series.Count - 1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart.Series[chart.Series.Count - 1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
                    chart.Series[chart.Series.Count - 1].Points.AddXY(DateTime.Now, 0.0);
                    if (playerSelectComboBox.Items.Count == 1)
                    {
                        playerSelectComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (playerSelectComboBox.Items.Count > 0)
            {
                chart.Series[playerSelectComboBox.SelectedIndex + 1].Points.AddXY(DateTime.Now, bacPercentNumericUpDown.Value);
                recalculateAverage();
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

        #endregion
    }
}
