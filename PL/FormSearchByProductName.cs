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
    public partial class FormSearchByProductName : Form
    {
        private IProductBl _productBl = new Product_BL();
        private List<Product> _allProduct;
        public FormSearchByProductName()
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> tmp = _allProduct;
            if (textBox1.Text.Length == 0)
            {
                tmp = (List<Product>)(_productBl.SearchByProductName(textBox1.Text));
            }
            RenderDataGridView(DataTable, tmp);
        }
    }
}
