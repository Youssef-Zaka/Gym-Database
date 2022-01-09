
namespace GymSystem
{
	partial class TrainerClientInfo
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
			this.tabClientInfo = new System.Windows.Forms.TabControl();
			this.tabClientMeasure = new System.Windows.Forms.TabPage();
			this.tabClientProfile = new System.Windows.Forms.TabPage();
			this.labelClientPhoneFixed = new System.Windows.Forms.Label();
			this.labelClientStartDateFixed = new System.Windows.Forms.Label();
			this.labelClientPhone = new System.Windows.Forms.Label();
			this.labelClientAddress = new System.Windows.Forms.Label();
			this.labelClientNameFixed = new System.Windows.Forms.Label();
			this.labelClientAddressFixed = new System.Windows.Forms.Label();
			this.labelClientID = new System.Windows.Forms.Label();
			this.labelClientBDate = new System.Windows.Forms.Label();
			this.labelClientName = new System.Windows.Forms.Label();
			this.labelClientBDateFixed = new System.Windows.Forms.Label();
			this.labelClientStartDate = new System.Windows.Forms.Label();
			this.gridClientMeasurement = new System.Windows.Forms.DataGridView();
			this.btnRecommededWeight = new System.Windows.Forms.Button();
			this.recommendedWeightTrackBar = new System.Windows.Forms.TrackBar();
			this.WeightLabel = new System.Windows.Forms.Label();
			this.labelRecWeight = new System.Windows.Forms.Label();
			this.comboAchievments = new System.Windows.Forms.ComboBox();
			this.btnAddAchievment = new System.Windows.Forms.Button();
			this.labelAchievedFixed = new System.Windows.Forms.Label();
			this.labelWorkoutFixed = new System.Windows.Forms.Label();
			this.labelWorkout = new System.Windows.Forms.Label();
			this.workoutFixed = new System.Windows.Forms.Label();
			this.btnEditWorkout = new System.Windows.Forms.Button();
			this.comboEditWorkout = new System.Windows.Forms.ComboBox();
			this.btnDeleteAch = new System.Windows.Forms.Button();
			this.comboDeleteAch = new System.Windows.Forms.ComboBox();
			this.tabClientInfo.SuspendLayout();
			this.tabClientMeasure.SuspendLayout();
			this.tabClientProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClientMeasurement)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recommendedWeightTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// tabClientInfo
			// 
			this.tabClientInfo.Controls.Add(this.tabClientProfile);
			this.tabClientInfo.Controls.Add(this.tabClientMeasure);
			this.tabClientInfo.Location = new System.Drawing.Point(12, 12);
			this.tabClientInfo.Name = "tabClientInfo";
			this.tabClientInfo.SelectedIndex = 0;
			this.tabClientInfo.Size = new System.Drawing.Size(776, 436);
			this.tabClientInfo.TabIndex = 14;
			// 
			// tabClientMeasure
			// 
			this.tabClientMeasure.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tabClientMeasure.Controls.Add(this.labelRecWeight);
			this.tabClientMeasure.Controls.Add(this.recommendedWeightTrackBar);
			this.tabClientMeasure.Controls.Add(this.WeightLabel);
			this.tabClientMeasure.Controls.Add(this.btnRecommededWeight);
			this.tabClientMeasure.Controls.Add(this.gridClientMeasurement);
			this.tabClientMeasure.Location = new System.Drawing.Point(4, 22);
			this.tabClientMeasure.Name = "tabClientMeasure";
			this.tabClientMeasure.Padding = new System.Windows.Forms.Padding(3);
			this.tabClientMeasure.Size = new System.Drawing.Size(768, 410);
			this.tabClientMeasure.TabIndex = 1;
			this.tabClientMeasure.Text = "Client Measurements";
			// 
			// tabClientProfile
			// 
			this.tabClientProfile.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tabClientProfile.Controls.Add(this.comboDeleteAch);
			this.tabClientProfile.Controls.Add(this.btnDeleteAch);
			this.tabClientProfile.Controls.Add(this.workoutFixed);
			this.tabClientProfile.Controls.Add(this.btnEditWorkout);
			this.tabClientProfile.Controls.Add(this.comboEditWorkout);
			this.tabClientProfile.Controls.Add(this.labelWorkout);
			this.tabClientProfile.Controls.Add(this.labelWorkoutFixed);
			this.tabClientProfile.Controls.Add(this.labelAchievedFixed);
			this.tabClientProfile.Controls.Add(this.btnAddAchievment);
			this.tabClientProfile.Controls.Add(this.comboAchievments);
			this.tabClientProfile.Controls.Add(this.labelClientStartDate);
			this.tabClientProfile.Controls.Add(this.labelClientBDateFixed);
			this.tabClientProfile.Controls.Add(this.labelClientName);
			this.tabClientProfile.Controls.Add(this.labelClientBDate);
			this.tabClientProfile.Controls.Add(this.labelClientID);
			this.tabClientProfile.Controls.Add(this.labelClientAddressFixed);
			this.tabClientProfile.Controls.Add(this.labelClientNameFixed);
			this.tabClientProfile.Controls.Add(this.labelClientAddress);
			this.tabClientProfile.Controls.Add(this.labelClientPhone);
			this.tabClientProfile.Controls.Add(this.labelClientStartDateFixed);
			this.tabClientProfile.Controls.Add(this.labelClientPhoneFixed);
			this.tabClientProfile.Location = new System.Drawing.Point(4, 22);
			this.tabClientProfile.Name = "tabClientProfile";
			this.tabClientProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tabClientProfile.Size = new System.Drawing.Size(768, 410);
			this.tabClientProfile.TabIndex = 0;
			this.tabClientProfile.Text = "Client Profile";
			// 
			// labelClientPhoneFixed
			// 
			this.labelClientPhoneFixed.AutoSize = true;
			this.labelClientPhoneFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientPhoneFixed.Location = new System.Drawing.Point(27, 158);
			this.labelClientPhoneFixed.Name = "labelClientPhoneFixed";
			this.labelClientPhoneFixed.Size = new System.Drawing.Size(119, 20);
			this.labelClientPhoneFixed.TabIndex = 5;
			this.labelClientPhoneFixed.Text = "Phone Number:";
			// 
			// labelClientStartDateFixed
			// 
			this.labelClientStartDateFixed.AutoSize = true;
			this.labelClientStartDateFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientStartDateFixed.Location = new System.Drawing.Point(27, 278);
			this.labelClientStartDateFixed.Name = "labelClientStartDateFixed";
			this.labelClientStartDateFixed.Size = new System.Drawing.Size(87, 20);
			this.labelClientStartDateFixed.TabIndex = 7;
			this.labelClientStartDateFixed.Text = "Start Date:";
			// 
			// labelClientPhone
			// 
			this.labelClientPhone.AutoSize = true;
			this.labelClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientPhone.Location = new System.Drawing.Point(166, 158);
			this.labelClientPhone.Name = "labelClientPhone";
			this.labelClientPhone.Size = new System.Drawing.Size(51, 18);
			this.labelClientPhone.TabIndex = 4;
			this.labelClientPhone.Text = "Phone";
			// 
			// labelClientAddress
			// 
			this.labelClientAddress.AutoSize = true;
			this.labelClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientAddress.Location = new System.Drawing.Point(166, 195);
			this.labelClientAddress.Name = "labelClientAddress";
			this.labelClientAddress.Size = new System.Drawing.Size(62, 18);
			this.labelClientAddress.TabIndex = 8;
			this.labelClientAddress.Text = "Address";
			// 
			// labelClientNameFixed
			// 
			this.labelClientNameFixed.AutoSize = true;
			this.labelClientNameFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientNameFixed.Location = new System.Drawing.Point(27, 122);
			this.labelClientNameFixed.Name = "labelClientNameFixed";
			this.labelClientNameFixed.Size = new System.Drawing.Size(26, 20);
			this.labelClientNameFixed.TabIndex = 3;
			this.labelClientNameFixed.Text = "ID";
			// 
			// labelClientAddressFixed
			// 
			this.labelClientAddressFixed.AutoSize = true;
			this.labelClientAddressFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientAddressFixed.Location = new System.Drawing.Point(27, 195);
			this.labelClientAddressFixed.Name = "labelClientAddressFixed";
			this.labelClientAddressFixed.Size = new System.Drawing.Size(72, 20);
			this.labelClientAddressFixed.TabIndex = 9;
			this.labelClientAddressFixed.Text = "Address:";
			// 
			// labelClientID
			// 
			this.labelClientID.AutoSize = true;
			this.labelClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientID.Location = new System.Drawing.Point(166, 122);
			this.labelClientID.Name = "labelClientID";
			this.labelClientID.Size = new System.Drawing.Size(22, 18);
			this.labelClientID.TabIndex = 2;
			this.labelClientID.Text = "ID";
			// 
			// labelClientBDate
			// 
			this.labelClientBDate.AutoSize = true;
			this.labelClientBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientBDate.Location = new System.Drawing.Point(166, 235);
			this.labelClientBDate.Name = "labelClientBDate";
			this.labelClientBDate.Size = new System.Drawing.Size(73, 18);
			this.labelClientBDate.TabIndex = 12;
			this.labelClientBDate.Text = "Birth Date";
			// 
			// labelClientName
			// 
			this.labelClientName.AutoSize = true;
			this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientName.Location = new System.Drawing.Point(25, 25);
			this.labelClientName.Name = "labelClientName";
			this.labelClientName.Size = new System.Drawing.Size(78, 29);
			this.labelClientName.TabIndex = 0;
			this.labelClientName.Text = "Name";
			// 
			// labelClientBDateFixed
			// 
			this.labelClientBDateFixed.AutoSize = true;
			this.labelClientBDateFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientBDateFixed.Location = new System.Drawing.Point(27, 235);
			this.labelClientBDateFixed.Name = "labelClientBDateFixed";
			this.labelClientBDateFixed.Size = new System.Drawing.Size(85, 20);
			this.labelClientBDateFixed.TabIndex = 13;
			this.labelClientBDateFixed.Text = "Birth Date:";
			// 
			// labelClientStartDate
			// 
			this.labelClientStartDate.AutoSize = true;
			this.labelClientStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClientStartDate.Location = new System.Drawing.Point(166, 278);
			this.labelClientStartDate.Name = "labelClientStartDate";
			this.labelClientStartDate.Size = new System.Drawing.Size(74, 18);
			this.labelClientStartDate.TabIndex = 6;
			this.labelClientStartDate.Text = "Start Date";
			// 
			// gridClientMeasurement
			// 
			this.gridClientMeasurement.AllowUserToAddRows = false;
			this.gridClientMeasurement.AllowUserToDeleteRows = false;
			this.gridClientMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridClientMeasurement.Location = new System.Drawing.Point(33, 33);
			this.gridClientMeasurement.Name = "gridClientMeasurement";
			this.gridClientMeasurement.ReadOnly = true;
			this.gridClientMeasurement.Size = new System.Drawing.Size(687, 164);
			this.gridClientMeasurement.TabIndex = 0;
			// 
			// btnRecommededWeight
			// 
			this.btnRecommededWeight.Location = new System.Drawing.Point(621, 233);
			this.btnRecommededWeight.Name = "btnRecommededWeight";
			this.btnRecommededWeight.Size = new System.Drawing.Size(99, 45);
			this.btnRecommededWeight.TabIndex = 1;
			this.btnRecommededWeight.Text = "Recommend";
			this.btnRecommededWeight.UseVisualStyleBackColor = true;
			this.btnRecommededWeight.Click += new System.EventHandler(this.btnRecommededWeight_Click);
			// 
			// recommendedWeightTrackBar
			// 
			this.recommendedWeightTrackBar.BackColor = System.Drawing.SystemColors.Info;
			this.recommendedWeightTrackBar.Location = new System.Drawing.Point(33, 233);
			this.recommendedWeightTrackBar.Maximum = 150;
			this.recommendedWeightTrackBar.Minimum = 30;
			this.recommendedWeightTrackBar.Name = "recommendedWeightTrackBar";
			this.recommendedWeightTrackBar.Size = new System.Drawing.Size(582, 45);
			this.recommendedWeightTrackBar.TabIndex = 7;
			this.recommendedWeightTrackBar.Value = 30;
			this.recommendedWeightTrackBar.Scroll += new System.EventHandler(this.recommendedWeightTrackBar_Scroll);
			// 
			// WeightLabel
			// 
			this.WeightLabel.AutoSize = true;
			this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeightLabel.Location = new System.Drawing.Point(29, 210);
			this.WeightLabel.Name = "WeightLabel";
			this.WeightLabel.Size = new System.Drawing.Size(172, 20);
			this.WeightLabel.TabIndex = 6;
			this.WeightLabel.Text = "Recommended Weight";
			// 
			// labelRecWeight
			// 
			this.labelRecWeight.AutoSize = true;
			this.labelRecWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRecWeight.Location = new System.Drawing.Point(236, 210);
			this.labelRecWeight.Name = "labelRecWeight";
			this.labelRecWeight.Size = new System.Drawing.Size(59, 20);
			this.labelRecWeight.TabIndex = 16;
			this.labelRecWeight.Text = "Weight";
			// 
			// comboAchievments
			// 
			this.comboAchievments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAchievments.FormattingEnabled = true;
			this.comboAchievments.Location = new System.Drawing.Point(437, 253);
			this.comboAchievments.Name = "comboAchievments";
			this.comboAchievments.Size = new System.Drawing.Size(194, 21);
			this.comboAchievments.TabIndex = 14;
			// 
			// btnAddAchievment
			// 
			this.btnAddAchievment.Location = new System.Drawing.Point(637, 253);
			this.btnAddAchievment.Name = "btnAddAchievment";
			this.btnAddAchievment.Size = new System.Drawing.Size(75, 23);
			this.btnAddAchievment.TabIndex = 15;
			this.btnAddAchievment.Text = "Add";
			this.btnAddAchievment.UseVisualStyleBackColor = true;
			this.btnAddAchievment.Click += new System.EventHandler(this.btnAddAchievment_Click);
			// 
			// labelAchievedFixed
			// 
			this.labelAchievedFixed.AutoSize = true;
			this.labelAchievedFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAchievedFixed.Location = new System.Drawing.Point(433, 212);
			this.labelAchievedFixed.Name = "labelAchievedFixed";
			this.labelAchievedFixed.Size = new System.Drawing.Size(100, 20);
			this.labelAchievedFixed.TabIndex = 16;
			this.labelAchievedFixed.Text = "Achievments";
			// 
			// labelWorkoutFixed
			// 
			this.labelWorkoutFixed.AutoSize = true;
			this.labelWorkoutFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWorkoutFixed.Location = new System.Drawing.Point(26, 335);
			this.labelWorkoutFixed.Name = "labelWorkoutFixed";
			this.labelWorkoutFixed.Size = new System.Drawing.Size(69, 20);
			this.labelWorkoutFixed.TabIndex = 17;
			this.labelWorkoutFixed.Text = "Workout";
			// 
			// labelWorkout
			// 
			this.labelWorkout.AutoSize = true;
			this.labelWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWorkout.Location = new System.Drawing.Point(166, 337);
			this.labelWorkout.Name = "labelWorkout";
			this.labelWorkout.Size = new System.Drawing.Size(66, 18);
			this.labelWorkout.TabIndex = 18;
			this.labelWorkout.Text = "Workout";
			// 
			// workoutFixed
			// 
			this.workoutFixed.AutoSize = true;
			this.workoutFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.workoutFixed.Location = new System.Drawing.Point(433, 94);
			this.workoutFixed.Name = "workoutFixed";
			this.workoutFixed.Size = new System.Drawing.Size(69, 20);
			this.workoutFixed.TabIndex = 21;
			this.workoutFixed.Text = "Workout";
			// 
			// btnEditWorkout
			// 
			this.btnEditWorkout.Location = new System.Drawing.Point(637, 117);
			this.btnEditWorkout.Name = "btnEditWorkout";
			this.btnEditWorkout.Size = new System.Drawing.Size(75, 23);
			this.btnEditWorkout.TabIndex = 20;
			this.btnEditWorkout.Text = "Edit";
			this.btnEditWorkout.UseVisualStyleBackColor = true;
			this.btnEditWorkout.Click += new System.EventHandler(this.btnEditWorkout_Click);
			// 
			// comboEditWorkout
			// 
			this.comboEditWorkout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEditWorkout.FormattingEnabled = true;
			this.comboEditWorkout.Location = new System.Drawing.Point(437, 117);
			this.comboEditWorkout.Name = "comboEditWorkout";
			this.comboEditWorkout.Size = new System.Drawing.Size(194, 21);
			this.comboEditWorkout.TabIndex = 19;
			// 
			// btnDeleteAch
			// 
			this.btnDeleteAch.Location = new System.Drawing.Point(637, 298);
			this.btnDeleteAch.Name = "btnDeleteAch";
			this.btnDeleteAch.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteAch.TabIndex = 22;
			this.btnDeleteAch.Text = "Remove";
			this.btnDeleteAch.UseVisualStyleBackColor = true;
			this.btnDeleteAch.Click += new System.EventHandler(this.btnDeleteAch_Click);
			// 
			// comboDeleteAch
			// 
			this.comboDeleteAch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDeleteAch.FormattingEnabled = true;
			this.comboDeleteAch.Location = new System.Drawing.Point(437, 300);
			this.comboDeleteAch.Name = "comboDeleteAch";
			this.comboDeleteAch.Size = new System.Drawing.Size(194, 21);
			this.comboDeleteAch.TabIndex = 23;
			// 
			// TrainerClientInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabClientInfo);
			this.Name = "TrainerClientInfo";
			this.Text = "TrainerClientInfo";
			this.Load += new System.EventHandler(this.TrainerClientInfo_Load);
			this.tabClientInfo.ResumeLayout(false);
			this.tabClientMeasure.ResumeLayout(false);
			this.tabClientMeasure.PerformLayout();
			this.tabClientProfile.ResumeLayout(false);
			this.tabClientProfile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClientMeasurement)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recommendedWeightTrackBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabClientInfo;
		private System.Windows.Forms.TabPage tabClientProfile;
		private System.Windows.Forms.Label labelClientStartDate;
		private System.Windows.Forms.Label labelClientBDateFixed;
		private System.Windows.Forms.Label labelClientName;
		private System.Windows.Forms.Label labelClientBDate;
		private System.Windows.Forms.Label labelClientID;
		private System.Windows.Forms.Label labelClientAddressFixed;
		private System.Windows.Forms.Label labelClientNameFixed;
		private System.Windows.Forms.Label labelClientAddress;
		private System.Windows.Forms.Label labelClientPhone;
		private System.Windows.Forms.Label labelClientStartDateFixed;
		private System.Windows.Forms.Label labelClientPhoneFixed;
		private System.Windows.Forms.TabPage tabClientMeasure;
		private System.Windows.Forms.DataGridView gridClientMeasurement;
		private System.Windows.Forms.Button btnRecommededWeight;
		private System.Windows.Forms.TrackBar recommendedWeightTrackBar;
		private System.Windows.Forms.Label WeightLabel;
		private System.Windows.Forms.Label labelRecWeight;
		private System.Windows.Forms.Label labelAchievedFixed;
		private System.Windows.Forms.Button btnAddAchievment;
		private System.Windows.Forms.ComboBox comboAchievments;
		private System.Windows.Forms.Label labelWorkout;
		private System.Windows.Forms.Label labelWorkoutFixed;
		private System.Windows.Forms.Label workoutFixed;
		private System.Windows.Forms.Button btnEditWorkout;
		private System.Windows.Forms.ComboBox comboEditWorkout;
		private System.Windows.Forms.ComboBox comboDeleteAch;
		private System.Windows.Forms.Button btnDeleteAch;
	}
}