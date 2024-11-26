using Tyuiu.ZainetdinovRA.Sprint4.Task5.V11.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] {
                { 0, 2, 1, 1, -6 },
                { 1, -5, 2, 0, -5 },
                { 1, -3, -6, -7, -7 },
                { -5, 2, -8, 1, 0 },
                { 2, 0, -5, 0, -8 }
            };

            int[,] expected = new int[,] {
                { 0, 1, 1, 1, -6 },
                { 1, -5, 1, 0, -5 },
                { 1, -3, -6, -7, -7 },
                { -5, 1, -8, 1, 0 },
                { 1, 0, -5, 0, -8 }
            };

            int[,] actual = ds.Calculate((int[,])matrix.Clone()); 

            Assert.IsTrue(AreMatricesEqual(expected, actual), "The calculated matrix does not match the expected matrix.");
        }

        private bool AreMatricesEqual(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                return false;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}