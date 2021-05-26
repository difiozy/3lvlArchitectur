using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectEntities;
using BL;
using BL_Interface;
namespace PL
{
    public partial class AddNewProductForm : Form
    {
        private IProductBl _productBl = new Product_BL();
        public AddNewProductForm()
        {
            InitializeComponent();
        }

        private void dateTimeCome_ValueChanged(object sender, EventArgs e)
        {
            DateCome.Text = dateTimeCome.Value.ToShortDateString();
        }

        private void dateTimeOut_ValueChanged(object sender, EventArgs e)
        {
            DateOut.Text = dateTimeOut.Value.ToShortDateString();
        }

        private void dateTimeShelfLife_ValueChanged(object sender, EventArgs e)
        {
            ShelfLife.Text = dateTimeShelfLife.Value.ToShortDateString();
        }

        private void dateTimeUtilization_ValueChanged(object sender, EventArgs e)
        {
            DateUtilization.Text = dateTimeUtilization.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product NI = new Product(name: nname.Text,
                d_c: DateCome.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(DateCome.Text),
                d_o: DateOut.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(DateOut.Text),
                s_l: ShelfLife.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(ShelfLife.Text),
                d_u: DateUtilization.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(DateUtilization.Text));
            _productBl.AddNewProduct(NI);
            this.Close();
        }
    }
}
