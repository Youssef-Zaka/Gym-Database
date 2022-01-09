
namespace GymSystem
{
    partial class SelfDevelopmentLinks
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
            this.CourseLinkslabel = new System.Windows.Forms.Label();
            this.CourseLinksgridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CourseLinksgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseLinkslabel
            // 
            this.CourseLinkslabel.AutoSize = true;
            this.CourseLinkslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CourseLinkslabel.Location = new System.Drawing.Point(12, 9);
            this.CourseLinkslabel.Name = "CourseLinkslabel";
            this.CourseLinkslabel.Size = new System.Drawing.Size(101, 20);
            this.CourseLinkslabel.TabIndex = 8;
            this.CourseLinkslabel.Text = "Course Links";
            // 
            // CourseLinksgridview
            // 
            this.CourseLinksgridview.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CourseLinksgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseLinksgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseLinksgridview.Location = new System.Drawing.Point(16, 57);
            this.CourseLinksgridview.Name = "CourseLinksgridview";
            this.CourseLinksgridview.Size = new System.Drawing.Size(478, 381);
            this.CourseLinksgridview.TabIndex = 9;
            // 
            // SelfDevelopmentLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseLinksgridview);
            this.Controls.Add(this.CourseLinkslabel);
            this.Name = "SelfDevelopmentLinks";
            this.Text = "SelfDevelopmentLinks";
            this.Load += new System.EventHandler(this.SelfDevelopmentLinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseLinksgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLinkslabel;
        private System.Windows.Forms.DataGridView CourseLinksgridview;
    }
}