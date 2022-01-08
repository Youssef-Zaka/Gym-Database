
namespace GymSystem
{
	partial class CourseLinks
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
			this.labelTitleFixed = new System.Windows.Forms.Label();
			this.comboTrainerCourses = new System.Windows.Forms.ComboBox();
			this.btnTrainerCourses = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelTitleFixed
			// 
			this.labelTitleFixed.AutoSize = true;
			this.labelTitleFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitleFixed.Location = new System.Drawing.Point(136, 9);
			this.labelTitleFixed.Name = "labelTitleFixed";
			this.labelTitleFixed.Size = new System.Drawing.Size(499, 73);
			this.labelTitleFixed.TabIndex = 1;
			this.labelTitleFixed.Text = "Courses for you";
			// 
			// comboTrainerCourses
			// 
			this.comboTrainerCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTrainerCourses.FormattingEnabled = true;
			this.comboTrainerCourses.Location = new System.Drawing.Point(221, 177);
			this.comboTrainerCourses.Name = "comboTrainerCourses";
			this.comboTrainerCourses.Size = new System.Drawing.Size(224, 21);
			this.comboTrainerCourses.TabIndex = 2;
			// 
			// btnTrainerCourses
			// 
			this.btnTrainerCourses.Location = new System.Drawing.Point(451, 177);
			this.btnTrainerCourses.Name = "btnTrainerCourses";
			this.btnTrainerCourses.Size = new System.Drawing.Size(75, 23);
			this.btnTrainerCourses.TabIndex = 3;
			this.btnTrainerCourses.Text = "Go";
			this.btnTrainerCourses.UseVisualStyleBackColor = true;
			this.btnTrainerCourses.Click += new System.EventHandler(this.btnTrainerCourses_Click);
			// 
			// CourseLinks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTrainerCourses);
			this.Controls.Add(this.comboTrainerCourses);
			this.Controls.Add(this.labelTitleFixed);
			this.Name = "CourseLinks";
			this.Text = "CourseLinks";
			this.Load += new System.EventHandler(this.CourseLinks_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelTitleFixed;
		private System.Windows.Forms.ComboBox comboTrainerCourses;
		private System.Windows.Forms.Button btnTrainerCourses;
	}
}