
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridClientList = new System.Windows.Forms.DataGridView();
			this.labelTitleist = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientList)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridClientList
			// 
			this.dataGridClientList.AllowUserToAddRows = false;
			this.dataGridClientList.AllowUserToDeleteRows = false;
			this.dataGridClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridClientList.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridClientList.Location = new System.Drawing.Point(134, 107);
			this.dataGridClientList.Name = "dataGridClientList";
			this.dataGridClientList.ReadOnly = true;
			this.dataGridClientList.Size = new System.Drawing.Size(519, 331);
			this.dataGridClientList.TabIndex = 0;
			this.dataGridClientList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientList_CellDoubleClick);
			// 
			// labelTitleist
			// 
			this.labelTitleist.AutoSize = true;
			this.labelTitleist.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitleist.Location = new System.Drawing.Point(297, 31);
			this.labelTitleist.Name = "labelTitleist";
			this.labelTitleist.Size = new System.Drawing.Size(192, 42);
			this.labelTitleist.TabIndex = 2;
			this.labelTitleist.Text = "My Clients";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(131, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Click on any client to see his profile";
			// 
			// TrainerClientList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTitleist);
			this.Controls.Add(this.dataGridClientList);
			this.Name = "TrainerClientList";
			this.Text = "TrainerClientList";
			this.Load += new System.EventHandler(this.TrainerClientList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridClientList;
		private System.Windows.Forms.Label labelTitleist;
		private System.Windows.Forms.Label label1;
	}
}