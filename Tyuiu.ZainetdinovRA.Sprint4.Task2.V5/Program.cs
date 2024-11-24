using Tyuiu.ZainetdinovRA.Sprint4.Task2.V5.Lib;
using System.Text;

namespace Tyuiu.ZainetdinovRA.Sprint4.Task2.V5
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
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* лучайными в диапазоне от 3 до 9 подсчитать произведение четных          *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();

            int count = 14;
            int[] numbers = new int[count];
            int result = 1;
            bool hasEven = false;

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(3, 10);
            }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result *= num;
                    hasEven = true;
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            if (hasEven)
            {
                Console.WriteLine($"Сумма всех четных чисел массива {string.Join(", ", numbers)} равна {result}");
            }
            else
            {
                Console.WriteLine("В массиве нет четных чисел");
            }
        }
    }
}
