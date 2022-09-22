using System;
using System.Windows.Navigation;

namespace Lib_1
{
    public static class math
    {
        public static int ArrayCreate(int[] numbers) // Генерируем массив но не выводим 
        {
            Random rnd = new();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-10, 2);

            }
            return numbers.Length;
        }

        public static double SignSquare(int[] numbers) // вычисляем корень и возводим в квадрат, но пока не выводим 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Math.Sqrt(numbers[i]);

                }

                if (numbers[i] < 0)
                {
                    Math.Pow(numbers[i], 2);
                }
            }
            return numbers.Length;
        }   

    }
}
