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
        private List<Product> _allProduct;
        public MainForm()
        {
            _allProduct = new List<Product>(_productBl.GetAllProduct());
            InitializeComponent();
            RenderDataGridView(DataTable, _allProduct);
        }

        private void RenderDataGridView(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var el in items)
            {
                DataTable.Rows.Add(el.Id, el.ProductName,
                    (el.DateCome == null) ? " " : ((DateTime)el.DateCome).ToShortDateString(),
                    (el.DateOut == null) ? " " : ((DateTime)el.DateOut).ToShortDateString(),
                    (el.ShelfLife == null) ? " " : ((DateTime)el.ShelfLife).ToShortDateString(),
                    (el.DateUtilization == null) ? " " : ((DateTime)el.DateUtilization).ToShortDateString());

            }
        }

        

        private void refreshButton_Click(object sender, EventArgs e)
        {
            _allProduct = new List<Product>(_productBl.GetAllProduct());
            RenderDataGridView(DataTable, _allProduct);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm();
            form.Show();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProductById form = new DeleteProductById();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchMenu form = new SearchMenu();
            form.Show();
        }
    }
}
