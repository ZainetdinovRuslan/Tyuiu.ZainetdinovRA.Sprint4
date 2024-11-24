using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZainetdinovRA.Sprint4.Task0.V21.Lib
{
    public class DataService : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sumOfEvenElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfEvenElements += array[i];
                }
            }
            return sumOfEvenElements;
        }
    }
}
