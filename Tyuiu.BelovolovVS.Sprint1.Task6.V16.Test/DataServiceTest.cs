using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckSpecSymbols()
        {
            DataService ds = new DataService();
            string text = "Привет! Как дела?";

            bool expected = true;
            bool actual = ds.CheckSpecSymbols(text);

            Assert.AreEqual(expected, actual);
        }
    }
}