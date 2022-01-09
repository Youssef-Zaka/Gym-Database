
namespace GymSystem
{
	partial class TrainerSchedule
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
			this.gridTrainerSchedule = new System.Windows.Forms.DataGridView();
			this.labelTitleSchedule = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridTrainerSchedule)).BeginInit();
			this.SuspendLayout();
			// 
			// gridTrainerSchedule
			// 
			this.gridTrainerSchedule.AllowUserToAddRows = false;
			this.gridTrainerSchedule.AllowUserToDeleteRows = false;
			this.gridTrainerSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTrainerSchedule.Location = new System.Drawing.Point(12, 107);
			this.gridTrainerSchedule.Name = "gridTrainerSchedule";
			this.gridTrainerSchedule.ReadOnly = true;
			this.gridTrainerSchedule.Size = new System.Drawing.Size(776, 331);
			this.gridTrainerSchedule.TabIndex = 0;
			// 
			// labelTitleSchedule
			// 
			this.labelTitleSchedule.AutoSize = true;
			this.labelTitleSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitleSchedule.Location = new System.Drawing.Point(286, 40);
			this.labelTitleSchedule.Name = "labelTitleSchedule";
			this.labelTitleSchedule.Size = new System.Drawing.Size(235, 42);
			this.labelTitleSchedule.TabIndex = 1;
			this.labelTitleSchedule.Text = "My Schedule";
			// 
			// TrainerSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelTitleSchedule);
			this.Controls.Add(this.gridTrainerSchedule);
			this.Name = "TrainerSchedule";
			this.Text = "TrainerSchedule";
			this.Load += new System.EventHandler(this.TrainerSchedule_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridTrainerSchedule)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridTrainerSchedule;
		private System.Windows.Forms.Label labelTitleSchedule;
	}
}