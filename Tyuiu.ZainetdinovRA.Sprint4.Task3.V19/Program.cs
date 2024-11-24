using System.Text;
using Tyuiu.ZainetdinovRA.Sprint4.Task3.V19.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task3.V19
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arr = new int[,] { { 6, 5, 6, 3, 8 },
                                    {9, 4, 4, 3, 4},
                                    {3, 3, 6, 8, 6},
                                    { 6, 5, 3, 4, 3},
                                    { 9, 3, 5, 3, 7}};
            int result = ds.Calculate(arr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма всех четных элементов матрицы \r\n6, 5, 6, 3, 8,\r\n\r\n9, 4, 4, 3, 4,\r\n\r\n3, 3, 6, 8, 6,\r\n\r\n6, 5, 3, 4, 3,\r\n\r\n9, 3, 5, 3, 7, равна {result}");
        }
    }
}
