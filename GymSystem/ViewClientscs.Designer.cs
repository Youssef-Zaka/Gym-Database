
namespace GymSystem
{
    partial class ViewClientscs
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
            this.ClientName = new System.Windows.Forms.Label();
            this.LastVisit = new System.Windows.Forms.Label();
            this.AllClientsDt = new System.Windows.Forms.DataGridView();
            this.LastVisitdt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastVisitdt)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(71, 9);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(64, 13);
            this.ClientName.TabIndex = 0;
            this.ClientName.Text = "Client Name";
            this.ClientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastVisit
            // 
            this.LastVisit.AutoSize = true;
            this.LastVisit.Location = new System.Drawing.Point(342, 9);
            this.LastVisit.Name = "LastVisit";
            this.LastVisit.Size = new System.Drawing.Size(49, 13);
            this.LastVisit.TabIndex = 1;
            this.LastVisit.Text = "Last Visit";
            // 
            // AllClientsDt
            // 
            this.AllClientsDt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AllClientsDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllClientsDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsDt.Location = new System.Drawing.Point(74, 56);
            this.AllClientsDt.Name = "AllClientsDt";
            this.AllClientsDt.Size = new System.Drawing.Size(248, 382);
            this.AllClientsDt.TabIndex = 2;
            // 
            // LastVisitdt
            // 
            this.LastVisitdt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LastVisitdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastVisitdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LastVisitdt.Location = new System.Drawing.Point(345, 56);
            this.LastVisitdt.Name = "LastVisitdt";
            this.LastVisitdt.Size = new System.Drawing.Size(141, 382);
            this.LastVisitdt.TabIndex = 3;
            // 
            // ViewClientscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastVisitdt);
            this.Controls.Add(this.AllClientsDt);
            this.Controls.Add(this.LastVisit);
            this.Controls.Add(this.ClientName);
            this.Name = "ViewClientscs";
            this.Text = "ViewClientscs";
            this.Load += new System.EventHandler(this.ViewClientscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastVisitdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label LastVisit;
        private System.Windows.Forms.DataGridView AllClientsDt;
        private System.Windows.Forms.DataGridView LastVisitdt;
    }
}