using Tyuiu.ZainetdinovRA.Sprint4.Task3.V19.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,] { { 6, 5, 6, 3, 8 },
                                    {9, 4, 4, 3, 4},
                                    {3, 3, 6, 8, 6},
                                    { 6, 5, 3, 4, 3},
                                    { 9, 3, 5, 3, 7}};
            int count = 11;
            int result = ds.Calculate(arr);
            Assert.AreEqual(count, result);
        }
    }
}
