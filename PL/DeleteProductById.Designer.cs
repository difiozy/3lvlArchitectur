﻿
namespace PL
{
    partial class DeleteProductById
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
            this.components = new System.ComponentModel.Container();
            this.delet = new System.Windows.Forms.Button();
            this.IdtoDelete = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(93, 100);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(75, 23);
            this.delet.TabIndex = 0;
            this.delet.Text = "Delete";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // IdtoDelete
            // 
            this.IdtoDelete.Location = new System.Drawing.Point(93, 74);
            this.IdtoDelete.Name = "IdtoDelete";
            this.IdtoDelete.Size = new System.Drawing.Size(75, 20);
            this.IdtoDelete.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Id";
            // 
            // DeleteProductById
            // 
            this.ClientSize = new System.Drawing.Size(274, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdtoDelete);
            this.Controls.Add(this.delet);
            this.Name = "DeleteProductById";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.TextBox IdtoDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}