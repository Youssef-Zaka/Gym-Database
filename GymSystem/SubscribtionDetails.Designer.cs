
namespace GymSystem
{
    partial class SubscribtionDetails
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
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.SubscribtionLabel = new System.Windows.Forms.Label();
            this.SubDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.SubDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.ClientName.Location = new System.Drawing.Point(248, 57);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(78, 29);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "Name";
            // 
            // SubscribtionLabel
            // 
            this.SubscribtionLabel.AutoSize = true;
            this.SubscribtionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubscribtionLabel.Location = new System.Drawing.Point(6, 177);
            this.SubscribtionLabel.Name = "SubscribtionLabel";
            this.SubscribtionLabel.Size = new System.Drawing.Size(159, 29);
            this.SubscribtionLabel.TabIndex = 2;
            this.SubscribtionLabel.Text = "Subscribtions";
            // 
            // SubDetailsGroupBox
            // 
            this.SubDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubDetailsGroupBox.AutoSize = true;
            this.SubDetailsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubDetailsGroupBox.Controls.Add(this.PaymentMethod);
            this.SubDetailsGroupBox.Controls.Add(this.PaymentMethodLabel);
            this.SubDetailsGroupBox.Controls.Add(this.SubscribtionLabel);
            this.SubDetailsGroupBox.Controls.Add(this.ClientNameLabel);
            this.SubDetailsGroupBox.Controls.Add(this.ClientName);
            this.SubDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SubDetailsGroupBox.Name = "SubDetailsGroupBox";
            this.SubDetailsGroupBox.Size = new System.Drawing.Size(776, 426);
            this.SubDetailsGroupBox.TabIndex = 3;
            this.SubDetailsGroupBox.TabStop = false;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(6, 117);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(193, 29);
            this.PaymentMethodLabel.TabIndex = 3;
            this.PaymentMethodLabel.Text = "Payment Method";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(248, 117);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(193, 29);
            this.PaymentMethod.TabIndex = 4;
            this.PaymentMethod.Text = "Payment Method";
            // 
            // SubscribtionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubDetailsGroupBox);
            this.Name = "SubscribtionDetails";
            this.Text = "SubscribtionDetails";
            this.Load += new System.EventHandler(this.SubscribtionDetails_Load);
            this.SubDetailsGroupBox.ResumeLayout(false);
            this.SubDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label SubscribtionLabel;
        private System.Windows.Forms.GroupBox SubDetailsGroupBox;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.Label PaymentMethodLabel;
    }
}