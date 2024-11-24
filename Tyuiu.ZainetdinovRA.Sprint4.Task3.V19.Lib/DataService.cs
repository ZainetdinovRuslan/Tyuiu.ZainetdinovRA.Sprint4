using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            /* int[,] arr = new int[,] { { 6, 5, 6, 3, 8 },
                                    {9, 4, 4, 3, 4},
                                    {3, 3, 6, 8, 6},
                                    { 6, 5, 3, 4, 3},
                                    { 9, 3, 5, 3, 7}}; */
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
