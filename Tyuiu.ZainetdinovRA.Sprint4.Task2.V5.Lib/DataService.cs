using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            Random random = new Random();

            int count = 14;
            int[] numbers = new int[count]; 
            int result = 1;
            /* bool hasEven = false;

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
            } */

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    result *= num;
                }
            }
            return result;
        }
    }
}
