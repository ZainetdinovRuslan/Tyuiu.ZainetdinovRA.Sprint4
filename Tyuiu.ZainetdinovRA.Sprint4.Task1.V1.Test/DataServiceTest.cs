using Tyuiu.ZainetdinovRA.Sprint4.Task1.V1.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int wait = 14;
            int result = ds.Calculate(array);
            Assert.AreEqual(wait, result);
        }
    }
}
