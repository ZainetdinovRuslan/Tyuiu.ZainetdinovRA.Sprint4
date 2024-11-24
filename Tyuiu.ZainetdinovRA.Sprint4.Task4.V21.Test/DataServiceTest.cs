using Tyuiu.ZainetdinovRA.Sprint4.Task4.V21.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,] { { 3, 6, 4, 6, 6 },
                                      { 7, 5, 5, 5, 8 },
                                      { 8, 3, 6, 7, 7 },
                                      { 5, 3, 8, 4, 5 },
                                      { 3, 7, 4, 3, 8,} };
            int count = 68;
            int result = ds.Calculate(arr);
            Assert.AreEqual(count, result);
        }
    }
}
