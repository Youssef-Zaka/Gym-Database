
namespace GymSystem
{
    partial class ClientWorkouts
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
            this.PrivateGridView = new System.Windows.Forms.DataGridView();
            this.PrivateSessions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AllWorkoutsGrid = new System.Windows.Forms.DataGridView();
            this.WorkoutComboBox = new System.Windows.Forms.ComboBox();
            this.ClientAchievmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllWorkoutsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientAchievmentsGroupBox
            // 
            this.ClientAchievmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAchievmentsGroupBox.AutoSize = true;
            this.ClientAchievmentsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientAchievmentsGroupBox.Controls.Add(this.WorkoutComboBox);
            this.ClientAchievmentsGroupBox.Controls.Add(this.AllWorkoutsGrid);
            this.ClientAchievmentsGroupBox.Controls.Add(this.label1);
            this.ClientAchievmentsGroupBox.Controls.Add(this.PrivateSessions);
            this.ClientAchievmentsGroupBox.Controls.Add(this.PrivateGridView);
            this.ClientAchievmentsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ClientAchievmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Name = "ClientAchievmentsGroupBox";
            this.ClientAchievmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientAchievmentsGroupBox.Size = new System.Drawing.Size(1028, 441);
            this.ClientAchievmentsGroupBox.TabIndex = 6;
            this.ClientAchievmentsGroupBox.TabStop = false;
            // 
            // PrivateGridView
            // 
            this.PrivateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrivateGridView.Location = new System.Drawing.Point(30, 51);
            this.PrivateGridView.Name = "PrivateGridView";
            this.PrivateGridView.RowHeadersWidth = 51;
            this.PrivateGridView.RowTemplate.Height = 24;
            this.PrivateGridView.Size = new System.Drawing.Size(482, 362);
            this.PrivateGridView.TabIndex = 0;
            // 
            // PrivateSessions
            // 
            this.PrivateSessions.AutoSize = true;
            this.PrivateSessions.Location = new System.Drawing.Point(205, 19);
            this.PrivateSessions.Name = "PrivateSessions";
            this.PrivateSessions.Size = new System.Drawing.Size(109, 17);
            this.PrivateSessions.TabIndex = 1;
            this.PrivateSessions.Text = "PrivateSessions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Workouts";
            // 
            // AllWorkoutsGrid
            // 
            this.AllWorkoutsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWorkoutsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllWorkoutsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllWorkoutsGrid.Location = new System.Drawing.Point(539, 51);
            this.AllWorkoutsGrid.Name = "AllWorkoutsGrid";
            this.AllWorkoutsGrid.RowHeadersWidth = 51;
            this.AllWorkoutsGrid.RowTemplate.Height = 24;
            this.AllWorkoutsGrid.Size = new System.Drawing.Size(482, 362);
            this.AllWorkoutsGrid.TabIndex = 3;
            // 
            // WorkoutComboBox
            // 
            this.WorkoutComboBox.FormattingEnabled = true;
            this.WorkoutComboBox.Location = new System.Drawing.Point(672, 16);
            this.WorkoutComboBox.Name = "WorkoutComboBox";
            this.WorkoutComboBox.Size = new System.Drawing.Size(349, 24);
            this.WorkoutComboBox.TabIndex = 4;
            this.WorkoutComboBox.Text = "Pick Workout";
            this.WorkoutComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClientWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1054, 467);
            this.Controls.Add(this.ClientAchievmentsGroupBox);
            this.Name = "ClientWorkouts";
            this.Text = "ClientWorkouts";
            this.Load += new System.EventHandler(this.ClientWorkouts_Load);
            this.ClientAchievmentsGroupBox.ResumeLayout(false);
            this.ClientAchievmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllWorkoutsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientAchievmentsGroupBox;
        private System.Windows.Forms.Label PrivateSessions;
        private System.Windows.Forms.DataGridView PrivateGridView;
        private System.Windows.Forms.ComboBox WorkoutComboBox;
        private System.Windows.Forms.DataGridView AllWorkoutsGrid;
        private System.Windows.Forms.Label label1;
    }
}