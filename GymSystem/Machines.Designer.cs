
namespace GymSystem
{
    partial class Machines
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
            this.machineview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAll = new System.Windows.Forms.Button();
            this.machinecombo = new System.Windows.Forms.ComboBox();
            this.showmachine = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.machineview)).BeginInit();
            this.SuspendLayout();
            // 
            // machineview
            // 
            this.machineview.AllowUserToAddRows = false;
            this.machineview.AllowUserToDeleteRows = false;
            this.machineview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineview.Location = new System.Drawing.Point(318, 45);
            this.machineview.Name = "machineview";
            this.machineview.ReadOnly = true;
            this.machineview.RowHeadersWidth = 51;
            this.machineview.RowTemplate.Height = 24;
            this.machineview.Size = new System.Drawing.Size(962, 447);
            this.machineview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Machine-ID";
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(96, 410);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(131, 36);
            this.ShowAll.TabIndex = 7;
            this.ShowAll.Text = "Show-All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // machinecombo
            // 
            this.machinecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinecombo.FormattingEnabled = true;
            this.machinecombo.Location = new System.Drawing.Point(141, 204);
            this.machinecombo.Name = "machinecombo";
            this.machinecombo.Size = new System.Drawing.Size(121, 24);
            this.machinecombo.TabIndex = 8;
            this.machinecombo.SelectedIndexChanged += new System.EventHandler(this.machinecombo_SelectedIndexChanged);
            // 
            // showmachine
            // 
            this.showmachine.Location = new System.Drawing.Point(96, 254);
            this.showmachine.Name = "showmachine";
            this.showmachine.Size = new System.Drawing.Size(131, 36);
            this.showmachine.TabIndex = 9;
            this.showmachine.Text = "Show-Machine";
            this.showmachine.UseVisualStyleBackColor = true;
            this.showmachine.Click += new System.EventHandler(this.showmachine_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::GymSystem.Properties.Resources.output_onlinepngtools__7_;
            this.backbutton.Location = new System.Drawing.Point(-21, 532);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 45);
            this.backbutton.TabIndex = 55;
            this.backbutton.UseCompatibleTextRendering = true;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Image = global::GymSystem.Properties.Resources.Button_Close_icon;
            this.exitbutton.Location = new System.Drawing.Point(1273, 537);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(90, 43);
            this.exitbutton.TabIndex = 56;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 583);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.showmachine);
            this.Controls.Add(this.machinecombo);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machineview);
            this.Name = "Machines";
            this.Text = "Machines";
            ((System.ComponentModel.ISupportInitialize)(this.machineview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView machineview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.ComboBox machinecombo;
        private System.Windows.Forms.Button showmachine;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}