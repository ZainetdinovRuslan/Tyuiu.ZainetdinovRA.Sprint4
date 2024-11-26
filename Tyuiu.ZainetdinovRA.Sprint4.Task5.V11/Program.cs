using System.Text;
using Tyuiu.ZainetdinovRA.Sprint4.Task5.V11.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();
            Random random = new Random();

            Console.Title = "Спринт #4 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (Генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2. Заменить положительные    *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-7, 3);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            int[,] modifiedMatrix = ds.Calculate(matrix);

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nИзменённый массив:");
            for (int i = 0; i < modifiedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < modifiedMatrix.GetLength(1); j++)
                {
                    Console.Write($"{modifiedMatrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
