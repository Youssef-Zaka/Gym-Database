
namespace GymSystem
{
    partial class AddFoodMeasurement
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
            this.ClientAchievmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddMeasurementButton = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.Label();
            this.HoursTrackbar = new System.Windows.Forms.TrackBar();
            this.Cal = new System.Windows.Forms.Label();
            this.CalTrackBar = new System.Windows.Forms.TrackBar();
            this.waterLabel = new System.Windows.Forms.Label();
            this.SleepLabel = new System.Windows.Forms.Label();
            this.CalloriesLabel = new System.Windows.Forms.Label();
            this.WaterTrackbar = new System.Windows.Forms.TrackBar();
            this.Water = new System.Windows.Forms.Label();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.Water);
            this.ClientAchievmentsGroupBox.Controls.Add(this.WaterTrackbar);
            this.ClientAchievmentsGroupBox.Controls.Add(this.AddMeasurementButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Hours);
            this.ClientAchievmentsGroupBox.Controls.Add(this.HoursTrackbar);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Cal);
            this.ClientAchievmentsGroupBox.Controls.Add(this.CalTrackBar);
            this.ClientAchievmentsGroupBox.Controls.Add(this.waterLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.SleepLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.CalloriesLabel);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(1077, 510);
            this.ClientAchievmentsGroupBox.TabIndex = 6;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // AddMeasurementButton
            // 
            this.AddMeasurementButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddMeasurementButton.Location = new System.Drawing.Point(35, 454);
            this.AddMeasurementButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMeasurementButton.Name = "AddMeasurementButton";
            this.AddMeasurementButton.Size = new System.Drawing.Size(205, 28);
            this.AddMeasurementButton.TabIndex = 6;
            this.AddMeasurementButton.Text = "Add";
            this.AddMeasurementButton.UseVisualStyleBackColor = false;
            this.AddMeasurementButton.Click += new System.EventHandler(this.AddMeasurementButton_Click);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(29, 252);
            this.Hours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(64, 25);
            this.Hours.TabIndex = 7;
            this.Hours.Text = "Hours";
            // 
            // HoursTrackbar
            // 
            this.HoursTrackbar.BackColor = System.Drawing.SystemColors.Info;
            this.HoursTrackbar.Location = new System.Drawing.Point(247, 222);
            this.HoursTrackbar.Margin = new System.Windows.Forms.Padding(4);
            this.HoursTrackbar.Maximum = 24;
            this.HoursTrackbar.Name = "HoursTrackbar";
            this.HoursTrackbar.Size = new System.Drawing.Size(770, 56);
            this.HoursTrackbar.TabIndex = 6;
            this.HoursTrackbar.Value = 8;
            this.HoursTrackbar.Scroll += new System.EventHandler(this.HeightTrackbar_Scroll);
            // 
            // Cal
            // 
            this.Cal.AutoSize = true;
            this.Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal.Location = new System.Drawing.Point(29, 95);
            this.Cal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(88, 25);
            this.Cal.TabIndex = 5;
            this.Cal.Text = "Callories";
            // 
            // CalTrackBar
            // 
            this.CalTrackBar.BackColor = System.Drawing.SystemColors.Info;
            this.CalTrackBar.Location = new System.Drawing.Point(116, 64);
            this.CalTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.CalTrackBar.Maximum = 5000;
            this.CalTrackBar.Name = "CalTrackBar";
            this.CalTrackBar.Size = new System.Drawing.Size(901, 56);
            this.CalTrackBar.TabIndex = 4;
            this.CalTrackBar.TickFrequency = 100;
            this.CalTrackBar.Value = 2200;
            this.CalTrackBar.Scroll += new System.EventHandler(this.WeightTrackBar_Scroll);
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterLabel.Location = new System.Drawing.Point(29, 337);
            this.waterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(141, 25);
            this.waterLabel.TabIndex = 3;
            this.waterLabel.Text = "Water Glasses";
            // 
            // SleepLabel
            // 
            this.SleepLabel.AutoSize = true;
            this.SleepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepLabel.Location = new System.Drawing.Point(29, 222);
            this.SleepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SleepLabel.Name = "SleepLabel";
            this.SleepLabel.Size = new System.Drawing.Size(114, 25);
            this.SleepLabel.TabIndex = 2;
            this.SleepLabel.Text = "Hours Slept";
            // 
            // CalloriesLabel
            // 
            this.CalloriesLabel.AutoSize = true;
            this.CalloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalloriesLabel.Location = new System.Drawing.Point(29, 64);
            this.CalloriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalloriesLabel.Name = "CalloriesLabel";
            this.CalloriesLabel.Size = new System.Drawing.Size(88, 25);
            this.CalloriesLabel.TabIndex = 1;
            this.CalloriesLabel.Text = "Callories";
            // 
            // WaterTrackbar
            // 
            this.WaterTrackbar.BackColor = System.Drawing.SystemColors.Info;
            this.WaterTrackbar.Location = new System.Drawing.Point(247, 337);
            this.WaterTrackbar.Margin = new System.Windows.Forms.Padding(4);
            this.WaterTrackbar.Maximum = 30;
            this.WaterTrackbar.Name = "WaterTrackbar";
            this.WaterTrackbar.Size = new System.Drawing.Size(770, 56);
            this.WaterTrackbar.TabIndex = 8;
            this.WaterTrackbar.Value = 10;
            this.WaterTrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Water
            // 
            this.Water.AutoSize = true;
            this.Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Water.Location = new System.Drawing.Point(30, 368);
            this.Water.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(65, 25);
            this.Water.TabIndex = 9;
            this.Water.Text = "Water";
            // 
            // AddFoodMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1103, 536);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "AddFoodMeasurement";
            this.Text = "AddFoodMeasurement";
            this.Load += new System.EventHandler(this.AddFoodMeasurement_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Button AddMeasurementButton;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.TrackBar HoursTrackbar;
        private System.Windows.Forms.Label Cal;
        private System.Windows.Forms.TrackBar CalTrackBar;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label SleepLabel;
        private System.Windows.Forms.Label CalloriesLabel;
        private System.Windows.Forms.Label Water;
        private System.Windows.Forms.TrackBar WaterTrackbar;
    }
}