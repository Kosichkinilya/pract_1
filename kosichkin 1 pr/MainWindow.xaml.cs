using Library_8;
using System.Windows;


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

        public bool flag = false; // глобальная переменная
        public int[] numbers; // глобальный массив 
     
        private void Mass_Click(object sender, RoutedEventArgs e) // Генерируем массив 
        {

            numbers = MathString.Mass_Click(10, 2);
            Mass_Created_Box.Text = string.Join(" ", numbers);
            flag = true;
        }

        private void MaxValue_Click(object sender, RoutedEventArgs e) //  
        {
            if (flag == true) Mass_Changed_Box.Text = string.Join(" ", numbers.Max_Value_Box());
            else MessageBox.Show("Необходмо создать массив");
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
        }

        private void Reset_Click(object sender, RoutedEventArgs e) // сброс тексбокса
        {
            Mass_Created_Box.Clear();
            Mass_Changed_Box.Clear();
        }
    }
}
