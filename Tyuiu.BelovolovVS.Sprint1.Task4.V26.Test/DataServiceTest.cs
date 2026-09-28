using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task4.V26.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;

            double expected = -0.062;
            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}