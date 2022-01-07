
namespace GymSystem
{
    partial class salaryManagment
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
            this.containBonus = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.enterbonus = new System.Windows.Forms.Button();
            this.bonus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Salaries = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.receptioncombo2 = new System.Windows.Forms.ComboBox();
            this.trainercombo2 = new System.Windows.Forms.ComboBox();
            this.pay = new System.Windows.Forms.Button();
            this.showreceptionist = new System.Windows.Forms.Button();
            this.showtrainers = new System.Windows.Forms.Button();
            this.salaryshow = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.Salaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryshow)).BeginInit();
            this.SuspendLayout();
            // 
            // containBonus
            // 
            this.containBonus.AutoSize = true;
            this.containBonus.Location = new System.Drawing.Point(48, 108);
            this.containBonus.Name = "containBonus";
            this.containBonus.Size = new System.Drawing.Size(69, 21);
            this.containBonus.TabIndex = 0;
            this.containBonus.TabStop = true;
            this.containBonus.Text = "Bonus";
            this.containBonus.UseVisualStyleBackColor = true;
            this.containBonus.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(148, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No-Bonus";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // enterbonus
            // 
            this.enterbonus.Location = new System.Drawing.Point(80, 151);
            this.enterbonus.Name = "enterbonus";
            this.enterbonus.Size = new System.Drawing.Size(126, 35);
            this.enterbonus.TabIndex = 3;
            this.enterbonus.Text = "Enter-Bonus";
            this.enterbonus.UseVisualStyleBackColor = true;
            this.enterbonus.Click += new System.EventHandler(this.button1_Click);
            // 
            // bonus
            // 
            this.bonus.Location = new System.Drawing.Point(140, 203);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(100, 22);
            this.bonus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bonus-Value";
            // 
            // Salaries
            // 
            this.Salaries.Controls.Add(this.label4);
            this.Salaries.Controls.Add(this.label3);
            this.Salaries.Controls.Add(this.label2);
            this.Salaries.Controls.Add(this.textBox1);
            this.Salaries.Controls.Add(this.receptioncombo2);
            this.Salaries.Controls.Add(this.trainercombo2);
            this.Salaries.Controls.Add(this.pay);
            this.Salaries.Controls.Add(this.showreceptionist);
            this.Salaries.Controls.Add(this.showtrainers);
            this.Salaries.Controls.Add(this.salaryshow);
            this.Salaries.Location = new System.Drawing.Point(289, 24);
            this.Salaries.Name = "Salaries";
            this.Salaries.Size = new System.Drawing.Size(1006, 526);
            this.Salaries.TabIndex = 7;
            this.Salaries.TabStop = false;
            this.Salaries.Text = "Salaries-Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Receptionist-SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trainer-SSN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // receptioncombo2
            // 
            this.receptioncombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receptioncombo2.FormattingEnabled = true;
            this.receptioncombo2.Location = new System.Drawing.Point(200, 309);
            this.receptioncombo2.Name = "receptioncombo2";
            this.receptioncombo2.Size = new System.Drawing.Size(121, 24);
            this.receptioncombo2.TabIndex = 5;
            // 
            // trainercombo2
            // 
            this.trainercombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainercombo2.FormattingEnabled = true;
            this.trainercombo2.Location = new System.Drawing.Point(21, 309);
            this.trainercombo2.Name = "trainercombo2";
            this.trainercombo2.Size = new System.Drawing.Size(121, 24);
            this.trainercombo2.TabIndex = 4;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(104, 421);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(136, 35);
            this.pay.TabIndex = 3;
            this.pay.Text = "Pay-Salary";
            this.pay.UseVisualStyleBackColor = true;
            // 
            // showreceptionist
            // 
            this.showreceptionist.Location = new System.Drawing.Point(84, 173);
            this.showreceptionist.Name = "showreceptionist";
            this.showreceptionist.Size = new System.Drawing.Size(142, 36);
            this.showreceptionist.TabIndex = 2;
            this.showreceptionist.Text = "Show-Receptionist";
            this.showreceptionist.UseVisualStyleBackColor = true;
            this.showreceptionist.Click += new System.EventHandler(this.showreceptionist_Click);
            // 
            // showtrainers
            // 
            this.showtrainers.Location = new System.Drawing.Point(84, 116);
            this.showtrainers.Name = "showtrainers";
            this.showtrainers.Size = new System.Drawing.Size(141, 35);
            this.showtrainers.TabIndex = 1;
            this.showtrainers.Text = "Show-Trainers";
            this.showtrainers.UseVisualStyleBackColor = true;
            this.showtrainers.Click += new System.EventHandler(this.showtrainers_Click);
            // 
            // salaryshow
            // 
            this.salaryshow.AllowUserToAddRows = false;
            this.salaryshow.AllowUserToDeleteRows = false;
            this.salaryshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryshow.Location = new System.Drawing.Point(465, 37);
            this.salaryshow.Name = "salaryshow";
            this.salaryshow.ReadOnly = true;
            this.salaryshow.RowHeadersWidth = 51;
            this.salaryshow.RowTemplate.Height = 24;
            this.salaryshow.Size = new System.Drawing.Size(535, 443);
            this.salaryshow.TabIndex = 0;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(-21, 565);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 56;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(1241, 567);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // salaryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1320, 616);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.Salaries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.enterbonus);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.containBonus);
            this.Name = "salaryManagment";
            this.Text = "Salary-Managment";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Salaries.ResumeLayout(false);
            this.Salaries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton containBonus;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button enterbonus;
        private System.Windows.Forms.TextBox bonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Salaries;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox receptioncombo2;
        private System.Windows.Forms.ComboBox trainercombo2;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button showreceptionist;
        private System.Windows.Forms.Button showtrainers;
        private System.Windows.Forms.DataGridView salaryshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}