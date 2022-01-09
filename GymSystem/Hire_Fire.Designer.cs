
namespace GymSystem
{
    partial class Hire_Fire
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
            this.HireTrainer = new System.Windows.Forms.Button();
            this.trainerssn = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rfname = new System.Windows.Forms.TextBox();
            this.rlname = new System.Windows.Forms.TextBox();
            this.rphone = new System.Windows.Forms.TextBox();
            this.rlink = new System.Windows.Forms.TextBox();
            this.rsalary = new System.Windows.Forms.TextBox();
            this.raddress = new System.Windows.Forms.TextBox();
            this.rssn = new System.Windows.Forms.TextBox();
            this.HireReceptionist = new System.Windows.Forms.Button();
            this.Firebox = new System.Windows.Forms.GroupBox();
            this.receptioncombo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.trainercombo = new System.Windows.Forms.ComboBox();
            this.firereceptionist = new System.Windows.Forms.Button();
            this.firetrainer = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.trainerdate = new System.Windows.Forms.DateTimePicker();
            this.receptiondate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.shift = new System.Windows.Forms.ComboBox();
            this.rsexcombo = new System.Windows.Forms.ComboBox();
            this.tsexcombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.Firebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HireTrainer
            // 
            this.HireTrainer.Location = new System.Drawing.Point(331, 189);
            this.HireTrainer.Name = "HireTrainer";
            this.HireTrainer.Size = new System.Drawing.Size(114, 37);
            this.HireTrainer.TabIndex = 0;
            this.HireTrainer.Text = "Hire-Trainer";
            this.HireTrainer.UseVisualStyleBackColor = true;
            this.HireTrainer.Click += new System.EventHandler(this.HireTrainer_Click);
            // 
            // trainerssn
            // 
            this.trainerssn.Location = new System.Drawing.Point(22, 56);
            this.trainerssn.MaxLength = 14;
            this.trainerssn.Name = "trainerssn";
            this.trainerssn.Size = new System.Drawing.Size(100, 22);
            this.trainerssn.TabIndex = 1;
            this.trainerssn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trainerssn_KeyPress);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(540, 136);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 22);
            this.description.TabIndex = 2;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(424, 136);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 22);
            this.address.TabIndex = 3;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(299, 136);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 22);
            this.salary.TabIndex = 4;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(172, 136);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(100, 22);
            this.link.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(48, 136);
            this.phone.MaxLength = 11;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 22);
            this.phone.TabIndex = 6;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(283, 56);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 22);
            this.lname.TabIndex = 9;
            this.lname.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_KeyPress);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(156, 56);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 22);
            this.fname.TabIndex = 10;
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "TrainerSSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Link";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Salary";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Link";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(459, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Bdate";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(328, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Lname";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(202, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "Fname";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "ReceptionSSN";
            // 
            // rfname
            // 
            this.rfname.Location = new System.Drawing.Point(172, 298);
            this.rfname.Name = "rfname";
            this.rfname.Size = new System.Drawing.Size(100, 22);
            this.rfname.TabIndex = 30;
            this.rfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rfname_KeyPress);
            // 
            // rlname
            // 
            this.rlname.Location = new System.Drawing.Point(299, 298);
            this.rlname.Name = "rlname";
            this.rlname.Size = new System.Drawing.Size(100, 22);
            this.rlname.TabIndex = 29;
            this.rlname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rlname_KeyPress);
            // 
            // rphone
            // 
            this.rphone.Location = new System.Drawing.Point(38, 391);
            this.rphone.MaxLength = 11;
            this.rphone.Name = "rphone";
            this.rphone.Size = new System.Drawing.Size(100, 22);
            this.rphone.TabIndex = 26;
            this.rphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rphone_KeyPress);
            // 
            // rlink
            // 
            this.rlink.Location = new System.Drawing.Point(172, 391);
            this.rlink.Name = "rlink";
            this.rlink.Size = new System.Drawing.Size(100, 22);
            this.rlink.TabIndex = 25;
            // 
            // rsalary
            // 
            this.rsalary.Location = new System.Drawing.Point(299, 391);
            this.rsalary.Name = "rsalary";
            this.rsalary.Size = new System.Drawing.Size(100, 22);
            this.rsalary.TabIndex = 24;
            this.rsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rsalary_KeyPress);
            // 
            // raddress
            // 
            this.raddress.Location = new System.Drawing.Point(424, 391);
            this.raddress.Name = "raddress";
            this.raddress.Size = new System.Drawing.Size(100, 22);
            this.raddress.TabIndex = 23;
            // 
            // rssn
            // 
            this.rssn.Location = new System.Drawing.Point(38, 298);
            this.rssn.MaxLength = 14;
            this.rssn.Name = "rssn";
            this.rssn.Size = new System.Drawing.Size(100, 22);
            this.rssn.TabIndex = 21;
            this.rssn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rssn_KeyPress);
            // 
            // HireReceptionist
            // 
            this.HireReceptionist.Location = new System.Drawing.Point(331, 436);
            this.HireReceptionist.Name = "HireReceptionist";
            this.HireReceptionist.Size = new System.Drawing.Size(138, 37);
            this.HireReceptionist.TabIndex = 41;
            this.HireReceptionist.Text = "Hire-Receptionist";
            this.HireReceptionist.UseVisualStyleBackColor = true;
            this.HireReceptionist.Click += new System.EventHandler(this.HireReceptionist_Click);
            // 
            // Firebox
            // 
            this.Firebox.Controls.Add(this.receptioncombo);
            this.Firebox.Controls.Add(this.label21);
            this.Firebox.Controls.Add(this.trainercombo);
            this.Firebox.Controls.Add(this.firereceptionist);
            this.Firebox.Controls.Add(this.firetrainer);
            this.Firebox.Controls.Add(this.label22);
            this.Firebox.Location = new System.Drawing.Point(801, 27);
            this.Firebox.Name = "Firebox";
            this.Firebox.Size = new System.Drawing.Size(577, 413);
            this.Firebox.TabIndex = 42;
            this.Firebox.TabStop = false;
            this.Firebox.Text = "Fire-box";
            // 
            // receptioncombo
            // 
            this.receptioncombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receptioncombo.FormattingEnabled = true;
            this.receptioncombo.Location = new System.Drawing.Point(190, 276);
            this.receptioncombo.Name = "receptioncombo";
            this.receptioncombo.Size = new System.Drawing.Size(186, 24);
            this.receptioncombo.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(105, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "TrainerSSN";
            // 
            // trainercombo
            // 
            this.trainercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainercombo.FormattingEnabled = true;
            this.trainercombo.Location = new System.Drawing.Point(207, 128);
            this.trainercombo.Name = "trainercombo";
            this.trainercombo.Size = new System.Drawing.Size(186, 24);
            this.trainercombo.TabIndex = 6;
            this.trainercombo.SelectedIndexChanged += new System.EventHandler(this.trainercombo_SelectedIndexChanged_1);
            // 
            // firereceptionist
            // 
            this.firereceptionist.Location = new System.Drawing.Point(227, 334);
            this.firereceptionist.Name = "firereceptionist";
            this.firereceptionist.Size = new System.Drawing.Size(120, 37);
            this.firereceptionist.TabIndex = 5;
            this.firereceptionist.Text = "Fire-Receptionist";
            this.firereceptionist.UseVisualStyleBackColor = true;
            this.firereceptionist.Click += new System.EventHandler(this.firereceptionist_Click);
            // 
            // firetrainer
            // 
            this.firetrainer.Location = new System.Drawing.Point(227, 177);
            this.firetrainer.Name = "firetrainer";
            this.firetrainer.Size = new System.Drawing.Size(120, 37);
            this.firetrainer.TabIndex = 4;
            this.firetrainer.Text = "Fire-Trainer";
            this.firetrainer.UseVisualStyleBackColor = true;
            this.firetrainer.Click += new System.EventHandler(this.firetrainer_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 276);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 17);
            this.label22.TabIndex = 3;
            this.label22.Text = "Receptionist";
            // 
            // trainerdate
            // 
            this.trainerdate.Location = new System.Drawing.Point(540, 56);
            this.trainerdate.Name = "trainerdate";
            this.trainerdate.Size = new System.Drawing.Size(215, 22);
            this.trainerdate.TabIndex = 43;
            // 
            // receptiondate
            // 
            this.receptiondate.Location = new System.Drawing.Point(424, 296);
            this.receptiondate.Name = "receptiondate";
            this.receptiondate.Size = new System.Drawing.Size(200, 22);
            this.receptiondate.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Time-Shift";
            // 
            // shift
            // 
            this.shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shift.FormattingEnabled = true;
            this.shift.Items.AddRange(new object[] {
            "Morning ",
            "Evening"});
            this.shift.Location = new System.Drawing.Point(558, 387);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(121, 24);
            this.shift.TabIndex = 49;
            // 
            // rsexcombo
            // 
            this.rsexcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rsexcombo.FormattingEnabled = true;
            this.rsexcombo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.rsexcombo.Location = new System.Drawing.Point(642, 294);
            this.rsexcombo.Name = "rsexcombo";
            this.rsexcombo.Size = new System.Drawing.Size(121, 24);
            this.rsexcombo.TabIndex = 50;
            // 
            // tsexcombo
            // 
            this.tsexcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsexcombo.FormattingEnabled = true;
            this.tsexcombo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.tsexcombo.Location = new System.Drawing.Point(403, 56);
            this.tsexcombo.Name = "tsexcombo";
            this.tsexcombo.Size = new System.Drawing.Size(121, 24);
            this.tsexcombo.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sex";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(689, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 17);
            this.label17.TabIndex = 53;
            this.label17.Text = "Sex";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(-18, 515);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 54;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(1339, 521);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 57;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Hire_Fire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1408, 565);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsexcombo);
            this.Controls.Add(this.rsexcombo);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.receptiondate);
            this.Controls.Add(this.trainerdate);
            this.Controls.Add(this.Firebox);
            this.Controls.Add(this.HireReceptionist);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.rfname);
            this.Controls.Add(this.rlname);
            this.Controls.Add(this.rphone);
            this.Controls.Add(this.rlink);
            this.Controls.Add(this.rsalary);
            this.Controls.Add(this.raddress);
            this.Controls.Add(this.rssn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.link);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.address);
            this.Controls.Add(this.description);
            this.Controls.Add(this.trainerssn);
            this.Controls.Add(this.HireTrainer);
            this.Name = "Hire_Fire";
            this.Text = "Hire_Fire";
            this.Firebox.ResumeLayout(false);
            this.Firebox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HireTrainer;
        private System.Windows.Forms.TextBox trainerssn;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox rfname;
        private System.Windows.Forms.TextBox rlname;
        private System.Windows.Forms.TextBox rphone;
        private System.Windows.Forms.TextBox rlink;
        private System.Windows.Forms.TextBox rsalary;
        private System.Windows.Forms.TextBox raddress;
        private System.Windows.Forms.TextBox rssn;
        private System.Windows.Forms.Button HireReceptionist;
        private System.Windows.Forms.GroupBox Firebox;
        private System.Windows.Forms.Button firereceptionist;
        private System.Windows.Forms.Button firetrainer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker trainerdate;
        private System.Windows.Forms.DateTimePicker receptiondate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox trainercombo;
        private System.Windows.Forms.ComboBox receptioncombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox shift;
        private System.Windows.Forms.ComboBox rsexcombo;
        private System.Windows.Forms.ComboBox tsexcombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}