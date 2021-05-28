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

        [TestMethod]
        [ExpectedException(typeof(Exception), "Incorrect Name")]
        public void CheckProductName()
        {
            string name = "1212Cheese";
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
        }

        
        [TestMethod]
        [ExpectedException(typeof(Exception), "Date come later then date out")]
        public void CheckProductSaleDates()
        {
            string name = "Cheese";
            DateTime? d_out = new DateTime(year: 2021, month: 5, day: 7);
            DateTime? d_come = new DateTime(year: 2021, month: 6, day: 7);
            DateTime? s_life = new DateTime(year: 2021, month: 8, day: 6);
            DateTime? d_utilization = new DateTime(year: 2021, month: 8, day: 7);
            var item = new Product(
                name: name,
                d_c: d_come,
                d_o: d_out,
                s_l: s_life,
                d_u: d_utilization
            );
        }
    }
}
