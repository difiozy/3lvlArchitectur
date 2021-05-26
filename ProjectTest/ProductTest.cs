using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BL;
using BL_Interface;
using ProjectEntities;

namespace ProjectTests
{
    [TestClass]
    public class ProductTest
    {
        private IProductBl _productBl = new Product_BL();

        [TestMethod]
        [ExpectedException(typeof(Exception), "Name is incorrect.")]
        public void CheckProductName()
        {
            string name = "Cheese";
            DateTime? d_come = new DateTime(year: 2021, month: 5, day: 7);
            DateTime? d_out = new DateTime(year: 2021, month: 6, day: 7);
            DateTime? s_life = new DateTime(year: 2021, month: 8, day: 6);
            DateTime? d_utilization = new DateTime(year: 2021, month: 8, day: 7);
            var item = new Product(
                name: name,
                d_c: d_come,
                d_o: d_out,
                s_l: s_life,
                d_u: d_utilization
            );
            _productBl.AddNewProduct(item);

            item.ProductName = "328Cheese";
            _productBl.AddNewProduct(item);
        }

        
        [TestMethod]
        [ExpectedException(typeof(Exception), "DateCome erlier then DateOut.")]
        public void CheckProductSaleDates()
        {
            string name = "Cheese";
            DateTime? d_come = new DateTime(year: 2021, month: 5, day: 7);
            DateTime? d_out = new DateTime(year: 2021, month: 6, day: 7);
            DateTime? s_life = new DateTime(year: 2021, month: 8, day: 6);
            DateTime? d_utilization = new DateTime(year: 2021, month: 8, day: 7);
            var item = new Product(
                name: name,
                d_c: d_come,
                d_o: d_out,
                s_l: s_life,
                d_u: d_utilization
            );
            _productBl.AddNewProduct(item);
            item.DateCome = d_out;
            item.DateOut = d_come;
            _productBl.AddNewProduct(item);
        }
    }
}
