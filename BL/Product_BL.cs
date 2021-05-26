using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL_Interface;
using DAO;
using DAO_Interface;
using ProjectEntities;

namespace BL
{
    public class Product_BL : IProductBl
    {
        private IProductDAO _productDao = new Product_DAO();

        public Product_BL()
        {
            this._productDao = new Product_DAO();
        }

        public IEnumerable<Product>GetAllProduct()
        {
            return this._productDao.GetAllProduct();
        }

        public IEnumerable<Product>SearchByProductName(string name)
        {
            return this._productDao.SearchByProductName(name);
        }

        public IEnumerable<Product> SearchByDateCome(DateTime curDate)
        {
            return this._productDao.SearchByDateCome(curDate);
        }

        public IEnumerable<Product> SearchByShelfLife(DateTime curDate)
        {
            return this._productDao.SearchByShelfLife(curDate);
        }

        public IEnumerable<Product> SearchByDateUtilization(DateTime curDate)
        {
            return this._productDao.SearchByDateUtilization(curDate);
        }

        public IEnumerable<Product> SearchByDateOut(DateTime curDate)
        {
            return this._productDao.SearchByDateOut(curDate);
        }

        public void AddNewProduct(Product product)
        {
            this._productDao.AddNewProduct(product);
        }

        public void DeleteProduct(int idProduct)
        {
            this._productDao.DeleteProduct(idProduct);
        }
    }
}
