
namespace PL
{
    partial class MainForm
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataTable.Location = new System.Drawing.Point(12, 41);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.Size = new System.Drawing.Size(776, 338);
            this.DataTable.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 124;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DateCome";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DateOut";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 124;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ShelfLife";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DateUtilization";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 124;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(687, 404);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 34);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Reload";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(12, 12);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(93, 12);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.DeleteProduct.TabIndex = 4;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "SearchMenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.DataTable);
            this.Name = "MainForm";
            this.Text = "Shop data system";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button button1;
    }
}

