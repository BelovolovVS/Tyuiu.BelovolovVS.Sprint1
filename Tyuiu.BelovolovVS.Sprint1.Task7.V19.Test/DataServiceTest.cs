using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task7.V19.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double expected = -5.159;

            double actual = ds.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}