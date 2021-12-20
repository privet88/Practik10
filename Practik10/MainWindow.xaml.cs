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

namespace Practik10
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
        List<int> list = new List<int>();
        List<int> list1 = new List<int>();
        private void Calculater_Button(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberList1.Text, out int value))
            {
                list.Add(value);
                ListNumber1.Items.Add(value);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Calculater1_Button(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberList2.Text, out int value1))
            {
                list1.Add(value1);
                ListNumber2.Items.Add(value1);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void fill_button(object sender, RoutedEventArgs e)
        {
            int chethik = 0;         
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > list1[i])
                    {
                        chethik++;
                    }
                }
            } 
            chethic.Text = Convert.ToString(chethik);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потакпин. Задание: Заданы два массива. Проверить, сколько элементов первого массива превосходятсоответствующие элементы второго массива.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListNumber1.Items.Clear();
            ListNumber2.Items.Clear();

        }
    }
}
