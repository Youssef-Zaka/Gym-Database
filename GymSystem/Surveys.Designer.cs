
namespace GymSystem
{
    partial class Surveys
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
            this.trainerdate = new System.Windows.Forms.Label();
            this.facilityrating = new System.Windows.Forms.Label();
            this.machinesrating = new System.Windows.Forms.Label();
            this.receptionistrating = new System.Windows.Forms.Label();
            this.TrainerRatingcombo = new System.Windows.Forms.ComboBox();
            this.FacilityRatingcombo = new System.Windows.Forms.ComboBox();
            this.MachinesRatingcombo = new System.Windows.Forms.ComboBox();
            this.ReceptionistRatingcombo = new System.Windows.Forms.ComboBox();
            this.AddSurveybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainerdate
            // 
            this.trainerdate.AutoSize = true;
            this.trainerdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.trainerdate.Location = new System.Drawing.Point(12, 36);
            this.trainerdate.Name = "trainerdate";
            this.trainerdate.Size = new System.Drawing.Size(109, 20);
            this.trainerdate.TabIndex = 1;
            this.trainerdate.Text = "Trainer Rating";
            // 
            // facilityrating
            // 
            this.facilityrating.AutoSize = true;
            this.facilityrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.facilityrating.Location = new System.Drawing.Point(13, 93);
            this.facilityrating.Name = "facilityrating";
            this.facilityrating.Size = new System.Drawing.Size(108, 20);
            this.facilityrating.TabIndex = 2;
            this.facilityrating.Text = "Facility Rating";
            // 
            // machinesrating
            // 
            this.machinesrating.AutoSize = true;
            this.machinesrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.machinesrating.Location = new System.Drawing.Point(13, 158);
            this.machinesrating.Name = "machinesrating";
            this.machinesrating.Size = new System.Drawing.Size(128, 20);
            this.machinesrating.TabIndex = 3;
            this.machinesrating.Text = "Machines Rating";
            // 
            // receptionistrating
            // 
            this.receptionistrating.AutoSize = true;
            this.receptionistrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.receptionistrating.Location = new System.Drawing.Point(13, 226);
            this.receptionistrating.Name = "receptionistrating";
            this.receptionistrating.Size = new System.Drawing.Size(149, 20);
            this.receptionistrating.TabIndex = 4;
            this.receptionistrating.Text = "Receptionist Rating";
            // 
            // TrainerRatingcombo
            // 
            this.TrainerRatingcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrainerRatingcombo.FormattingEnabled = true;
            this.TrainerRatingcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.TrainerRatingcombo.Location = new System.Drawing.Point(263, 38);
            this.TrainerRatingcombo.Name = "TrainerRatingcombo";
            this.TrainerRatingcombo.Size = new System.Drawing.Size(121, 21);
            this.TrainerRatingcombo.TabIndex = 6;
            // 
            // FacilityRatingcombo
            // 
            this.FacilityRatingcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityRatingcombo.FormattingEnabled = true;
            this.FacilityRatingcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.FacilityRatingcombo.Location = new System.Drawing.Point(263, 95);
            this.FacilityRatingcombo.Name = "FacilityRatingcombo";
            this.FacilityRatingcombo.Size = new System.Drawing.Size(121, 21);
            this.FacilityRatingcombo.TabIndex = 7;
            // 
            // MachinesRatingcombo
            // 
            this.MachinesRatingcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachinesRatingcombo.FormattingEnabled = true;
            this.MachinesRatingcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.MachinesRatingcombo.Location = new System.Drawing.Point(263, 160);
            this.MachinesRatingcombo.Name = "MachinesRatingcombo";
            this.MachinesRatingcombo.Size = new System.Drawing.Size(121, 21);
            this.MachinesRatingcombo.TabIndex = 8;
            // 
            // ReceptionistRatingcombo
            // 
            this.ReceptionistRatingcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReceptionistRatingcombo.FormattingEnabled = true;
            this.ReceptionistRatingcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ReceptionistRatingcombo.Location = new System.Drawing.Point(263, 228);
            this.ReceptionistRatingcombo.Name = "ReceptionistRatingcombo";
            this.ReceptionistRatingcombo.Size = new System.Drawing.Size(121, 21);
            this.ReceptionistRatingcombo.TabIndex = 9;
            // 
            // AddSurveybutton
            // 
            this.AddSurveybutton.Location = new System.Drawing.Point(134, 347);
            this.AddSurveybutton.Name = "AddSurveybutton";
            this.AddSurveybutton.Size = new System.Drawing.Size(156, 36);
            this.AddSurveybutton.TabIndex = 10;
            this.AddSurveybutton.Text = "Add Survey";
            this.AddSurveybutton.UseVisualStyleBackColor = true;
            this.AddSurveybutton.Click += new System.EventHandler(this.AddSurveybutton_Click);
            // 
            // Surveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSurveybutton);
            this.Controls.Add(this.ReceptionistRatingcombo);
            this.Controls.Add(this.MachinesRatingcombo);
            this.Controls.Add(this.FacilityRatingcombo);
            this.Controls.Add(this.TrainerRatingcombo);
            this.Controls.Add(this.receptionistrating);
            this.Controls.Add(this.machinesrating);
            this.Controls.Add(this.facilityrating);
            this.Controls.Add(this.trainerdate);
            this.Name = "Surveys";
            this.Text = "Surveys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label trainerdate;
        private System.Windows.Forms.Label facilityrating;
        private System.Windows.Forms.Label machinesrating;
        private System.Windows.Forms.Label receptionistrating;
        private System.Windows.Forms.ComboBox TrainerRatingcombo;
        private System.Windows.Forms.ComboBox FacilityRatingcombo;
        private System.Windows.Forms.ComboBox MachinesRatingcombo;
        private System.Windows.Forms.ComboBox ReceptionistRatingcombo;
        private System.Windows.Forms.Button AddSurveybutton;
    }
}