
namespace GymSystem
{
    partial class PaymentMethodManagement
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
            this.paymentMethodcombo = new System.Windows.Forms.ComboBox();
            this.paymentMethodlabel = new System.Windows.Forms.Label();
            this.AllClientsDt = new System.Windows.Forms.DataGridView();
            this.ClientIDslabel = new System.Windows.Forms.Label();
            this.ClientIDlabel = new System.Windows.Forms.Label();
            this.ClientIDtext = new System.Windows.Forms.TextBox();
            this.UpdatePaymentMethodButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentMethodcombo
            // 
            this.paymentMethodcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodcombo.FormattingEnabled = true;
            this.paymentMethodcombo.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.paymentMethodcombo.Location = new System.Drawing.Point(577, 107);
            this.paymentMethodcombo.Name = "paymentMethodcombo";
            this.paymentMethodcombo.Size = new System.Drawing.Size(121, 21);
            this.paymentMethodcombo.TabIndex = 17;
            // 
            // paymentMethodlabel
            // 
            this.paymentMethodlabel.AutoSize = true;
            this.paymentMethodlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.paymentMethodlabel.Location = new System.Drawing.Point(407, 108);
            this.paymentMethodlabel.Name = "paymentMethodlabel";
            this.paymentMethodlabel.Size = new System.Drawing.Size(129, 20);
            this.paymentMethodlabel.TabIndex = 16;
            this.paymentMethodlabel.Text = "Payment method";
            // 
            // AllClientsDt
            // 
            this.AllClientsDt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AllClientsDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllClientsDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsDt.Location = new System.Drawing.Point(12, 62);
            this.AllClientsDt.Name = "AllClientsDt";
            this.AllClientsDt.Size = new System.Drawing.Size(351, 376);
            this.AllClientsDt.TabIndex = 19;
            this.AllClientsDt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllClientsDt_CellContentClick);
            // 
            // ClientIDslabel
            // 
            this.ClientIDslabel.AutoSize = true;
            this.ClientIDslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClientIDslabel.Location = new System.Drawing.Point(55, 20);
            this.ClientIDslabel.Name = "ClientIDslabel";
            this.ClientIDslabel.Size = new System.Drawing.Size(86, 20);
            this.ClientIDslabel.TabIndex = 18;
            this.ClientIDslabel.Text = "Clients IDs";
            // 
            // ClientIDlabel
            // 
            this.ClientIDlabel.AutoSize = true;
            this.ClientIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClientIDlabel.Location = new System.Drawing.Point(407, 18);
            this.ClientIDlabel.Name = "ClientIDlabel";
            this.ClientIDlabel.Size = new System.Drawing.Size(70, 20);
            this.ClientIDlabel.TabIndex = 20;
            this.ClientIDlabel.Text = "Client ID";
            // 
            // ClientIDtext
            // 
            this.ClientIDtext.Location = new System.Drawing.Point(577, 20);
            this.ClientIDtext.Name = "ClientIDtext";
            this.ClientIDtext.Size = new System.Drawing.Size(100, 20);
            this.ClientIDtext.TabIndex = 21;
            this.ClientIDtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDtext_KeyPress);
            // 
            // UpdatePaymentMethodButton
            // 
            this.UpdatePaymentMethodButton.Location = new System.Drawing.Point(411, 191);
            this.UpdatePaymentMethodButton.Name = "UpdatePaymentMethodButton";
            this.UpdatePaymentMethodButton.Size = new System.Drawing.Size(287, 29);
            this.UpdatePaymentMethodButton.TabIndex = 22;
            this.UpdatePaymentMethodButton.Text = "Update Payment Method";
            this.UpdatePaymentMethodButton.UseVisualStyleBackColor = true;
            this.UpdatePaymentMethodButton.Click += new System.EventHandler(this.UpdatePaymentMethodButton_Click);
            // 
            // PaymentMethodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatePaymentMethodButton);
            this.Controls.Add(this.ClientIDtext);
            this.Controls.Add(this.ClientIDlabel);
            this.Controls.Add(this.AllClientsDt);
            this.Controls.Add(this.ClientIDslabel);
            this.Controls.Add(this.paymentMethodcombo);
            this.Controls.Add(this.paymentMethodlabel);
            this.Name = "PaymentMethodManagement";
            this.Text = "PaymentMethodManagement";
            this.Load += new System.EventHandler(this.PaymentMethodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paymentMethodcombo;
        private System.Windows.Forms.Label paymentMethodlabel;
        private System.Windows.Forms.DataGridView AllClientsDt;
        private System.Windows.Forms.Label ClientIDslabel;
        private System.Windows.Forms.Label ClientIDlabel;
        private System.Windows.Forms.TextBox ClientIDtext;
        private System.Windows.Forms.Button UpdatePaymentMethodButton;
    }
}