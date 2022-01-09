
namespace GymSystem
{
    partial class AddSupplement
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
            this.SupplementStock = new System.Windows.Forms.Label();
            this.SupplementName = new System.Windows.Forms.Label();
            this.SupplementCost = new System.Windows.Forms.Label();
            this.SupplementType = new System.Windows.Forms.Label();
            this.SupplementNametxt = new System.Windows.Forms.TextBox();
            this.SupplementTypetxt = new System.Windows.Forms.TextBox();
            this.SupplementStocktxt = new System.Windows.Forms.TextBox();
            this.SupplementCosttxt = new System.Windows.Forms.TextBox();
            this.AddSupplementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupplementStock
            // 
            this.SupplementStock.AutoSize = true;
            this.SupplementStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SupplementStock.Location = new System.Drawing.Point(12, 93);
            this.SupplementStock.Name = "SupplementStock";
            this.SupplementStock.Size = new System.Drawing.Size(50, 20);
            this.SupplementStock.TabIndex = 3;
            this.SupplementStock.Text = "Stock";
            // 
            // SupplementName
            // 
            this.SupplementName.AutoSize = true;
            this.SupplementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SupplementName.Location = new System.Drawing.Point(392, 23);
            this.SupplementName.Name = "SupplementName";
            this.SupplementName.Size = new System.Drawing.Size(141, 20);
            this.SupplementName.TabIndex = 4;
            this.SupplementName.Text = "Supplement Name";
            // 
            // SupplementCost
            // 
            this.SupplementCost.AutoSize = true;
            this.SupplementCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SupplementCost.Location = new System.Drawing.Point(392, 91);
            this.SupplementCost.Name = "SupplementCost";
            this.SupplementCost.Size = new System.Drawing.Size(42, 20);
            this.SupplementCost.TabIndex = 5;
            this.SupplementCost.Text = "Cost";
            // 
            // SupplementType
            // 
            this.SupplementType.AutoSize = true;
            this.SupplementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SupplementType.Location = new System.Drawing.Point(12, 25);
            this.SupplementType.Name = "SupplementType";
            this.SupplementType.Size = new System.Drawing.Size(129, 20);
            this.SupplementType.TabIndex = 6;
            this.SupplementType.Text = "Supplement type";
            // 
            // SupplementNametxt
            // 
            this.SupplementNametxt.Location = new System.Drawing.Point(604, 25);
            this.SupplementNametxt.Name = "SupplementNametxt";
            this.SupplementNametxt.Size = new System.Drawing.Size(100, 20);
            this.SupplementNametxt.TabIndex = 27;
            // 
            // SupplementTypetxt
            // 
            this.SupplementTypetxt.Location = new System.Drawing.Point(182, 27);
            this.SupplementTypetxt.Name = "SupplementTypetxt";
            this.SupplementTypetxt.Size = new System.Drawing.Size(100, 20);
            this.SupplementTypetxt.TabIndex = 28;
            // 
            // SupplementStocktxt
            // 
            this.SupplementStocktxt.Location = new System.Drawing.Point(182, 95);
            this.SupplementStocktxt.Name = "SupplementStocktxt";
            this.SupplementStocktxt.Size = new System.Drawing.Size(100, 20);
            this.SupplementStocktxt.TabIndex = 29;
            // 
            // SupplementCosttxt
            // 
            this.SupplementCosttxt.Location = new System.Drawing.Point(604, 93);
            this.SupplementCosttxt.Name = "SupplementCosttxt";
            this.SupplementCosttxt.Size = new System.Drawing.Size(100, 20);
            this.SupplementCosttxt.TabIndex = 30;
            // 
            // AddSupplementButton
            // 
            this.AddSupplementButton.Location = new System.Drawing.Point(251, 229);
            this.AddSupplementButton.Name = "AddSupplementButton";
            this.AddSupplementButton.Size = new System.Drawing.Size(183, 29);
            this.AddSupplementButton.TabIndex = 33;
            this.AddSupplementButton.Text = "Add Supplement";
            this.AddSupplementButton.UseVisualStyleBackColor = true;
            this.AddSupplementButton.Click += new System.EventHandler(this.AddSupplementButton_Click);
            // 
            // AddSupplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSupplementButton);
            this.Controls.Add(this.SupplementCosttxt);
            this.Controls.Add(this.SupplementStocktxt);
            this.Controls.Add(this.SupplementTypetxt);
            this.Controls.Add(this.SupplementNametxt);
            this.Controls.Add(this.SupplementType);
            this.Controls.Add(this.SupplementCost);
            this.Controls.Add(this.SupplementName);
            this.Controls.Add(this.SupplementStock);
            this.Name = "AddSupplement";
            this.Text = "AddSupplement";
            this.Load += new System.EventHandler(this.AddSupplement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SupplementStock;
        private System.Windows.Forms.Label SupplementName;
        private System.Windows.Forms.Label SupplementCost;
        private System.Windows.Forms.Label SupplementType;
        private System.Windows.Forms.TextBox SupplementNametxt;
        private System.Windows.Forms.TextBox SupplementTypetxt;
        private System.Windows.Forms.TextBox SupplementStocktxt;
        private System.Windows.Forms.TextBox SupplementCosttxt;
        private System.Windows.Forms.Button AddSupplementButton;
    }
}