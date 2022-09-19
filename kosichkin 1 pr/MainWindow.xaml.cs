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

        private void Exit_Click(object sender, RoutedEventArgs e) //Выход
        {
            Close();
        }

        private void Mass_Click(object sender, RoutedEventArgs e) // Генерируем массив 
        {

            double[] array = new double[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-5, 5) + rand.NextDouble();
            
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
        }
    }
}
