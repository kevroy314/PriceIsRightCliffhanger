namespace PriceIsRightParty
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            cam.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.background = new System.Windows.Forms.PictureBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.newPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.newPlayerNameLabel = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.bacPercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerSelectLabel = new System.Windows.Forms.Label();
            this.bacPercentLabel = new System.Windows.Forms.Label();
            this.addDataButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.startingNoteTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastEatenNumeric = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightNumeric = new System.Windows.Forms.NumericUpDown();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.acquisitionWindow = new System.Windows.Forms.PictureBox();
            this.initialBACLabel = new System.Windows.Forms.Label();
            this.initialBACNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playCliffButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPiRButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.climberPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacPercentNumericUpDown)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastEatenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialBACNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.climberPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(432, 400);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Visible = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Black;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisX.LineColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisY.LineColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.SteelBlue;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Party Average";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(432, 400);
            this.chart.TabIndex = 1;
            this.chart.Text = "bacChart";
            this.chart.Visible = false;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // newPlayerNameTextBox
            // 
            this.newPlayerNameTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerNameTextBox.Location = new System.Drawing.Point(30, 55);
            this.newPlayerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPlayerNameTextBox.MaxLength = 20;
            this.newPlayerNameTextBox.Name = "newPlayerNameTextBox";
            this.newPlayerNameTextBox.Size = new System.Drawing.Size(346, 31);
            this.newPlayerNameTextBox.TabIndex = 0;
            this.newPlayerNameTextBox.Tag = "controlPanel";
            // 
            // newPlayerNameLabel
            // 
            this.newPlayerNameLabel.AutoSize = true;
            this.newPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerNameLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.newPlayerNameLabel.Location = new System.Drawing.Point(26, 31);
            this.newPlayerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPlayerNameLabel.Name = "newPlayerNameLabel";
            this.newPlayerNameLabel.Size = new System.Drawing.Size(167, 24);
            this.newPlayerNameLabel.TabIndex = 3;
            this.newPlayerNameLabel.Tag = "controlPanel";
            this.newPlayerNameLabel.Text = "New Player Name";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.White;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(514, 51);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(118, 40);
            this.addPlayerButton.TabIndex = 2;
            this.addPlayerButton.Tag = "controlPanel";
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // playerSelectComboBox
            // 
            this.playerSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSelectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerSelectComboBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelectComboBox.FormattingEnabled = true;
            this.playerSelectComboBox.Location = new System.Drawing.Point(30, 411);
            this.playerSelectComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerSelectComboBox.MaxDropDownItems = 25;
            this.playerSelectComboBox.Name = "playerSelectComboBox";
            this.playerSelectComboBox.Size = new System.Drawing.Size(346, 32);
            this.playerSelectComboBox.TabIndex = 3;
            this.playerSelectComboBox.Tag = "controlPanel";
            // 
            // bacPercentNumericUpDown
            // 
            this.bacPercentNumericUpDown.DecimalPlaces = 3;
            this.bacPercentNumericUpDown.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacPercentNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.bacPercentNumericUpDown.Location = new System.Drawing.Point(387, 412);
            this.bacPercentNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bacPercentNumericUpDown.Name = "bacPercentNumericUpDown";
            this.bacPercentNumericUpDown.Size = new System.Drawing.Size(118, 31);
            this.bacPercentNumericUpDown.TabIndex = 4;
            this.bacPercentNumericUpDown.Tag = "controlPanel";
            // 
            // playerSelectLabel
            // 
            this.playerSelectLabel.AutoSize = true;
            this.playerSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerSelectLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelectLabel.ForeColor = System.Drawing.Color.White;
            this.playerSelectLabel.Location = new System.Drawing.Point(26, 383);
            this.playerSelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerSelectLabel.Name = "playerSelectLabel";
            this.playerSelectLabel.Size = new System.Drawing.Size(122, 24);
            this.playerSelectLabel.TabIndex = 7;
            this.playerSelectLabel.Tag = "controlPanel";
            this.playerSelectLabel.Text = "Player Name";
            // 
            // bacPercentLabel
            // 
            this.bacPercentLabel.AutoSize = true;
            this.bacPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.bacPercentLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacPercentLabel.ForeColor = System.Drawing.Color.White;
            this.bacPercentLabel.Location = new System.Drawing.Point(382, 383);
            this.bacPercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bacPercentLabel.Name = "bacPercentLabel";
            this.bacPercentLabel.Size = new System.Drawing.Size(82, 24);
            this.bacPercentLabel.TabIndex = 7;
            this.bacPercentLabel.Tag = "controlPanel";
            this.bacPercentLabel.Text = "BAC (%)";
            // 
            // addDataButton
            // 
            this.addDataButton.BackColor = System.Drawing.Color.White;
            this.addDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDataButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataButton.Location = new System.Drawing.Point(514, 406);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(118, 43);
            this.addDataButton.TabIndex = 5;
            this.addDataButton.Tag = "controlPanel";
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = false;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.startingNoteTextbox);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.lastEatenNumeric);
            this.controlPanel.Controls.Add(this.heightLabel);
            this.controlPanel.Controls.Add(this.heightNumeric);
            this.controlPanel.Controls.Add(this.weightLabel);
            this.controlPanel.Controls.Add(this.weightNumeric);
            this.controlPanel.Controls.Add(this.acquisitionWindow);
            this.controlPanel.Controls.Add(this.initialBACLabel);
            this.controlPanel.Controls.Add(this.bacPercentLabel);
            this.controlPanel.Controls.Add(this.playerSelectLabel);
            this.controlPanel.Controls.Add(this.initialBACNumericUpDown);
            this.controlPanel.Controls.Add(this.bacPercentNumericUpDown);
            this.controlPanel.Controls.Add(this.playerSelectComboBox);
            this.controlPanel.Controls.Add(this.playCliffButton);
            this.controlPanel.Controls.Add(this.stopButton);
            this.controlPanel.Controls.Add(this.playPiRButton);
            this.controlPanel.Controls.Add(this.removePlayerButton);
            this.controlPanel.Controls.Add(this.addDataButton);
            this.controlPanel.Controls.Add(this.addPlayerButton);
            this.controlPanel.Controls.Add(this.newPlayerNameLabel);
            this.controlPanel.Controls.Add(this.newPlayerNameTextBox);
            this.controlPanel.Location = new System.Drawing.Point(633, 77);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(837, 640);
            this.controlPanel.TabIndex = 8;
            this.controlPanel.Tag = "controlPanel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 18;
            this.label2.Tag = "controlPanel";
            this.label2.Text = "Optional - Starting Note";
            // 
            // startingNoteTextbox
            // 
            this.startingNoteTextbox.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.startingNoteTextbox.Location = new System.Drawing.Point(257, 325);
            this.startingNoteTextbox.Name = "startingNoteTextbox";
            this.startingNoteTextbox.Size = new System.Drawing.Size(537, 31);
            this.startingNoteTextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 16;
            this.label1.Tag = "controlPanel";
            this.label1.Text = "Optional - Last Eaten (hours ago)";
            // 
            // lastEatenNumeric
            // 
            this.lastEatenNumeric.DecimalPlaces = 2;
            this.lastEatenNumeric.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastEatenNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lastEatenNumeric.Location = new System.Drawing.Point(387, 269);
            this.lastEatenNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastEatenNumeric.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.lastEatenNumeric.Name = "lastEatenNumeric";
            this.lastEatenNumeric.Size = new System.Drawing.Size(118, 31);
            this.lastEatenNumeric.TabIndex = 15;
            this.lastEatenNumeric.Tag = "controlPanel";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.BackColor = System.Drawing.Color.Transparent;
            this.heightLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(382, 168);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(243, 24);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Tag = "controlPanel";
            this.heightLabel.Text = "Optional - Height (inches)";
            // 
            // heightNumeric
            // 
            this.heightNumeric.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightNumeric.Location = new System.Drawing.Point(387, 197);
            this.heightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.heightNumeric.Name = "heightNumeric";
            this.heightNumeric.Size = new System.Drawing.Size(118, 31);
            this.heightNumeric.TabIndex = 13;
            this.heightNumeric.Tag = "controlPanel";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(381, 95);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(214, 24);
            this.weightLabel.TabIndex = 12;
            this.weightLabel.Tag = "controlPanel";
            this.weightLabel.Text = "Optional - Weight (lbs)";
            // 
            // weightNumeric
            // 
            this.weightNumeric.DecimalPlaces = 1;
            this.weightNumeric.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weightNumeric.Location = new System.Drawing.Point(386, 124);
            this.weightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(118, 31);
            this.weightNumeric.TabIndex = 11;
            this.weightNumeric.Tag = "controlPanel";
            // 
            // acquisitionWindow
            // 
            this.acquisitionWindow.Location = new System.Drawing.Point(30, 100);
            this.acquisitionWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acquisitionWindow.Name = "acquisitionWindow";
            this.acquisitionWindow.Size = new System.Drawing.Size(348, 223);
            this.acquisitionWindow.TabIndex = 10;
            this.acquisitionWindow.TabStop = false;
            // 
            // initialBACLabel
            // 
            this.initialBACLabel.AutoSize = true;
            this.initialBACLabel.BackColor = System.Drawing.Color.Transparent;
            this.initialBACLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialBACLabel.ForeColor = System.Drawing.Color.White;
            this.initialBACLabel.Location = new System.Drawing.Point(382, 26);
            this.initialBACLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialBACLabel.Name = "initialBACLabel";
            this.initialBACLabel.Size = new System.Drawing.Size(141, 24);
            this.initialBACLabel.TabIndex = 7;
            this.initialBACLabel.Tag = "controlPanel";
            this.initialBACLabel.Text = "Initial BAC (%)";
            // 
            // initialBACNumericUpDown
            // 
            this.initialBACNumericUpDown.DecimalPlaces = 3;
            this.initialBACNumericUpDown.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialBACNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.initialBACNumericUpDown.Location = new System.Drawing.Point(387, 55);
            this.initialBACNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initialBACNumericUpDown.Name = "initialBACNumericUpDown";
            this.initialBACNumericUpDown.Size = new System.Drawing.Size(118, 31);
            this.initialBACNumericUpDown.TabIndex = 1;
            this.initialBACNumericUpDown.Tag = "controlPanel";
            // 
            // playCliffButton
            // 
            this.playCliffButton.BackColor = System.Drawing.Color.White;
            this.playCliffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playCliffButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCliffButton.Location = new System.Drawing.Point(30, 485);
            this.playCliffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playCliffButton.Name = "playCliffButton";
            this.playCliffButton.Size = new System.Drawing.Size(292, 74);
            this.playCliffButton.TabIndex = 7;
            this.playCliffButton.Tag = "controlPanel";
            this.playCliffButton.Text = "Play Cliff";
            this.playCliffButton.UseVisualStyleBackColor = false;
            this.playCliffButton.Click += new System.EventHandler(this.playCliffButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(543, 568);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(90, 43);
            this.stopButton.TabIndex = 9;
            this.stopButton.Tag = "controlPanel";
            this.stopButton.Text = "■ Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPiRButton
            // 
            this.playPiRButton.BackColor = System.Drawing.Color.White;
            this.playPiRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPiRButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPiRButton.Location = new System.Drawing.Point(340, 485);
            this.playPiRButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playPiRButton.Name = "playPiRButton";
            this.playPiRButton.Size = new System.Drawing.Size(292, 74);
            this.playPiRButton.TabIndex = 8;
            this.playPiRButton.Tag = "controlPanel";
            this.playPiRButton.Text = "Play PiR";
            this.playPiRButton.UseVisualStyleBackColor = false;
            this.playPiRButton.Click += new System.EventHandler(this.playPiRButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.White;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.Location = new System.Drawing.Point(642, 406);
            this.removePlayerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(152, 43);
            this.removePlayerButton.TabIndex = 6;
            this.removePlayerButton.Tag = "controlPanel";
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // climberPictureBox
            // 
            this.climberPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.climberPictureBox.Image = global::PriceIsRightParty.Properties.Resources.Climber;
            this.climberPictureBox.Location = new System.Drawing.Point(242, 163);
            this.climberPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.climberPictureBox.Name = "climberPictureBox";
            this.climberPictureBox.Size = new System.Drawing.Size(134, 69);
            this.climberPictureBox.TabIndex = 9;
            this.climberPictureBox.TabStop = false;
            this.climberPictureBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PriceIsRightParty.Properties.Resources.GradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 860);
            this.Controls.Add(this.climberPictureBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cliffhanger";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacPercentNumericUpDown)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastEatenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialBACNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.climberPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox newPlayerNameTextBox;
        private System.Windows.Forms.Label newPlayerNameLabel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ComboBox playerSelectComboBox;
        private System.Windows.Forms.NumericUpDown bacPercentNumericUpDown;
        private System.Windows.Forms.Label playerSelectLabel;
        private System.Windows.Forms.Label bacPercentLabel;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.PictureBox climberPictureBox;
        private System.Windows.Forms.Button playCliffButton;
        private System.Windows.Forms.Button playPiRButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Label initialBACLabel;
        private System.Windows.Forms.NumericUpDown initialBACNumericUpDown;
        private System.Windows.Forms.PictureBox acquisitionWindow;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lastEatenNumeric;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown heightNumeric;
        private System.Windows.Forms.TextBox startingNoteTextbox;
        private System.Windows.Forms.Label label2;
    }
}

