
namespace GymSystem
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.IDTEXT = new System.Windows.Forms.TextBox();
            this.IDLABEL = new System.Windows.Forms.Label();
            this.ClientRadio = new System.Windows.Forms.RadioButton();
            this.TrainerRadio = new System.Windows.Forms.RadioButton();
            this.ReceptionistRadio = new System.Windows.Forms.RadioButton();
            this.ForgotPassButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
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
            this.ClientAchievmentsGroupBox.Controls.Add(this.ForgotPassButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ReceptionistRadio);
            this.ClientAchievmentsGroupBox.Controls.Add(this.TrainerRadio);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientRadio);
            this.ClientAchievmentsGroupBox.Controls.Add(this.IDLABEL);
            this.ClientAchievmentsGroupBox.Controls.Add(this.IDTEXT);
            this.ClientAchievmentsGroupBox.Controls.Add(this.SignUpButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.exitbutton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.loginButton);
            this.ClientAchievmentsGroupBox.Controls.Add(this.PassText);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Password);
            this.ClientAchievmentsGroupBox.Controls.Add(this.UserText);
            this.ClientAchievmentsGroupBox.Controls.Add(this.Username);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(755, 434);
            this.ClientAchievmentsGroupBox.TabIndex = 7;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(218, 208);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(248, 42);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(218, 166);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(248, 22);
            this.PassText.TabIndex = 3;
            this.PassText.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(304, 138);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(218, 104);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(248, 22);
            this.UserText.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(304, 73);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "User Name";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(354, 341);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(112, 42);
            this.SignUpButton.TabIndex = 65;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // IDTEXT
            // 
            this.IDTEXT.Location = new System.Drawing.Point(218, 361);
            this.IDTEXT.Name = "IDTEXT";
            this.IDTEXT.Size = new System.Drawing.Size(115, 22);
            this.IDTEXT.TabIndex = 66;
            // 
            // IDLABEL
            // 
            this.IDLABEL.AutoSize = true;
            this.IDLABEL.Location = new System.Drawing.Point(215, 341);
            this.IDLABEL.Name = "IDLABEL";
            this.IDLABEL.Size = new System.Drawing.Size(21, 16);
            this.IDLABEL.TabIndex = 67;
            this.IDLABEL.Text = "ID";
            this.IDLABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientRadio
            // 
            this.ClientRadio.AutoSize = true;
            this.ClientRadio.Location = new System.Drawing.Point(40, 320);
            this.ClientRadio.Name = "ClientRadio";
            this.ClientRadio.Size = new System.Drawing.Size(59, 20);
            this.ClientRadio.TabIndex = 8;
            this.ClientRadio.TabStop = true;
            this.ClientRadio.Text = "Client";
            this.ClientRadio.UseVisualStyleBackColor = true;
            this.ClientRadio.CheckedChanged += new System.EventHandler(this.ClientRadio_CheckedChanged);
            // 
            // TrainerRadio
            // 
            this.TrainerRadio.AutoSize = true;
            this.TrainerRadio.Location = new System.Drawing.Point(40, 352);
            this.TrainerRadio.Name = "TrainerRadio";
            this.TrainerRadio.Size = new System.Drawing.Size(69, 20);
            this.TrainerRadio.TabIndex = 68;
            this.TrainerRadio.TabStop = true;
            this.TrainerRadio.Text = "Trainer";
            this.TrainerRadio.UseVisualStyleBackColor = true;
            this.TrainerRadio.CheckedChanged += new System.EventHandler(this.TrainerRadio_CheckedChanged);
            // 
            // ReceptionistRadio
            // 
            this.ReceptionistRadio.AutoSize = true;
            this.ReceptionistRadio.Location = new System.Drawing.Point(40, 378);
            this.ReceptionistRadio.Name = "ReceptionistRadio";
            this.ReceptionistRadio.Size = new System.Drawing.Size(101, 20);
            this.ReceptionistRadio.TabIndex = 69;
            this.ReceptionistRadio.TabStop = true;
            this.ReceptionistRadio.Text = "Receptionist";
            this.ReceptionistRadio.UseVisualStyleBackColor = true;
            this.ReceptionistRadio.CheckedChanged += new System.EventHandler(this.ReceptionistRadio_CheckedChanged);
            // 
            // ForgotPassButton
            // 
            this.ForgotPassButton.Location = new System.Drawing.Point(218, 273);
            this.ForgotPassButton.Name = "ForgotPassButton";
            this.ForgotPassButton.Size = new System.Drawing.Size(248, 23);
            this.ForgotPassButton.TabIndex = 70;
            this.ForgotPassButton.Text = "Forgot Password?";
            this.ForgotPassButton.UseVisualStyleBackColor = true;
            this.ForgotPassButton.Click += new System.EventHandler(this.ForgotPassButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(644, 365);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 64;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(781, 460);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label IDLABEL;
        private System.Windows.Forms.TextBox IDTEXT;
        private System.Windows.Forms.RadioButton ReceptionistRadio;
        private System.Windows.Forms.RadioButton TrainerRadio;
        private System.Windows.Forms.RadioButton ClientRadio;
        private System.Windows.Forms.Button ForgotPassButton;
    }
}