
namespace GymSystem
{
    partial class forgotPass
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClientAchievmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
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
            this.ClientAchievmentsGroupBox.Controls.Add(this.label2);
            this.ClientAchievmentsGroupBox.Controls.Add(this.IDText);
            this.ClientAchievmentsGroupBox.Controls.Add(this.warning);
            this.ClientAchievmentsGroupBox.Controls.Add(this.label1);
            this.ClientAchievmentsGroupBox.Controls.Add(this.EmailText);
            this.ClientAchievmentsGroupBox.Controls.Add(this.SendButton);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 8);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(774, 434);
            this.ClientAchievmentsGroupBox.TabIndex = 8;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(16, 277);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(165, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send Password";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(16, 137);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(323, 22);
            this.EmailText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(13, 19);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(375, 16);
            this.warning.TabIndex = 3;
            this.warning.Text = "Only For Clients,  If you are an employee please refer to admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(16, 206);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(323, 22);
            this.IDText.TabIndex = 4;
            // 
            // forgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "forgotPass";
            this.Text = "forgotPass";
            this.Load += new System.EventHandler(this.forgotPass_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDText;
    }
}