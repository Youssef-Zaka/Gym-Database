
namespace GymSystem
{
    partial class ViewSurvey
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewSurveysdatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSurveysdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All surveys";
            // 
            // ViewSurveysdatagrid
            // 
            this.ViewSurveysdatagrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewSurveysdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewSurveysdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSurveysdatagrid.Location = new System.Drawing.Point(17, 47);
            this.ViewSurveysdatagrid.Name = "ViewSurveysdatagrid";
            this.ViewSurveysdatagrid.Size = new System.Drawing.Size(771, 391);
            this.ViewSurveysdatagrid.TabIndex = 1;
            this.ViewSurveysdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewSurveysdatagrid_CellContentClick);
            // 
            // ViewSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewSurveysdatagrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewSurvey";
            this.Text = "ViewSurvey";
            this.Load += new System.EventHandler(this.ViewSurvey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSurveysdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewSurveysdatagrid;
    }
}