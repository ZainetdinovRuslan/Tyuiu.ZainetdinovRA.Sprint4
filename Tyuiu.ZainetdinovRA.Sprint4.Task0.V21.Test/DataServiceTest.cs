using Tyuiu.ZainetdinovRA.Sprint4.Task0.V21.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int wait = 36;
            int result = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(wait, result);
        }
    }
}
