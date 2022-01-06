
namespace GymSystem
{
    partial class ClientAchievments
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
            this.AchievmentLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientAchievmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AchievmentLabel
            // 
            this.AchievmentLabel.AutoSize = true;
            this.AchievmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievmentLabel.Location = new System.Drawing.Point(6, 177);
            this.AchievmentLabel.Name = "AchievmentLabel";
            this.AchievmentLabel.Size = new System.Drawing.Size(163, 29);
            this.AchievmentLabel.TabIndex = 2;
            this.AchievmentLabel.Text = "Achievements";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(6, 57);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(78, 29);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Name";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(198, 57);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(78, 29);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "Name";
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.AchievmentLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientNameLabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientName);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(776, 426);
            this.ClientAchievmentsGroupBox.TabIndex = 4;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // ClientAchievments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "ClientAchievments";
            this.Text = "ClientAchievments";
            this.Load += new System.EventHandler(this.ClientAchievments_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AchievmentLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
    }
}