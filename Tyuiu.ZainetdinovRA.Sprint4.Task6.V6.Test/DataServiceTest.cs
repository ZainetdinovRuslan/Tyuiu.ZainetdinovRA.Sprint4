using Tyuiu.ZainetdinovRA.Sprint4.Task6.V6.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] data = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] expected = { "Борис", "Ирина" };
            string[] result = ds.Calculate(data);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
