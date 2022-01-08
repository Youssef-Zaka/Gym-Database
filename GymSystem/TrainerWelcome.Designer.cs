
namespace GymSystem
{
	partial class TrainerWelcome
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
			this.btnShowClientList = new System.Windows.Forms.Button();
			this.btnTrainerProfile = new System.Windows.Forms.Button();
			this.btnTrainerCourses = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShowClientList
			// 
			this.btnShowClientList.Location = new System.Drawing.Point(33, 143);
			this.btnShowClientList.Name = "btnShowClientList";
			this.btnShowClientList.Size = new System.Drawing.Size(96, 56);
			this.btnShowClientList.TabIndex = 0;
			this.btnShowClientList.Text = "My Clients";
			this.btnShowClientList.UseVisualStyleBackColor = true;
			this.btnShowClientList.Click += new System.EventHandler(this.btnShowClientList_Click);
			// 
			// btnTrainerProfile
			// 
			this.btnTrainerProfile.Location = new System.Drawing.Point(189, 143);
			this.btnTrainerProfile.Name = "btnTrainerProfile";
			this.btnTrainerProfile.Size = new System.Drawing.Size(96, 56);
			this.btnTrainerProfile.TabIndex = 1;
			this.btnTrainerProfile.Text = "My Profile";
			this.btnTrainerProfile.UseVisualStyleBackColor = true;
			this.btnTrainerProfile.Click += new System.EventHandler(this.btnTrainerProfile_Click);
			// 
			// btnTrainerCourses
			// 
			this.btnTrainerCourses.Location = new System.Drawing.Point(352, 143);
			this.btnTrainerCourses.Name = "btnTrainerCourses";
			this.btnTrainerCourses.Size = new System.Drawing.Size(96, 56);
			this.btnTrainerCourses.TabIndex = 2;
			this.btnTrainerCourses.Text = "My Courses";
			this.btnTrainerCourses.UseVisualStyleBackColor = true;
			// 
			// TrainerWelcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTrainerCourses);
			this.Controls.Add(this.btnTrainerProfile);
			this.Controls.Add(this.btnShowClientList);
			this.Name = "TrainerWelcome";
			this.Text = "TrainerWelcome";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShowClientList;
		private System.Windows.Forms.Button btnTrainerProfile;
		private System.Windows.Forms.Button btnTrainerCourses;
	}
}