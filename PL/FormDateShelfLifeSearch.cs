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
    public partial class FormDateShelfLifeSearch : Form
    {
        private IProductBl _productBl = new Product_BL();
        private List<Product> _allProduct;
        public FormDateShelfLifeSearch()
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


        private void dateTextBox_Click(object sender, EventArgs e)
        {
            datePicker.Show();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> tmp = _allProduct;
            if (datePicker.Text.Length != 0)
            {
                tmp = (List<Product>)(_productBl.SearchByShelfLife(Convert.ToDateTime(datePicker.Value.ToShortDateString())));
            }
            RenderDataGridView(DataTable, tmp);
        }
    }
}
