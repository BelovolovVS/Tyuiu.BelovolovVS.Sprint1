using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task3.V2.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPurchaseAmount()
        {
            DataService ds = new DataService();
            double priceNotebook = 25.5;
            int amountNotebook = 3;
            double pricePencil = 12.15;
            int amountPencil = 5;

            double expected = 137.25;
            double actual = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Assert.AreEqual(expected, actual);
        }
    }
}