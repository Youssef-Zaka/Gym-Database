
namespace GymSystem
{
    partial class PotentialClient
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
            this.PCfname = new System.Windows.Forms.Label();
            this.AddPotentialClientButton = new System.Windows.Forms.Button();
            this.PCphoneNumbertxt = new System.Windows.Forms.TextBox();
            this.PCclientAdresstxt = new System.Windows.Forms.TextBox();
            this.PClNametxt = new System.Windows.Forms.TextBox();
            this.PCfNametxt = new System.Windows.Forms.TextBox();
            this.PCbDatepicker = new System.Windows.Forms.DateTimePicker();
            this.PCclientAddress = new System.Windows.Forms.Label();
            this.PCphoneNum = new System.Windows.Forms.Label();
            this.PCbDate = new System.Windows.Forms.Label();
            this.PClName = new System.Windows.Forms.Label();
            this.PCSSNtxt = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PCfname
            // 
            this.PCfname.AutoSize = true;
            this.PCfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PCfname.Location = new System.Drawing.Point(14, 34);
            this.PCfname.Name = "PCfname";
            this.PCfname.Size = new System.Drawing.Size(86, 20);
            this.PCfname.TabIndex = 1;
            this.PCfname.Text = "First Name";
            // 
            // AddPotentialClientButton
            // 
            this.AddPotentialClientButton.Location = new System.Drawing.Point(227, 264);
            this.AddPotentialClientButton.Name = "AddPotentialClientButton";
            this.AddPotentialClientButton.Size = new System.Drawing.Size(183, 29);
            this.AddPotentialClientButton.TabIndex = 32;
            this.AddPotentialClientButton.Text = "Add Potential Client";
            this.AddPotentialClientButton.UseVisualStyleBackColor = true;
            this.AddPotentialClientButton.Click += new System.EventHandler(this.AddPotentialClientButton_Click);
            // 
            // PCphoneNumbertxt
            // 
            this.PCphoneNumbertxt.Location = new System.Drawing.Point(150, 151);
            this.PCphoneNumbertxt.Name = "PCphoneNumbertxt";
            this.PCphoneNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.PCphoneNumbertxt.TabIndex = 28;
            this.PCphoneNumbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCphoneNumbertxt_KeyPress);
            // 
            // PCclientAdresstxt
            // 
            this.PCclientAdresstxt.Location = new System.Drawing.Point(527, 151);
            this.PCclientAdresstxt.Name = "PCclientAdresstxt";
            this.PCclientAdresstxt.Size = new System.Drawing.Size(100, 20);
            this.PCclientAdresstxt.TabIndex = 27;
            // 
            // PClNametxt
            // 
            this.PClNametxt.Location = new System.Drawing.Point(527, 32);
            this.PClNametxt.Name = "PClNametxt";
            this.PClNametxt.Size = new System.Drawing.Size(100, 20);
            this.PClNametxt.TabIndex = 26;
            this.PClNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PClNametxt_KeyPress);
            // 
            // PCfNametxt
            // 
            this.PCfNametxt.Location = new System.Drawing.Point(150, 34);
            this.PCfNametxt.Name = "PCfNametxt";
            this.PCfNametxt.Size = new System.Drawing.Size(100, 20);
            this.PCfNametxt.TabIndex = 25;
            this.PCfNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCfNametxt_KeyPress);
            // 
            // PCbDatepicker
            // 
            this.PCbDatepicker.Location = new System.Drawing.Point(150, 94);
            this.PCbDatepicker.Name = "PCbDatepicker";
            this.PCbDatepicker.Size = new System.Drawing.Size(200, 20);
            this.PCbDatepicker.TabIndex = 24;
            // 
            // PCclientAddress
            // 
            this.PCclientAddress.AutoSize = true;
            this.PCclientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PCclientAddress.Location = new System.Drawing.Point(368, 151);
            this.PCclientAddress.Name = "PCclientAddress";
            this.PCclientAddress.Size = new System.Drawing.Size(112, 20);
            this.PCclientAddress.TabIndex = 22;
            this.PCclientAddress.Text = "Client Address";
            // 
            // PCphoneNum
            // 
            this.PCphoneNum.AutoSize = true;
            this.PCphoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PCphoneNum.Location = new System.Drawing.Point(14, 151);
            this.PCphoneNum.Name = "PCphoneNum";
            this.PCphoneNum.Size = new System.Drawing.Size(115, 20);
            this.PCphoneNum.TabIndex = 21;
            this.PCphoneNum.Text = "Phone Number";
            // 
            // PCbDate
            // 
            this.PCbDate.AutoSize = true;
            this.PCbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PCbDate.Location = new System.Drawing.Point(13, 94);
            this.PCbDate.Name = "PCbDate";
            this.PCbDate.Size = new System.Drawing.Size(81, 20);
            this.PCbDate.TabIndex = 20;
            this.PCbDate.Text = "Birth Date";
            // 
            // PClName
            // 
            this.PClName.AutoSize = true;
            this.PClName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PClName.Location = new System.Drawing.Point(368, 30);
            this.PClName.Name = "PClName";
            this.PClName.Size = new System.Drawing.Size(86, 20);
            this.PClName.TabIndex = 19;
            this.PClName.Text = "Last Name";
            // 
            // PCSSNtxt
            // 
            this.PCSSNtxt.Location = new System.Drawing.Point(527, 94);
            this.PCSSNtxt.Name = "PCSSNtxt";
            this.PCSSNtxt.Size = new System.Drawing.Size(100, 20);
            this.PCSSNtxt.TabIndex = 34;
            this.PCSSNtxt.TextChanged += new System.EventHandler(this.PCSSNtxt_TextChanged);
            this.PCSSNtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCSSNtxt_KeyPress);
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SSN.Location = new System.Drawing.Point(368, 94);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(42, 20);
            this.SSN.TabIndex = 33;
            this.SSN.Text = "SSN";
            // 
            // PotentialClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCSSNtxt);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.AddPotentialClientButton);
            this.Controls.Add(this.PCphoneNumbertxt);
            this.Controls.Add(this.PCclientAdresstxt);
            this.Controls.Add(this.PClNametxt);
            this.Controls.Add(this.PCfNametxt);
            this.Controls.Add(this.PCbDatepicker);
            this.Controls.Add(this.PCclientAddress);
            this.Controls.Add(this.PCphoneNum);
            this.Controls.Add(this.PCbDate);
            this.Controls.Add(this.PClName);
            this.Controls.Add(this.PCfname);
            this.Name = "PotentialClient";
            this.Text = "PotentialClient";
            this.Load += new System.EventHandler(this.PotentialClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PCfname;
        private System.Windows.Forms.Button AddPotentialClientButton;
        private System.Windows.Forms.TextBox PCphoneNumbertxt;
        private System.Windows.Forms.TextBox PCclientAdresstxt;
        private System.Windows.Forms.TextBox PClNametxt;
        private System.Windows.Forms.TextBox PCfNametxt;
        private System.Windows.Forms.DateTimePicker PCbDatepicker;
        private System.Windows.Forms.Label PCclientAddress;
        private System.Windows.Forms.Label PCphoneNum;
        private System.Windows.Forms.Label PCbDate;
        private System.Windows.Forms.Label PClName;
        private System.Windows.Forms.TextBox PCSSNtxt;
        private System.Windows.Forms.Label SSN;
    }
}