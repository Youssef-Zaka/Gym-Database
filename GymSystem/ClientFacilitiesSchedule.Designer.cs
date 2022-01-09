
namespace GymSystem
{
    partial class ClientFacilitiesSchedule
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
            this.ClientClassesScheduleDatagrid = new System.Windows.Forms.DataGridView();
            this.ClientFacilitiesScheduleDatagrid = new System.Windows.Forms.DataGridView();
            this.facilitieslabel = new System.Windows.Forms.Label();
            this.ClassesTable = new System.Windows.Forms.Label();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientClassesScheduleDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFacilitiesScheduleDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClassesTable);
            this.ClientAchievmentsGroupBox.Controls.Add(this.facilitieslabel);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientClassesScheduleDatagrid);
            this.ClientAchievmentsGroupBox.Controls.Add(this.ClientFacilitiesScheduleDatagrid);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(989, 425);
            this.ClientAchievmentsGroupBox.TabIndex = 6;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // ClientClassesScheduleDatagrid
            // 
            this.ClientClassesScheduleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientClassesScheduleDatagrid.Location = new System.Drawing.Point(516, 54);
            this.ClientClassesScheduleDatagrid.Name = "ClientClassesScheduleDatagrid";
            this.ClientClassesScheduleDatagrid.RowHeadersWidth = 51;
            this.ClientClassesScheduleDatagrid.RowTemplate.Height = 24;
            this.ClientClassesScheduleDatagrid.Size = new System.Drawing.Size(417, 349);
            this.ClientClassesScheduleDatagrid.TabIndex = 1;
            // 
            // ClientFacilitiesScheduleDatagrid
            // 
            this.ClientFacilitiesScheduleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientFacilitiesScheduleDatagrid.Location = new System.Drawing.Point(38, 54);
            this.ClientFacilitiesScheduleDatagrid.Name = "ClientFacilitiesScheduleDatagrid";
            this.ClientFacilitiesScheduleDatagrid.RowHeadersWidth = 51;
            this.ClientFacilitiesScheduleDatagrid.RowTemplate.Height = 24;
            this.ClientFacilitiesScheduleDatagrid.Size = new System.Drawing.Size(417, 349);
            this.ClientFacilitiesScheduleDatagrid.TabIndex = 0;
            // 
            // facilitieslabel
            // 
            this.facilitieslabel.AutoSize = true;
            this.facilitieslabel.Location = new System.Drawing.Point(700, 19);
            this.facilitieslabel.Name = "facilitieslabel";
            this.facilitieslabel.Size = new System.Drawing.Size(62, 17);
            this.facilitieslabel.TabIndex = 2;
            this.facilitieslabel.Text = "Facilities";
            // 
            // ClassesTable
            // 
            this.ClassesTable.AutoSize = true;
            this.ClassesTable.Location = new System.Drawing.Point(208, 19);
            this.ClassesTable.Name = "ClassesTable";
            this.ClassesTable.Size = new System.Drawing.Size(57, 17);
            this.ClassesTable.TabIndex = 3;
            this.ClassesTable.Text = "Classes";
            // 
            // ClientFacilitiesSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "ClientFacilitiesSchedule";
            this.Text = "ClientFacilitiesSchedule";
            this.Load += new System.EventHandler(this.ClientFacilitiesSchedule_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientClassesScheduleDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFacilitiesScheduleDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.DataGridView ClientFacilitiesScheduleDatagrid;
        private System.Windows.Forms.DataGridView ClientClassesScheduleDatagrid;
        private System.Windows.Forms.Label ClassesTable;
        private System.Windows.Forms.Label facilitieslabel;
    }
}