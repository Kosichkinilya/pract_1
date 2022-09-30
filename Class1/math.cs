using System;
using System.Linq;
using System.Windows.Navigation;

namespace Library_8
{
    public static class MathString
    {
        /// <summary>
        /// Генерируем массив
        /// </summary>
        /// <param name="count"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        public static int[] Mass_Click(int count = 10, int minValue = 0) 
        {
            Random random = new();
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, count);
            }
            return numbers;

        }

        /// <summary>
        /// Находим максимальное значение 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Max_Value_Box(this int[] array)
        {
            int maxValue = array.Max();
            return maxValue; 
        }
    }
}
