using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint1.Task2.V29.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertSecondsToHours()
        {
            DataService ds = new DataService();
            int value = 600;
            int expected = 10;

            int actual = ds.ConvertSecondsToHours(value);

            Assert.AreEqual(expected, actual);
        }
    }
}