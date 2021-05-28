using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class SearchMenu : Form
    {
        public SearchMenu()
        {
            InitializeComponent();
        }

        private void nname_Click(object sender, EventArgs e)
        {
            FormSearchByProductName form =new FormSearchByProductName();
            form.Show();
        }

        private void DateCome_Click(object sender, EventArgs e)
        {
            FormDateComeSearch form = new FormDateComeSearch();
            form.Show();
        }

        private void DateOut_Click(object sender, EventArgs e)
        {
            FormDateOutSearch form = new FormDateOutSearch();
            form.Show();
        }

        private void ShelfLife_Click(object sender, EventArgs e)
        {
            FormDateShelfLifeSearch form = new FormDateShelfLifeSearch();
            form.Show();
        }

        private void DateUtilization_Click(object sender, EventArgs e)
        {
            FormDateUtilizationSearch form = new FormDateUtilizationSearch();
            form.Show();
        }
    }
}
