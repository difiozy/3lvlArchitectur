
namespace PL
{
    partial class AddNewProductForm
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
            this.DateCome = new System.Windows.Forms.TextBox();
            this.DateOut = new System.Windows.Forms.TextBox();
            this.ShelfLife = new System.Windows.Forms.TextBox();
            this.dateTimeShelfLife = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCome = new System.Windows.Forms.DateTimePicker();
            this.DateUtilization = new System.Windows.Forms.TextBox();
            this.dateTimeUtilization = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateCome
            // 
            this.DateCome.Location = new System.Drawing.Point(24, 71);
            this.DateCome.Name = "DateCome";
            this.DateCome.Size = new System.Drawing.Size(100, 20);
            this.DateCome.TabIndex = 0;
            // 
            // DateOut
            // 
            this.DateOut.Location = new System.Drawing.Point(24, 132);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(100, 20);
            this.DateOut.TabIndex = 1;
            // 
            // ShelfLife
            // 
            this.ShelfLife.Location = new System.Drawing.Point(24, 186);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(100, 20);
            this.ShelfLife.TabIndex = 2;
            // 
            // dateTimeShelfLife
            // 
            this.dateTimeShelfLife.Location = new System.Drawing.Point(131, 186);
            this.dateTimeShelfLife.Name = "dateTimeShelfLife";
            this.dateTimeShelfLife.Size = new System.Drawing.Size(138, 20);
            this.dateTimeShelfLife.TabIndex = 3;
            this.dateTimeShelfLife.ValueChanged += new System.EventHandler(this.dateTimeShelfLife_ValueChanged);
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Location = new System.Drawing.Point(131, 129);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(138, 20);
            this.dateTimeOut.TabIndex = 4;
            this.dateTimeOut.ValueChanged += new System.EventHandler(this.dateTimeOut_ValueChanged);
            // 
            // dateTimeCome
            // 
            this.dateTimeCome.Location = new System.Drawing.Point(131, 71);
            this.dateTimeCome.Name = "dateTimeCome";
            this.dateTimeCome.Size = new System.Drawing.Size(138, 20);
            this.dateTimeCome.TabIndex = 5;
            this.dateTimeCome.ValueChanged += new System.EventHandler(this.dateTimeCome_ValueChanged);
            // 
            // DateUtilization
            // 
            this.DateUtilization.Location = new System.Drawing.Point(24, 237);
            this.DateUtilization.Name = "DateUtilization";
            this.DateUtilization.Size = new System.Drawing.Size(100, 20);
            this.DateUtilization.TabIndex = 6;
            // 
            // dateTimeUtilization
            // 
            this.dateTimeUtilization.Location = new System.Drawing.Point(131, 237);
            this.dateTimeUtilization.Name = "dateTimeUtilization";
            this.dateTimeUtilization.Size = new System.Drawing.Size(138, 20);
            this.dateTimeUtilization.TabIndex = 7;
            this.dateTimeUtilization.ValueChanged += new System.EventHandler(this.dateTimeUtilization_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "DateOut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ShelfLife";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DateUtilization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // nname
            // 
            this.nname.Location = new System.Drawing.Point(24, 29);
            this.nname.Name = "nname";
            this.nname.Size = new System.Drawing.Size(100, 20);
            this.nname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DaceCome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeUtilization);
            this.Controls.Add(this.DateUtilization);
            this.Controls.Add(this.dateTimeCome);
            this.Controls.Add(this.dateTimeOut);
            this.Controls.Add(this.dateTimeShelfLife);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.DateCome);
            this.Name = "AddNewProductForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateCome;
        private System.Windows.Forms.TextBox DateOut;
        private System.Windows.Forms.TextBox ShelfLife;
        private System.Windows.Forms.DateTimePicker dateTimeShelfLife;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeCome;
        private System.Windows.Forms.TextBox DateUtilization;
        private System.Windows.Forms.DateTimePicker dateTimeUtilization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}