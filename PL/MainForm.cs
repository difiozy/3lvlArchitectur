using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BL_Interface;
using ProjectEntities;

namespace PL
{
    public partial class MainForm : Form
    {
        private IProductBl _productBl = new Product_BL();
        private List<Product> _allItems;
        public MainForm()
        {
            _allItems = new List<Product>(_productBl.GetAllProduct());
            InitializeComponent();
            RenderDataGridView(DataTable, _allItems);
        }

        private void RenderDataGridView(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = (DataGridViewRow)dataTable.Rows[0].Clone();
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.ProductName;
                if (item.DateCome != null)
                    row.Cells[2].Value = ((DateTime)item.DateCome).ToShortDateString();

                if (item.DateOut != null)
                    row.Cells[3].Value = ((DateTime)item.DateOut).ToShortDateString();

                if (item.ShelfLife != null)
                    row.Cells[4].Value = ((DateTime)item.ShelfLife).ToShortDateString();

                if (item.DateUtilization != null)
                    row.Cells[5].Value = ((DateTime)item.DateUtilization).ToShortDateString();
                dataTable.Rows.Add(row);
            }
        }

        

        private void refreshButton_Click(object sender, EventArgs e)
        {
            _allItems = new List<Product>(_productBl.GetAllProduct());
            RenderDataGridView(DataTable, _allItems);
        }

        private void ProductByIdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteProductById form = new DeleteProductById();
            form.Show();
        }

        private void newProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm();
            form.Show();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchByProductName form = new FormSearchByProductName();
            form.Show();
        }

        private void comeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateComeSearch form = new FormDateComeSearch();
            form.Show();
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateOutSearch form = new FormDateOutSearch();
            form.Show();
        }

        private void shelfLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateShelfLifeSearch form = new FormDateShelfLifeSearch();
            form.Show();
        }

        private void utilizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDateUtilizationSearch form = new FormDateUtilizationSearch();
            form.Show();
        }
    }
}
