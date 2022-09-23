using System;
using System.Windows.Navigation;

namespace Lib_1
{
    public static class Math
    {
        public static int[] Create_Click(int count = 10, int minValue = 0) // Генерируем массив но не выводим 
        {
            Random random = new();
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, count);
            }
            return numbers;
        }

        public static double SignSquare(int[] numbers) // вычисляем корень и возводим в квадрат, но пока не выводим 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    System.Math.Sqrt(numbers[i]);

                }

                if (numbers[i] < 0)
                {
                    System.Math.Pow(numbers[i], 2);
                }
            }
            return numbers.Length;


        }   

    }
}
