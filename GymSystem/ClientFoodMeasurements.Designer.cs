
namespace GymSystem
{
    partial class ClientFoodMeasurements
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
            this.MeasurementsLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.AddMeasurementButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.MeasurementsLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientNameLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientName);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(1042, 475);
            this.ClientAchievmentsGroupBox.TabIndex = 7;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // AddMeasurementButton
            // 
            this.AddMeasurementButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddMeasurementButton.Location = new System.Drawing.Point(844, 39);
            this.AddMeasurementButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMeasurementButton.Name = "AddMeasurementButton";
            this.AddMeasurementButton.Size = new System.Drawing.Size(183, 33);
            this.AddMeasurementButton.TabIndex = 6;
            this.AddMeasurementButton.Text = "Add Measurement";
            this.AddMeasurementButton.UseVisualStyleBackColor = false;
            this.AddMeasurementButton.Click += new System.EventHandler(this.AddMeasurementButton_Click);
            // 
            // MeasurementsLabel
            // 
            this.MeasurementsLabel.AutoSize = true;
            this.MeasurementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasurementsLabel.Location = new System.Drawing.Point(8, 105);
            this.MeasurementsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeasurementsLabel.Name = "MeasurementsLabel";
            this.MeasurementsLabel.Size = new System.Drawing.Size(209, 36);
            this.MeasurementsLabel.TabIndex = 5;
            this.MeasurementsLabel.Text = "Measurements";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(8, 39);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(92, 36);
            this.ClientNameLabel.TabIndex = 3;
            this.ClientNameLabel.Text = "Name";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(264, 39);
            this.ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(92, 36);
            this.ClientName.TabIndex = 4;
            this.ClientName.Text = "Name";
            // 
            // ClientFoodMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "ClientFoodMeasurements";
            this.Text = "ClientFoodMeasurements";
            this.Load += new System.EventHandler(this.ClientFoodMeasurements_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Button AddMeasurementButton;
        private System.Windows.Forms.Label MeasurementsLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientName;
    }
}