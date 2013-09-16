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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.initialBACLabel = new System.Windows.Forms.Label();
            this.initialBACNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playCliffButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPiRButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.climberPictureBox = new System.Windows.Forms.PictureBox();
            this.acquisitionWindow = new System.Windows.Forms.PictureBox();
            this.captureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacPercentNumericUpDown)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialBACNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.climberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(288, 260);
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
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisX.LineColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightSkyBlue;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisY.LineColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.MidnightBlue;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.SteelBlue;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.SteelBlue;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.SteelBlue;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Party Average";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(288, 260);
            this.chart.TabIndex = 1;
            this.chart.Text = "bacChart";
            this.chart.Visible = false;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // newPlayerNameTextBox
            // 
            this.newPlayerNameTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerNameTextBox.Location = new System.Drawing.Point(20, 36);
            this.newPlayerNameTextBox.MaxLength = 20;
            this.newPlayerNameTextBox.Name = "newPlayerNameTextBox";
            this.newPlayerNameTextBox.Size = new System.Drawing.Size(232, 23);
            this.newPlayerNameTextBox.TabIndex = 0;
            this.newPlayerNameTextBox.Tag = "controlPanel";
            // 
            // newPlayerNameLabel
            // 
            this.newPlayerNameLabel.AutoSize = true;
            this.newPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerNameLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.newPlayerNameLabel.Location = new System.Drawing.Point(17, 20);
            this.newPlayerNameLabel.Name = "newPlayerNameLabel";
            this.newPlayerNameLabel.Size = new System.Drawing.Size(107, 15);
            this.newPlayerNameLabel.TabIndex = 3;
            this.newPlayerNameLabel.Tag = "controlPanel";
            this.newPlayerNameLabel.Text = "New Player Name";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.White;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(343, 33);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(79, 26);
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
            this.playerSelectComboBox.Location = new System.Drawing.Point(20, 267);
            this.playerSelectComboBox.MaxDropDownItems = 25;
            this.playerSelectComboBox.Name = "playerSelectComboBox";
            this.playerSelectComboBox.Size = new System.Drawing.Size(232, 23);
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
            this.bacPercentNumericUpDown.Location = new System.Drawing.Point(258, 268);
            this.bacPercentNumericUpDown.Name = "bacPercentNumericUpDown";
            this.bacPercentNumericUpDown.Size = new System.Drawing.Size(79, 23);
            this.bacPercentNumericUpDown.TabIndex = 4;
            this.bacPercentNumericUpDown.Tag = "controlPanel";
            // 
            // playerSelectLabel
            // 
            this.playerSelectLabel.AutoSize = true;
            this.playerSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerSelectLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelectLabel.ForeColor = System.Drawing.Color.White;
            this.playerSelectLabel.Location = new System.Drawing.Point(17, 249);
            this.playerSelectLabel.Name = "playerSelectLabel";
            this.playerSelectLabel.Size = new System.Drawing.Size(78, 15);
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
            this.bacPercentLabel.Location = new System.Drawing.Point(255, 249);
            this.bacPercentLabel.Name = "bacPercentLabel";
            this.bacPercentLabel.Size = new System.Drawing.Size(56, 15);
            this.bacPercentLabel.TabIndex = 7;
            this.bacPercentLabel.Tag = "controlPanel";
            this.bacPercentLabel.Text = "BAC (%)";
            // 
            // addDataButton
            // 
            this.addDataButton.BackColor = System.Drawing.Color.White;
            this.addDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDataButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataButton.Location = new System.Drawing.Point(343, 264);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(79, 28);
            this.addDataButton.TabIndex = 5;
            this.addDataButton.Tag = "controlPanel";
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = false;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
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
            this.controlPanel.Location = new System.Drawing.Point(422, 50);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(558, 416);
            this.controlPanel.TabIndex = 8;
            this.controlPanel.Tag = "controlPanel";
            // 
            // initialBACLabel
            // 
            this.initialBACLabel.AutoSize = true;
            this.initialBACLabel.BackColor = System.Drawing.Color.Transparent;
            this.initialBACLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialBACLabel.ForeColor = System.Drawing.Color.White;
            this.initialBACLabel.Location = new System.Drawing.Point(255, 17);
            this.initialBACLabel.Name = "initialBACLabel";
            this.initialBACLabel.Size = new System.Drawing.Size(94, 15);
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
            this.initialBACNumericUpDown.Location = new System.Drawing.Point(258, 36);
            this.initialBACNumericUpDown.Name = "initialBACNumericUpDown";
            this.initialBACNumericUpDown.Size = new System.Drawing.Size(79, 23);
            this.initialBACNumericUpDown.TabIndex = 1;
            this.initialBACNumericUpDown.Tag = "controlPanel";
            // 
            // playCliffButton
            // 
            this.playCliffButton.BackColor = System.Drawing.Color.White;
            this.playCliffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playCliffButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCliffButton.Location = new System.Drawing.Point(20, 315);
            this.playCliffButton.Name = "playCliffButton";
            this.playCliffButton.Size = new System.Drawing.Size(195, 48);
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
            this.stopButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(362, 369);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 28);
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
            this.playPiRButton.Location = new System.Drawing.Point(227, 315);
            this.playPiRButton.Name = "playPiRButton";
            this.playPiRButton.Size = new System.Drawing.Size(195, 48);
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
            this.removePlayerButton.Location = new System.Drawing.Point(428, 264);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(101, 28);
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
            this.climberPictureBox.Location = new System.Drawing.Point(161, 106);
            this.climberPictureBox.Name = "climberPictureBox";
            this.climberPictureBox.Size = new System.Drawing.Size(89, 45);
            this.climberPictureBox.TabIndex = 9;
            this.climberPictureBox.TabStop = false;
            this.climberPictureBox.Visible = false;
            // 
            // acquisitionWindow
            // 
            this.acquisitionWindow.Location = new System.Drawing.Point(20, 65);
            this.acquisitionWindow.Name = "acquisitionWindow";
            this.acquisitionWindow.Size = new System.Drawing.Size(232, 145);
            this.acquisitionWindow.TabIndex = 10;
            this.acquisitionWindow.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(1000, 70);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(83, 35);
            this.captureButton.TabIndex = 11;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PriceIsRightParty.Properties.Resources.GradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 559);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.climberPictureBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cliffhanger";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacPercentNumericUpDown)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialBACNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.climberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionWindow)).EndInit();
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
        private System.Windows.Forms.Button captureButton;
    }
}

