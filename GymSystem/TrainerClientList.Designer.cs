
namespace GymSystem
{
	partial class TrainerClientList
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
			this.dataGridClientList = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientList)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridClientList
			// 
			this.dataGridClientList.AllowUserToAddRows = false;
			this.dataGridClientList.AllowUserToDeleteRows = false;
			this.dataGridClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridClientList.Location = new System.Drawing.Point(12, 107);
			this.dataGridClientList.Name = "dataGridClientList";
			this.dataGridClientList.ReadOnly = true;
			this.dataGridClientList.Size = new System.Drawing.Size(776, 331);
			this.dataGridClientList.TabIndex = 0;
			// 
			// TrainerClientList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridClientList);
			this.Name = "TrainerClientList";
			this.Text = "TrainerClientList";
			this.Load += new System.EventHandler(this.TrainerClientList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridClientList;
	}
}