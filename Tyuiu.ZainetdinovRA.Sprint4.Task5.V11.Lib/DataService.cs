using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] result = new int[rows, columns]; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        result[i, j] = 1; 
                    }
                    else
                    {
                        result[i, j] = matrix[i, j];
                    }
                }
            }

            return result;
        }
    }
}
