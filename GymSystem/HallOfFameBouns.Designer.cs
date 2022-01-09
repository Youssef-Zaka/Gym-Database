
namespace GymSystem
{
    partial class HallOfFameBouns
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
            this.ViewClients_Subsdatagridview = new System.Windows.Forms.DataGridView();
            this.trainerdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowClientsbutton = new System.Windows.Forms.Button();
            this.ShowSubbutton = new System.Windows.Forms.Button();
            this.SubsIDtext = new System.Windows.Forms.TextBox();
            this.ClientIDtext = new System.Windows.Forms.TextBox();
            this.AddBounsbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClients_Subsdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewClients_Subsdatagridview
            // 
            this.ViewClients_Subsdatagridview.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewClients_Subsdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewClients_Subsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClients_Subsdatagridview.Location = new System.Drawing.Point(12, 47);
            this.ViewClients_Subsdatagridview.Name = "ViewClients_Subsdatagridview";
            this.ViewClients_Subsdatagridview.Size = new System.Drawing.Size(335, 391);
            this.ViewClients_Subsdatagridview.TabIndex = 2;
            // 
            // trainerdate
            // 
            this.trainerdate.AutoSize = true;
            this.trainerdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.trainerdate.Location = new System.Drawing.Point(466, 9);
            this.trainerdate.Name = "trainerdate";
            this.trainerdate.Size = new System.Drawing.Size(118, 20);
            this.trainerdate.TabIndex = 3;
            this.trainerdate.Text = "Subscription ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(466, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client ID";
            // 
            // ShowClientsbutton
            // 
            this.ShowClientsbutton.Location = new System.Drawing.Point(22, 9);
            this.ShowClientsbutton.Name = "ShowClientsbutton";
            this.ShowClientsbutton.Size = new System.Drawing.Size(110, 23);
            this.ShowClientsbutton.TabIndex = 5;
            this.ShowClientsbutton.Text = "Show Clients";
            this.ShowClientsbutton.UseVisualStyleBackColor = true;
            this.ShowClientsbutton.Click += new System.EventHandler(this.ShowClientsbutton_Click);
            // 
            // ShowSubbutton
            // 
            this.ShowSubbutton.Location = new System.Drawing.Point(161, 9);
            this.ShowSubbutton.Name = "ShowSubbutton";
            this.ShowSubbutton.Size = new System.Drawing.Size(114, 23);
            this.ShowSubbutton.TabIndex = 6;
            this.ShowSubbutton.Text = "Show Subscriptions";
            this.ShowSubbutton.UseVisualStyleBackColor = true;
            this.ShowSubbutton.Click += new System.EventHandler(this.ShowSubbutton_Click);
            // 
            // SubsIDtext
            // 
            this.SubsIDtext.Location = new System.Drawing.Point(590, 9);
            this.SubsIDtext.Name = "SubsIDtext";
            this.SubsIDtext.Size = new System.Drawing.Size(142, 20);
            this.SubsIDtext.TabIndex = 7;
            this.SubsIDtext.TextChanged += new System.EventHandler(this.SubsIDtext_TextChanged);
            this.SubsIDtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubsIDtext_KeyPress);
            // 
            // ClientIDtext
            // 
            this.ClientIDtext.Location = new System.Drawing.Point(590, 91);
            this.ClientIDtext.Name = "ClientIDtext";
            this.ClientIDtext.Size = new System.Drawing.Size(142, 20);
            this.ClientIDtext.TabIndex = 8;
            this.ClientIDtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDtext_KeyPress);
            // 
            // AddBounsbutton
            // 
            this.AddBounsbutton.Location = new System.Drawing.Point(470, 164);
            this.AddBounsbutton.Name = "AddBounsbutton";
            this.AddBounsbutton.Size = new System.Drawing.Size(164, 23);
            this.AddBounsbutton.TabIndex = 9;
            this.AddBounsbutton.Text = "Add ";
            this.AddBounsbutton.UseVisualStyleBackColor = true;
            this.AddBounsbutton.Click += new System.EventHandler(this.AddBounsbutton_Click);
            // 
            // HallOfFameBouns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBounsbutton);
            this.Controls.Add(this.ClientIDtext);
            this.Controls.Add(this.SubsIDtext);
            this.Controls.Add(this.ShowSubbutton);
            this.Controls.Add(this.ShowClientsbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trainerdate);
            this.Controls.Add(this.ViewClients_Subsdatagridview);
            this.Name = "HallOfFameBouns";
            this.Text = "HallOfFameBouns";
            ((System.ComponentModel.ISupportInitialize)(this.ViewClients_Subsdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ViewClients_Subsdatagridview;
        private System.Windows.Forms.Label trainerdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowClientsbutton;
        private System.Windows.Forms.Button ShowSubbutton;
        private System.Windows.Forms.TextBox SubsIDtext;
        private System.Windows.Forms.TextBox ClientIDtext;
        private System.Windows.Forms.Button AddBounsbutton;
    }
}