
namespace GymSystem
{
    partial class AddMeasurement
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
            this.BodyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Height = new System.Windows.Forms.Label();
            this.HeightTrackbar = new System.Windows.Forms.TrackBar();
            this.Weight = new System.Windows.Forms.Label();
            this.WeightTrackBar = new System.Windows.Forms.TrackBar();
            this.BodyTypeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.backbutton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.exitbutton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.AddMeasurementButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.BodyTypeComboBox);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Height);
            this.ClientAchievmentsGroupBox.Controls.Add(this.HeightTrackbar);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Weight);
            this.ClientAchievmentsGroupBox.Controls.Add(this.WeightTrackBar);
            this.ClientAchievmentsGroupBox.Controls.Add(this.BodyTypeLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.HeightLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.WeightLabel);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(16, 15);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(1035, 524);
            this.ClientAchievmentsGroupBox.TabIndex = 5;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // AddMeasurementButton
            // 
            this.AddMeasurementButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddMeasurementButton.Location = new System.Drawing.Point(35, 454);
            this.AddMeasurementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMeasurementButton.Name = "AddMeasurementButton";
            this.AddMeasurementButton.Size = new System.Drawing.Size(205, 28);
            this.AddMeasurementButton.TabIndex = 6;
            this.AddMeasurementButton.Text = "Add";
            this.AddMeasurementButton.UseVisualStyleBackColor = false;
            this.AddMeasurementButton.Click += new System.EventHandler(this.AddMeasurementButton_Click);
            // 
            // BodyTypeComboBox
            // 
            this.BodyTypeComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.BodyTypeComboBox.FormattingEnabled = true;
            this.BodyTypeComboBox.Items.AddRange(new object[] {
            "slim",
            "fit",
            "obese"});
            this.BodyTypeComboBox.Location = new System.Drawing.Point(185, 361);
            this.BodyTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BodyTypeComboBox.Name = "BodyTypeComboBox";
            this.BodyTypeComboBox.Size = new System.Drawing.Size(217, 24);
            this.BodyTypeComboBox.TabIndex = 8;
            this.BodyTypeComboBox.Text = "Choose Body Type";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(29, 252);
            this.Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(56, 20);
            this.Height.TabIndex = 7;
            this.Height.Text = "Height";
            // 
            // HeightTrackbar
            // 
            this.HeightTrackbar.BackColor = System.Drawing.SystemColors.Info;
            this.HeightTrackbar.Location = new System.Drawing.Point(116, 222);
            this.HeightTrackbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightTrackbar.Maximum = 250;
            this.HeightTrackbar.Minimum = 100;
            this.HeightTrackbar.Name = "HeightTrackbar";
            this.HeightTrackbar.Size = new System.Drawing.Size(901, 45);
            this.HeightTrackbar.TabIndex = 6;
            this.HeightTrackbar.Value = 100;
            this.HeightTrackbar.Scroll += new System.EventHandler(this.HeightTrackbar_Scroll);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(29, 95);
            this.Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(59, 20);
            this.Weight.TabIndex = 5;
            this.Weight.Text = "Weight";
            // 
            // WeightTrackBar
            // 
            this.WeightTrackBar.BackColor = System.Drawing.SystemColors.Info;
            this.WeightTrackBar.Location = new System.Drawing.Point(116, 64);
            this.WeightTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeightTrackBar.Maximum = 150;
            this.WeightTrackBar.Minimum = 30;
            this.WeightTrackBar.Name = "WeightTrackBar";
            this.WeightTrackBar.Size = new System.Drawing.Size(901, 45);
            this.WeightTrackBar.TabIndex = 4;
            this.WeightTrackBar.Value = 30;
            this.WeightTrackBar.Scroll += new System.EventHandler(this.WeightTrackBar_Scroll);
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyTypeLabel.Location = new System.Drawing.Point(29, 358);
            this.BodyTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BodyTypeLabel.Name = "BodyTypeLabel";
            this.BodyTypeLabel.Size = new System.Drawing.Size(83, 20);
            this.BodyTypeLabel.TabIndex = 3;
            this.BodyTypeLabel.Text = "Body Type";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(29, 222);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(56, 20);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(29, 64);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(59, 20);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(774, 447);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 61;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(891, 447);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 60;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // AddMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMeasurement";
            this.Text = "AddMeasurement";
            this.Load += new System.EventHandler(this.AddMeasurement_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Label BodyTypeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TrackBar WeightTrackBar;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TrackBar HeightTrackbar;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.ComboBox BodyTypeComboBox;
        private System.Windows.Forms.Button AddMeasurementButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}