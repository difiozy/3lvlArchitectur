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
    public partial class DeleteProductById : Form
    {
        private IProductBl _productBl = new Product_BL();
        private List<Product> _allItems;
        private List<int> _allIDs = new List<int>();
        public DeleteProductById()
        {
            _allItems = new List<Product>(_productBl.GetAllProduct());
            InitializeComponent();
            foreach (var item in _allItems)
            {
                if (!_allIDs.Contains(item.Id))
                {
                    _allIDs.Add(item.Id);
                }
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtoDelete.Text);
            if (!_allIDs.Contains(id))
            {
                errorProvider1.SetError(delet, "Товара с таким ID не существует");
                return;
            }
            _productBl.DeleteProduct(id);
            this.Close();
        }

    }
}
