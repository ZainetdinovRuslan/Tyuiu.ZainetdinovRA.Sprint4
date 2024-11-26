using System.Text;
using Tyuiu.ZainetdinovRA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task7.V15
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"10293847\". Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = 4;
            int columns = 2;
            string value = "10293847";
            int result = ds.Calculate(rows, columns, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Количество нечетных чисел в матрице: {result}");
        }
    }
}
