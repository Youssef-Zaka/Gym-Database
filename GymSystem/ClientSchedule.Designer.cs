﻿
namespace GymSystem
{
    partial class ClientSchedule
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
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.FacilitiesButton = new System.Windows.Forms.Button();
            this.WorkoutsButton = new System.Windows.Forms.Button();
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
            this.ClientAchievmentsGroupBox.Controls.Add(this.backbutton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.exitbutton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.FacilitiesButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.WorkoutsButton);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(847, 424);
            this.ClientAchievmentsGroupBox.TabIndex = 5;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(633, 356);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 63;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click_1);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(750, 356);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 62;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // FacilitiesButton
            // 
            this.FacilitiesButton.Location = new System.Drawing.Point(343, 211);
            this.FacilitiesButton.Name = "FacilitiesButton";
            this.FacilitiesButton.Size = new System.Drawing.Size(159, 67);
            this.FacilitiesButton.TabIndex = 1;
            this.FacilitiesButton.Text = "Facilities";
            this.FacilitiesButton.UseVisualStyleBackColor = true;
            this.FacilitiesButton.Click += new System.EventHandler(this.FacilitiesButton_Click);
            // 
            // WorkoutsButton
            // 
            this.WorkoutsButton.Location = new System.Drawing.Point(343, 105);
            this.WorkoutsButton.Name = "WorkoutsButton";
            this.WorkoutsButton.Size = new System.Drawing.Size(159, 66);
            this.WorkoutsButton.TabIndex = 0;
            this.WorkoutsButton.Text = "Workouts";
            this.WorkoutsButton.UseVisualStyleBackColor = true;
            this.WorkoutsButton.Click += new System.EventHandler(this.WorkoutsButton_Click);
            // 
            // ClientSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "ClientSchedule";
            this.Text = "ClientSchedule";
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Button FacilitiesButton;
        private System.Windows.Forms.Button WorkoutsButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}