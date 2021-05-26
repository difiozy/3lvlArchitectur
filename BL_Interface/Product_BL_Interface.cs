using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntities;
namespace BL_Interface
{
    public interface IProductBl
    {
        IEnumerable<Product> GetAllProduct();

        IEnumerable<Product> SearchByProductName(string name);

        IEnumerable<Product> SearchByDateCome(DateTime curDate);
        IEnumerable<Product> SearchByShelfLife(DateTime curDate);
        IEnumerable<Product> SearchByDateUtilization(DateTime curDate);
        IEnumerable<Product> SearchByDateOut(DateTime curDate);

        void AddNewProduct(Product product);

        void DeleteProduct(int idProduct);
    }
}
