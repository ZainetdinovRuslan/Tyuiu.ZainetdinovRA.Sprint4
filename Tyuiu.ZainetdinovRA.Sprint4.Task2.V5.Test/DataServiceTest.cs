using Tyuiu.ZainetdinovRA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numbers = new int[] { 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6, 4, 7, 3 };
            int wait = 1;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    wait *= num;
                }
            }

            int result = ds.Calculate(numbers);
            Assert.AreEqual(wait, 18432);
        }
    }
}
