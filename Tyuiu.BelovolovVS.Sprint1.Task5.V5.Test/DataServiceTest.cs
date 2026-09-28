using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int expected = 5;

            int actual = ds.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}