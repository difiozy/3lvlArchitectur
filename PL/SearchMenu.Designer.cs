
namespace PL
{
    partial class SearchMenu
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
            this.DateCome = new System.Windows.Forms.Button();
            this.nname = new System.Windows.Forms.Button();
            this.DateOut = new System.Windows.Forms.Button();
            this.ShelfLife = new System.Windows.Forms.Button();
            this.DateUtilization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateCome
            // 
            this.DateCome.Location = new System.Drawing.Point(17, 77);
            this.DateCome.Name = "DateCome";
            this.DateCome.Size = new System.Drawing.Size(75, 23);
            this.DateCome.TabIndex = 0;
            this.DateCome.Text = "Date come";
            this.DateCome.UseVisualStyleBackColor = true;
            this.DateCome.Click += new System.EventHandler(this.DateCome_Click);
            // 
            // nname
            // 
            this.nname.Location = new System.Drawing.Point(17, 48);
            this.nname.Name = "nname";
            this.nname.Size = new System.Drawing.Size(75, 23);
            this.nname.TabIndex = 1;
            this.nname.Text = "Name";
            this.nname.UseVisualStyleBackColor = true;
            this.nname.Click += new System.EventHandler(this.nname_Click);
            // 
            // DateOut
            // 
            this.DateOut.Location = new System.Drawing.Point(17, 106);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(75, 23);
            this.DateOut.TabIndex = 2;
            this.DateOut.Text = "Date out";
            this.DateOut.UseVisualStyleBackColor = true;
            this.DateOut.Click += new System.EventHandler(this.DateOut_Click);
            // 
            // ShelfLife
            // 
            this.ShelfLife.Location = new System.Drawing.Point(17, 135);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(75, 23);
            this.ShelfLife.TabIndex = 3;
            this.ShelfLife.Text = "Shelf life";
            this.ShelfLife.UseVisualStyleBackColor = true;
            this.ShelfLife.Click += new System.EventHandler(this.ShelfLife_Click);
            // 
            // DateUtilization
            // 
            this.DateUtilization.Location = new System.Drawing.Point(17, 164);
            this.DateUtilization.Name = "DateUtilization";
            this.DateUtilization.Size = new System.Drawing.Size(75, 37);
            this.DateUtilization.TabIndex = 4;
            this.DateUtilization.Text = "Date utilization";
            this.DateUtilization.UseVisualStyleBackColor = true;
            this.DateUtilization.Click += new System.EventHandler(this.DateUtilization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by";
            // 
            // SearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateUtilization);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.nname);
            this.Controls.Add(this.DateCome);
            this.Name = "SearchMenu";
            this.Text = "SearchMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DateCome;
        private System.Windows.Forms.Button nname;
        private System.Windows.Forms.Button DateOut;
        private System.Windows.Forms.Button ShelfLife;
        private System.Windows.Forms.Button DateUtilization;
        private System.Windows.Forms.Label label1;
    }
}