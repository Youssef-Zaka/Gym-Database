
namespace GymSystem
{
    partial class NewClient
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
            this.fname = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bDate = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.Label();
            this.clientAddress = new System.Windows.Forms.Label();
            this.paymentMethod = new System.Windows.Forms.Label();
            this.bDatepicker = new System.Windows.Forms.DateTimePicker();
            this.fNametxt = new System.Windows.Forms.TextBox();
            this.lNametxt = new System.Windows.Forms.TextBox();
            this.clientAdresstxt = new System.Windows.Forms.TextBox();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.paymentMethodcombo = new System.Windows.Forms.ComboBox();
            this.invitationNum = new System.Windows.Forms.Label();
            this.InvitationNumbertxt = new System.Windows.Forms.TextBox();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.fname.Location = new System.Drawing.Point(21, 13);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(86, 20);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lName.Location = new System.Drawing.Point(363, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(86, 20);
            this.lName.TabIndex = 1;
            this.lName.Text = "Last Name";
            // 
            // bDate
            // 
            this.bDate.AutoSize = true;
            this.bDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bDate.Location = new System.Drawing.Point(20, 75);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(81, 20);
            this.bDate.TabIndex = 2;
            this.bDate.Text = "Birth Date";
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.phoneNum.Location = new System.Drawing.Point(363, 75);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(115, 20);
            this.phoneNum.TabIndex = 3;
            this.phoneNum.Text = "Phone Number";
            // 
            // clientAddress
            // 
            this.clientAddress.AutoSize = true;
            this.clientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.clientAddress.Location = new System.Drawing.Point(20, 132);
            this.clientAddress.Name = "clientAddress";
            this.clientAddress.Size = new System.Drawing.Size(112, 20);
            this.clientAddress.TabIndex = 5;
            this.clientAddress.Text = "Client Address";
            // 
            // paymentMethod
            // 
            this.paymentMethod.AutoSize = true;
            this.paymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.paymentMethod.Location = new System.Drawing.Point(21, 199);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(129, 20);
            this.paymentMethod.TabIndex = 6;
            this.paymentMethod.Text = "Payment method";
            // 
            // bDatepicker
            // 
            this.bDatepicker.Location = new System.Drawing.Point(157, 75);
            this.bDatepicker.Name = "bDatepicker";
            this.bDatepicker.Size = new System.Drawing.Size(200, 20);
            this.bDatepicker.TabIndex = 8;
            // 
            // fNametxt
            // 
            this.fNametxt.Location = new System.Drawing.Point(157, 15);
            this.fNametxt.Name = "fNametxt";
            this.fNametxt.Size = new System.Drawing.Size(100, 20);
            this.fNametxt.TabIndex = 11;
            this.fNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fNametxt_KeyPress);
            // 
            // lNametxt
            // 
            this.lNametxt.Location = new System.Drawing.Point(523, 13);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(100, 20);
            this.lNametxt.TabIndex = 12;
            this.lNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lNametxt_KeyPress);
            // 
            // clientAdresstxt
            // 
            this.clientAdresstxt.Location = new System.Drawing.Point(157, 134);
            this.clientAdresstxt.Name = "clientAdresstxt";
            this.clientAdresstxt.Size = new System.Drawing.Size(100, 20);
            this.clientAdresstxt.TabIndex = 13;
            this.clientAdresstxt.TextChanged += new System.EventHandler(this.clientAdresstxt_TextChanged);
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(523, 75);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.phoneNumbertxt.TabIndex = 14;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged);
            this.phoneNumbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumbertxt_KeyPress);
            // 
            // paymentMethodcombo
            // 
            this.paymentMethodcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodcombo.FormattingEnabled = true;
            this.paymentMethodcombo.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.paymentMethodcombo.Location = new System.Drawing.Point(157, 198);
            this.paymentMethodcombo.Name = "paymentMethodcombo";
            this.paymentMethodcombo.Size = new System.Drawing.Size(121, 21);
            this.paymentMethodcombo.TabIndex = 15;
            // 
            // invitationNum
            // 
            this.invitationNum.AutoSize = true;
            this.invitationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.invitationNum.Location = new System.Drawing.Point(363, 134);
            this.invitationNum.Name = "invitationNum";
            this.invitationNum.Size = new System.Drawing.Size(141, 20);
            this.invitationNum.TabIndex = 16;
            this.invitationNum.Text = "Invitations Number";
            // 
            // InvitationNumbertxt
            // 
            this.InvitationNumbertxt.Location = new System.Drawing.Point(523, 134);
            this.InvitationNumbertxt.Name = "InvitationNumbertxt";
            this.InvitationNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.InvitationNumbertxt.TabIndex = 17;
            this.InvitationNumbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvitationNumbertxt_KeyPress);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(266, 287);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(183, 29);
            this.AddClientButton.TabIndex = 18;
            this.AddClientButton.Text = "Add New Client";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.InvitationNumbertxt);
            this.Controls.Add(this.invitationNum);
            this.Controls.Add(this.paymentMethodcombo);
            this.Controls.Add(this.phoneNumbertxt);
            this.Controls.Add(this.clientAdresstxt);
            this.Controls.Add(this.lNametxt);
            this.Controls.Add(this.fNametxt);
            this.Controls.Add(this.bDatepicker);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.clientAddress);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fname);
            this.Name = "NewClient";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label bDate;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.Label clientAddress;
        private System.Windows.Forms.Label paymentMethod;
        private System.Windows.Forms.DateTimePicker bDatepicker;
        private System.Windows.Forms.TextBox fNametxt;
        private System.Windows.Forms.TextBox lNametxt;
        private System.Windows.Forms.TextBox clientAdresstxt;
        private System.Windows.Forms.TextBox phoneNumbertxt;
        private System.Windows.Forms.ComboBox paymentMethodcombo;
        private System.Windows.Forms.Label invitationNum;
        private System.Windows.Forms.TextBox InvitationNumbertxt;
        private System.Windows.Forms.Button AddClientButton;
    }
}