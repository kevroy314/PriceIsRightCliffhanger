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
            this.playCliffButton = new System.Windows.Forms.Button();
            this.playPiRButton = new System.Windows.Forms.Button();
            this.climberPictureBox = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacPercentNumericUpDown)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.climberPictureBox)).BeginInit();
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
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Party Average";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
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
            this.addPlayerButton.Location = new System.Drawing.Point(258, 33);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(79, 26);
            this.addPlayerButton.TabIndex = 1;
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
            this.playerSelectComboBox.Location = new System.Drawing.Point(20, 104);
            this.playerSelectComboBox.MaxDropDownItems = 25;
            this.playerSelectComboBox.Name = "playerSelectComboBox";
            this.playerSelectComboBox.Size = new System.Drawing.Size(232, 23);
            this.playerSelectComboBox.TabIndex = 2;
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
            this.bacPercentNumericUpDown.Location = new System.Drawing.Point(258, 105);
            this.bacPercentNumericUpDown.Name = "bacPercentNumericUpDown";
            this.bacPercentNumericUpDown.Size = new System.Drawing.Size(79, 23);
            this.bacPercentNumericUpDown.TabIndex = 3;
            this.bacPercentNumericUpDown.Tag = "controlPanel";
            // 
            // playerSelectLabel
            // 
            this.playerSelectLabel.AutoSize = true;
            this.playerSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerSelectLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelectLabel.ForeColor = System.Drawing.Color.White;
            this.playerSelectLabel.Location = new System.Drawing.Point(17, 86);
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
            this.bacPercentLabel.Location = new System.Drawing.Point(255, 86);
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
            this.addDataButton.Location = new System.Drawing.Point(343, 101);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(79, 26);
            this.addDataButton.TabIndex = 4;
            this.addDataButton.Tag = "controlPanel";
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = false;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.bacPercentLabel);
            this.controlPanel.Controls.Add(this.playerSelectLabel);
            this.controlPanel.Controls.Add(this.bacPercentNumericUpDown);
            this.controlPanel.Controls.Add(this.playerSelectComboBox);
            this.controlPanel.Controls.Add(this.playCliffButton);
            this.controlPanel.Controls.Add(this.stopButton);
            this.controlPanel.Controls.Add(this.playPiRButton);
            this.controlPanel.Controls.Add(this.addDataButton);
            this.controlPanel.Controls.Add(this.addPlayerButton);
            this.controlPanel.Controls.Add(this.newPlayerNameLabel);
            this.controlPanel.Controls.Add(this.newPlayerNameTextBox);
            this.controlPanel.Location = new System.Drawing.Point(422, 50);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(443, 235);
            this.controlPanel.TabIndex = 8;
            this.controlPanel.Tag = "controlPanel";
            // 
            // playCliffButton
            // 
            this.playCliffButton.BackColor = System.Drawing.Color.White;
            this.playCliffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playCliffButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCliffButton.Location = new System.Drawing.Point(20, 152);
            this.playCliffButton.Name = "playCliffButton";
            this.playCliffButton.Size = new System.Drawing.Size(195, 46);
            this.playCliffButton.TabIndex = 5;
            this.playCliffButton.Tag = "controlPanel";
            this.playCliffButton.Text = "Play Cliff";
            this.playCliffButton.UseVisualStyleBackColor = false;
            this.playCliffButton.Click += new System.EventHandler(this.playCliffButton_Click);
            // 
            // playPiRButton
            // 
            this.playPiRButton.BackColor = System.Drawing.Color.White;
            this.playPiRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPiRButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPiRButton.Location = new System.Drawing.Point(227, 152);
            this.playPiRButton.Name = "playPiRButton";
            this.playPiRButton.Size = new System.Drawing.Size(195, 46);
            this.playPiRButton.TabIndex = 6;
            this.playPiRButton.Tag = "controlPanel";
            this.playPiRButton.Text = "Play PiR";
            this.playPiRButton.UseVisualStyleBackColor = false;
            this.playPiRButton.Click += new System.EventHandler(this.playPiRButton_Click);
            // 
            // climberPictureBox
            // 
            this.climberPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.climberPictureBox.Image = global::PriceIsRightParty.Properties.Resources.Climber;
            this.climberPictureBox.Location = new System.Drawing.Point(342, 317);
            this.climberPictureBox.Name = "climberPictureBox";
            this.climberPictureBox.Size = new System.Drawing.Size(89, 45);
            this.climberPictureBox.TabIndex = 9;
            this.climberPictureBox.TabStop = false;
            this.climberPictureBox.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(398, 206);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(24, 26);
            this.stopButton.TabIndex = 6;
            this.stopButton.Tag = "controlPanel";
            this.stopButton.Text = "■";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PriceIsRightParty.Properties.Resources.GradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 559);
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
    }
}

