using Tyuiu.BelovolovVS.Sprint1.Task1.V26.Lib;
namespace Tyuiu.BelovolovVS.Sprint1.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
