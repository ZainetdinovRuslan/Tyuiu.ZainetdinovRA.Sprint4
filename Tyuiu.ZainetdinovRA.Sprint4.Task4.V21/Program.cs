using System.Text;
using Tyuiu.ZainetdinovRA.Sprint4.Task4.V21.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #4 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8. Найдите сумму четных     *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            /* int[,] arr = new int[,] { { 3, 6, 4, 6, 6 },
                                      { 7, 5, 5, 5, 8 },
                                      { 8, 3, 6, 7, 7 },
                                      { 5, 3, 8, 4, 5 },
                                      { 3, 7, 4, 3, 8,} };
            int result = ds.Calculate(arr); */

            int[,] numbers = new int[5,5];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                
            }
            int result = ds.Calculate(numbers);

            Console.WriteLine($"Сумма всех четных элементов матрицы равна {result}");
        }
    }
}
