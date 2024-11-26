using Tyuiu.ZainetdinovRA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "10293847";
            int n = 4;
            int m = 2;
            int expected = 4;
            int result = ds.Calculate(n, m, str);
            Assert.AreEqual(expected, result);
        }
    }
}
