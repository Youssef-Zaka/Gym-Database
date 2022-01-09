
namespace GymSystem
{
    partial class ViewClients
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
            this.AllClientslabel = new System.Windows.Forms.Label();
            this.LastVisitlabel = new System.Windows.Forms.Label();
            this.AllClientsDt = new System.Windows.Forms.DataGridView();
            this.LastVisitdt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastVisitdt)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClientslabel
            // 
            this.AllClientslabel.AutoSize = true;
            this.AllClientslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AllClientslabel.Location = new System.Drawing.Point(55, 9);
            this.AllClientslabel.Name = "AllClientslabel";
            this.AllClientslabel.Size = new System.Drawing.Size(78, 20);
            this.AllClientslabel.TabIndex = 0;
            this.AllClientslabel.Text = "All Clients";
            // 
            // LastVisitlabel
            // 
            this.LastVisitlabel.AutoSize = true;
            this.LastVisitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LastVisitlabel.Location = new System.Drawing.Point(385, 9);
            this.LastVisitlabel.Name = "LastVisitlabel";
            this.LastVisitlabel.Size = new System.Drawing.Size(74, 20);
            this.LastVisitlabel.TabIndex = 1;
            this.LastVisitlabel.Text = "Last Visit";
            // 
            // AllClientsDt
            // 
            this.AllClientsDt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AllClientsDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllClientsDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsDt.Location = new System.Drawing.Point(12, 51);
            this.AllClientsDt.Name = "AllClientsDt";
            this.AllClientsDt.Size = new System.Drawing.Size(297, 376);
            this.AllClientsDt.TabIndex = 2;
            // 
            // LastVisitdt
            // 
            this.LastVisitdt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LastVisitdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastVisitdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LastVisitdt.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LastVisitdt.Location = new System.Drawing.Point(389, 51);
            this.LastVisitdt.Name = "LastVisitdt";
            this.LastVisitdt.Size = new System.Drawing.Size(297, 376);
            this.LastVisitdt.TabIndex = 3;
            // 
            // ViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastVisitdt);
            this.Controls.Add(this.AllClientsDt);
            this.Controls.Add(this.LastVisitlabel);
            this.Controls.Add(this.AllClientslabel);
            this.Name = "ViewClients";
            this.Text = "ViewAllClients";
            this.Load += new System.EventHandler(this.ViewClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastVisitdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllClientslabel;
        private System.Windows.Forms.Label LastVisitlabel;
        private System.Windows.Forms.DataGridView AllClientsDt;
        private System.Windows.Forms.DataGridView LastVisitdt;
    }
}