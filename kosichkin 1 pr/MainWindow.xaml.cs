using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kosichkin_1_pr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool flag = false;
        public int[]? numbers;

        private void Mass_Click(object sender, RoutedEventArgs e) // Генерируем массив 
        {
           
        }

        private void SQRT_Click(object sender, RoutedEventArgs e) // квадратный корень 
        {
            
        }

        private void POW_Click(object sender, RoutedEventArgs e) // возведенние в квадрат 
        {

        }
        private void Exit_Click(object sender, RoutedEventArgs e) //Выход
        {
            Close();
        }


        private void Info_Click(object sender, RoutedEventArgs e) // Информация о приложении
        {
            MessageBox.Show
                ("Сгенерировать массив заполненный случайными целыми числами," +
                "\r\n распределенных в диапазоне от 0 до count," +
                "\r\n где count - количество чисел в массиве." +
                "\r\n Найти максимальное значение." +
                "\r\n Вывести на экран на одной строке сгенерированные числа," +
                "\r\n на другой строке результат." +
                "\r\n В классе реализовать статический метод с именем Max.",
                "\r\n Выполнил Косичкин Илья. Вариант 8");

            // Сгенерировать массив заполненный случайными целыми числами, распределенных  диапазоне от -10 до 2.
            // Вычислить для чисел > 0 извлечь корень, а для чисел < 0 возвести квадрат.
            // На экран необходимо выводить сгенерированные числа и результат расчета
            // функции на разных строках.В классе реализовать статический метод с именем SignSquare.

        }

    }
}
