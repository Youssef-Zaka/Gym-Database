
namespace GymSystem
{
    partial class main_menu
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
            this.showmanagment = new System.Windows.Forms.Button();
            this.hire_fire = new System.Windows.Forms.Button();
            this.Show_Machines = new System.Windows.Forms.Button();
            this.gymfacilites = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showmanagment
            // 
            this.showmanagment.Location = new System.Drawing.Point(94, 81);
            this.showmanagment.Name = "showmanagment";
            this.showmanagment.Size = new System.Drawing.Size(168, 54);
            this.showmanagment.TabIndex = 0;
            this.showmanagment.Text = "Show-Managment";
            this.showmanagment.UseVisualStyleBackColor = true;
            this.showmanagment.Click += new System.EventHandler(this.showmanagment_Click);
            // 
            // hire_fire
            // 
            this.hire_fire.Location = new System.Drawing.Point(94, 174);
            this.hire_fire.Name = "hire_fire";
            this.hire_fire.Size = new System.Drawing.Size(168, 54);
            this.hire_fire.TabIndex = 1;
            this.hire_fire.Text = "Hire/Fire";
            this.hire_fire.UseVisualStyleBackColor = true;
            this.hire_fire.Click += new System.EventHandler(this.hire_fire_Click);
            // 
            // Show_Machines
            // 
            this.Show_Machines.Location = new System.Drawing.Point(94, 290);
            this.Show_Machines.Name = "Show_Machines";
            this.Show_Machines.Size = new System.Drawing.Size(168, 54);
            this.Show_Machines.TabIndex = 2;
            this.Show_Machines.Text = "Show-Machines";
            this.Show_Machines.UseVisualStyleBackColor = true;
            this.Show_Machines.Click += new System.EventHandler(this.Show_Machines_Click);
            // 
            // gymfacilites
            // 
            this.gymfacilites.Location = new System.Drawing.Point(94, 408);
            this.gymfacilites.Name = "gymfacilites";
            this.gymfacilites.Size = new System.Drawing.Size(168, 54);
            this.gymfacilites.TabIndex = 3;
            this.gymfacilites.Text = "Gym-Facilites";
            this.gymfacilites.UseVisualStyleBackColor = true;
            this.gymfacilites.Click += new System.EventHandler(this.gymfacilites_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(1193, 554);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 599);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.gymfacilites);
            this.Controls.Add(this.Show_Machines);
            this.Controls.Add(this.hire_fire);
            this.Controls.Add(this.showmanagment);
            this.Name = "main_menu";
            this.Text = "Main-Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showmanagment;
        private System.Windows.Forms.Button hire_fire;
        private System.Windows.Forms.Button Show_Machines;
        private System.Windows.Forms.Button gymfacilites;
        private System.Windows.Forms.Button exitbutton;
    }
}