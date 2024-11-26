using Tyuiu.ZainetdinovRA.Sprint4.Task4.V21.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace Tyuiu.ZainetdinovRA.Sprint4.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] arr = { { 0, 1, 2, 2, -6 },
                           { -3, -5, 1, 0, 2 },
                           { 0, 2, 1, -7, -7 },
                           { -5, 0, -8, -4, -5 },
                           { 1, 0, 2, 2, -8 } };

            int[,] expected = { { 0, 1, 1, 1, -6 },
                                { -3, -5, 1, 0, 1 },
                                { 0, 1, 1, -7, -7 },
                                { -5, 0, -8, -4, -5 },
                                { 1, 0, 1, 1, -8 } };

            int[,] result = ds.Calculate(arr);
            AssertMatrixEqual(expected, result);
        }
        private void AssertMatrixEqual(int[,] expected, int[,] actual)
        {
            Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), actual.GetLength(1));

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0;  j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i,j], actual[i, j]);
                }
            }

        }

    }
}
