
namespace GymSystem
{
    partial class GymFacilities
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
            this.classes = new System.Windows.Forms.GroupBox();
            this.removeclass = new System.Windows.Forms.Button();
            this.classcombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scost = new System.Windows.Forms.TextBox();
            this.sfreq = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.TextBox();
            this.addclass = new System.Windows.Forms.Button();
            this.dataclasses = new System.Windows.Forms.DataGridView();
            this.showclasses = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.GroupBox();
            this.removeservice = new System.Windows.Forms.Button();
            this.servicecombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maintenancedate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maintenancecost = new System.Windows.Forms.TextBox();
            this.maintenancefreq = new System.Windows.Forms.TextBox();
            this.servicename = new System.Windows.Forms.TextBox();
            this.addservice = new System.Windows.Forms.Button();
            this.dataservices = new System.Windows.Forms.DataGridView();
            this.showservice = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.updateclass = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.costclassupdate = new System.Windows.Forms.TextBox();
            this.freqclassupdate = new System.Windows.Forms.TextBox();
            this.dateclassupdate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.classcomboupdate = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.servicedateupdate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.servicecostupdate = new System.Windows.Forms.TextBox();
            this.servicefrequpdate = new System.Windows.Forms.TextBox();
            this.updateservice = new System.Windows.Forms.Button();
            this.servicecomboupdate = new System.Windows.Forms.ComboBox();
            this.classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasses)).BeginInit();
            this.services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataservices)).BeginInit();
            this.SuspendLayout();
            // 
            // classes
            // 
            this.classes.Controls.Add(this.label14);
            this.classes.Controls.Add(this.classcomboupdate);
            this.classes.Controls.Add(this.dateclassupdate);
            this.classes.Controls.Add(this.label13);
            this.classes.Controls.Add(this.label11);
            this.classes.Controls.Add(this.label12);
            this.classes.Controls.Add(this.costclassupdate);
            this.classes.Controls.Add(this.freqclassupdate);
            this.classes.Controls.Add(this.updateclass);
            this.classes.Controls.Add(this.removeclass);
            this.classes.Controls.Add(this.classcombo);
            this.classes.Controls.Add(this.label5);
            this.classes.Controls.Add(this.startdate);
            this.classes.Controls.Add(this.label4);
            this.classes.Controls.Add(this.label3);
            this.classes.Controls.Add(this.label2);
            this.classes.Controls.Add(this.label1);
            this.classes.Controls.Add(this.scost);
            this.classes.Controls.Add(this.sfreq);
            this.classes.Controls.Add(this.classname);
            this.classes.Controls.Add(this.addclass);
            this.classes.Controls.Add(this.dataclasses);
            this.classes.Controls.Add(this.showclasses);
            this.classes.Location = new System.Drawing.Point(25, 27);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(637, 512);
            this.classes.TabIndex = 0;
            this.classes.TabStop = false;
            this.classes.Text = "Classes";
            // 
            // removeclass
            // 
            this.removeclass.Location = new System.Drawing.Point(144, 457);
            this.removeclass.Name = "removeclass";
            this.removeclass.Size = new System.Drawing.Size(126, 32);
            this.removeclass.TabIndex = 15;
            this.removeclass.Text = "Remove-Class";
            this.removeclass.UseVisualStyleBackColor = true;
            this.removeclass.Click += new System.EventHandler(this.removeclass_Click);
            // 
            // classcombo
            // 
            this.classcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classcombo.FormattingEnabled = true;
            this.classcombo.Location = new System.Drawing.Point(8, 462);
            this.classcombo.Name = "classcombo";
            this.classcombo.Size = new System.Drawing.Size(121, 24);
            this.classcombo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ClassName";
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(155, 205);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 22);
            this.startdate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "SessionFreq";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start-Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ClassName";
            // 
            // scost
            // 
            this.scost.Location = new System.Drawing.Point(378, 207);
            this.scost.Name = "scost";
            this.scost.Size = new System.Drawing.Size(100, 22);
            this.scost.TabIndex = 5;
            this.scost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scost_KeyPress);
            // 
            // sfreq
            // 
            this.sfreq.Location = new System.Drawing.Point(497, 207);
            this.sfreq.Name = "sfreq";
            this.sfreq.Size = new System.Drawing.Size(100, 22);
            this.sfreq.TabIndex = 4;
            this.sfreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sfreq_KeyPress);
            // 
            // classname
            // 
            this.classname.Location = new System.Drawing.Point(24, 205);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(100, 22);
            this.classname.TabIndex = 3;
            this.classname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classname_KeyPress);
            // 
            // addclass
            // 
            this.addclass.Location = new System.Drawing.Point(234, 247);
            this.addclass.Name = "addclass";
            this.addclass.Size = new System.Drawing.Size(153, 38);
            this.addclass.TabIndex = 2;
            this.addclass.Text = "Add-Class";
            this.addclass.UseVisualStyleBackColor = true;
            this.addclass.Click += new System.EventHandler(this.addclass_Click);
            // 
            // dataclasses
            // 
            this.dataclasses.AllowUserToAddRows = false;
            this.dataclasses.AllowUserToDeleteRows = false;
            this.dataclasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataclasses.Location = new System.Drawing.Point(167, 21);
            this.dataclasses.Name = "dataclasses";
            this.dataclasses.ReadOnly = true;
            this.dataclasses.RowHeadersWidth = 51;
            this.dataclasses.RowTemplate.Height = 24;
            this.dataclasses.Size = new System.Drawing.Size(443, 148);
            this.dataclasses.TabIndex = 1;
            // 
            // showclasses
            // 
            this.showclasses.Location = new System.Drawing.Point(8, 92);
            this.showclasses.Name = "showclasses";
            this.showclasses.Size = new System.Drawing.Size(153, 35);
            this.showclasses.TabIndex = 0;
            this.showclasses.Text = "Show-Classes";
            this.showclasses.UseVisualStyleBackColor = true;
            this.showclasses.Click += new System.EventHandler(this.showclasses_Click);
            // 
            // services
            // 
            this.services.Controls.Add(this.servicecomboupdate);
            this.services.Controls.Add(this.servicedateupdate);
            this.services.Controls.Add(this.label15);
            this.services.Controls.Add(this.label16);
            this.services.Controls.Add(this.label17);
            this.services.Controls.Add(this.label18);
            this.services.Controls.Add(this.servicecostupdate);
            this.services.Controls.Add(this.servicefrequpdate);
            this.services.Controls.Add(this.updateservice);
            this.services.Controls.Add(this.removeservice);
            this.services.Controls.Add(this.servicecombo);
            this.services.Controls.Add(this.label6);
            this.services.Controls.Add(this.maintenancedate);
            this.services.Controls.Add(this.label7);
            this.services.Controls.Add(this.label8);
            this.services.Controls.Add(this.label9);
            this.services.Controls.Add(this.label10);
            this.services.Controls.Add(this.maintenancecost);
            this.services.Controls.Add(this.maintenancefreq);
            this.services.Controls.Add(this.servicename);
            this.services.Controls.Add(this.addservice);
            this.services.Controls.Add(this.dataservices);
            this.services.Controls.Add(this.showservice);
            this.services.Location = new System.Drawing.Point(687, 27);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(633, 516);
            this.services.TabIndex = 1;
            this.services.TabStop = false;
            this.services.Text = "Services";
            // 
            // removeservice
            // 
            this.removeservice.Location = new System.Drawing.Point(158, 462);
            this.removeservice.Name = "removeservice";
            this.removeservice.Size = new System.Drawing.Size(128, 32);
            this.removeservice.TabIndex = 29;
            this.removeservice.Text = "Remove-Service";
            this.removeservice.UseVisualStyleBackColor = true;
            this.removeservice.Click += new System.EventHandler(this.removeservice_Click);
            // 
            // servicecombo
            // 
            this.servicecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicecombo.FormattingEnabled = true;
            this.servicecombo.Location = new System.Drawing.Point(18, 465);
            this.servicecombo.Name = "servicecombo";
            this.servicecombo.Size = new System.Drawing.Size(121, 24);
            this.servicecombo.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Service-Name";
            // 
            // maintenancedate
            // 
            this.maintenancedate.Location = new System.Drawing.Point(277, 207);
            this.maintenancedate.Name = "maintenancedate";
            this.maintenancedate.Size = new System.Drawing.Size(200, 22);
            this.maintenancedate.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Maintenance-Freq";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Last-Maintenance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Service-Name";
            // 
            // maintenancecost
            // 
            this.maintenancecost.Location = new System.Drawing.Point(158, 207);
            this.maintenancecost.Name = "maintenancecost";
            this.maintenancecost.Size = new System.Drawing.Size(100, 22);
            this.maintenancecost.TabIndex = 21;
            this.maintenancecost.TextChanged += new System.EventHandler(this.maintenancecost_TextChanged);
            this.maintenancecost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maintenancecost_KeyPress);
            // 
            // maintenancefreq
            // 
            this.maintenancefreq.Location = new System.Drawing.Point(502, 207);
            this.maintenancefreq.Name = "maintenancefreq";
            this.maintenancefreq.Size = new System.Drawing.Size(100, 22);
            this.maintenancefreq.TabIndex = 20;
            this.maintenancefreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maintenancefreq_KeyPress);
            // 
            // servicename
            // 
            this.servicename.Location = new System.Drawing.Point(29, 205);
            this.servicename.Name = "servicename";
            this.servicename.Size = new System.Drawing.Size(100, 22);
            this.servicename.TabIndex = 19;
            this.servicename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.servicename_KeyPress);
            // 
            // addservice
            // 
            this.addservice.Location = new System.Drawing.Point(232, 254);
            this.addservice.Name = "addservice";
            this.addservice.Size = new System.Drawing.Size(153, 38);
            this.addservice.TabIndex = 18;
            this.addservice.Text = "Add-Service";
            this.addservice.UseVisualStyleBackColor = true;
            this.addservice.Click += new System.EventHandler(this.addservice_Click);
            // 
            // dataservices
            // 
            this.dataservices.AllowUserToAddRows = false;
            this.dataservices.AllowUserToDeleteRows = false;
            this.dataservices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataservices.Location = new System.Drawing.Point(177, 21);
            this.dataservices.Name = "dataservices";
            this.dataservices.ReadOnly = true;
            this.dataservices.RowHeadersWidth = 51;
            this.dataservices.RowTemplate.Height = 24;
            this.dataservices.Size = new System.Drawing.Size(440, 148);
            this.dataservices.TabIndex = 17;
            // 
            // showservice
            // 
            this.showservice.Location = new System.Drawing.Point(18, 66);
            this.showservice.Name = "showservice";
            this.showservice.Size = new System.Drawing.Size(153, 35);
            this.showservice.TabIndex = 16;
            this.showservice.Text = "Show-Services";
            this.showservice.UseVisualStyleBackColor = true;
            this.showservice.Click += new System.EventHandler(this.showservice_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(-18, 545);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 16;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(1272, 555);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 58;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // updateclass
            // 
            this.updateclass.Location = new System.Drawing.Point(249, 380);
            this.updateclass.Name = "updateclass";
            this.updateclass.Size = new System.Drawing.Size(126, 32);
            this.updateclass.TabIndex = 16;
            this.updateclass.Text = "Update-Class";
            this.updateclass.UseVisualStyleBackColor = true;
            this.updateclass.Click += new System.EventHandler(this.updateclass_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "SessionFreq";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cost";
            // 
            // costclassupdate
            // 
            this.costclassupdate.Location = new System.Drawing.Point(383, 330);
            this.costclassupdate.Name = "costclassupdate";
            this.costclassupdate.Size = new System.Drawing.Size(100, 22);
            this.costclassupdate.TabIndex = 18;
            this.costclassupdate.TextChanged += new System.EventHandler(this.costclassupdate_TextChanged);
            // 
            // freqclassupdate
            // 
            this.freqclassupdate.Location = new System.Drawing.Point(502, 330);
            this.freqclassupdate.Name = "freqclassupdate";
            this.freqclassupdate.Size = new System.Drawing.Size(100, 22);
            this.freqclassupdate.TabIndex = 17;
            // 
            // dateclassupdate
            // 
            this.dateclassupdate.Location = new System.Drawing.Point(155, 330);
            this.dateclassupdate.Name = "dateclassupdate";
            this.dateclassupdate.Size = new System.Drawing.Size(200, 22);
            this.dateclassupdate.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Start-Date";
            // 
            // classcomboupdate
            // 
            this.classcomboupdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classcomboupdate.FormattingEnabled = true;
            this.classcomboupdate.Location = new System.Drawing.Point(18, 328);
            this.classcomboupdate.Name = "classcomboupdate";
            this.classcomboupdate.Size = new System.Drawing.Size(121, 24);
            this.classcomboupdate.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "ClassName";
            // 
            // servicedateupdate
            // 
            this.servicedateupdate.Location = new System.Drawing.Point(277, 330);
            this.servicedateupdate.Name = "servicedateupdate";
            this.servicedateupdate.Size = new System.Drawing.Size(200, 22);
            this.servicedateupdate.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(493, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "Maintenance-Freq";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "Cost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(311, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Last-Maintenance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 308);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Service-Name";
            // 
            // servicecostupdate
            // 
            this.servicecostupdate.Location = new System.Drawing.Point(158, 330);
            this.servicecostupdate.Name = "servicecostupdate";
            this.servicecostupdate.Size = new System.Drawing.Size(100, 22);
            this.servicecostupdate.TabIndex = 33;
            // 
            // servicefrequpdate
            // 
            this.servicefrequpdate.Location = new System.Drawing.Point(502, 330);
            this.servicefrequpdate.Name = "servicefrequpdate";
            this.servicefrequpdate.Size = new System.Drawing.Size(100, 22);
            this.servicefrequpdate.TabIndex = 32;
            // 
            // updateservice
            // 
            this.updateservice.Location = new System.Drawing.Point(232, 377);
            this.updateservice.Name = "updateservice";
            this.updateservice.Size = new System.Drawing.Size(153, 38);
            this.updateservice.TabIndex = 30;
            this.updateservice.Text = "Update-Service";
            this.updateservice.UseVisualStyleBackColor = true;
            this.updateservice.Click += new System.EventHandler(this.updateservice_Click);
            // 
            // servicecomboupdate
            // 
            this.servicecomboupdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicecomboupdate.FormattingEnabled = true;
            this.servicecomboupdate.Location = new System.Drawing.Point(18, 328);
            this.servicecomboupdate.Name = "servicecomboupdate";
            this.servicecomboupdate.Size = new System.Drawing.Size(121, 24);
            this.servicecomboupdate.TabIndex = 39;
            // 
            // GymFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1343, 599);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.services);
            this.Controls.Add(this.classes);
            this.Name = "GymFacilities";
            this.Text = "Gym-Facilities";
            this.classes.ResumeLayout(false);
            this.classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasses)).EndInit();
            this.services.ResumeLayout(false);
            this.services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataservices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox classes;
        private System.Windows.Forms.DataGridView dataclasses;
        private System.Windows.Forms.Button showclasses;
        private System.Windows.Forms.GroupBox services;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scost;
        private System.Windows.Forms.TextBox sfreq;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.Button addclass;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Button removeclass;
        private System.Windows.Forms.ComboBox classcombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeservice;
        private System.Windows.Forms.ComboBox servicecombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker maintenancedate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maintenancecost;
        private System.Windows.Forms.TextBox maintenancefreq;
        private System.Windows.Forms.TextBox servicename;
        private System.Windows.Forms.Button addservice;
        private System.Windows.Forms.DataGridView dataservices;
        private System.Windows.Forms.Button showservice;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox costclassupdate;
        private System.Windows.Forms.TextBox freqclassupdate;
        private System.Windows.Forms.Button updateclass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox classcomboupdate;
        private System.Windows.Forms.DateTimePicker dateclassupdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox servicecomboupdate;
        private System.Windows.Forms.DateTimePicker servicedateupdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox servicecostupdate;
        private System.Windows.Forms.TextBox servicefrequpdate;
        private System.Windows.Forms.Button updateservice;
    }
}