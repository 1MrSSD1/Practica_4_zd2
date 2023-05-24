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

namespace WpfApp80
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a;
            if (int.TryParse(Box1.Text, out a) && a >= 20 && a <= 69)
            {
                Block1.Text = Button_Click(a);
            }
            else
            {
                Block1.Text = "Указанный возраст не входит в диапазоне от 20 до 69";
            }
        }

        private string Button_Click(int a)
        {
            string[] f1 = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] f2 = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят" };
            int g1 = a / 10;
            int g2 = a % 10;
            string v = f2[g1] + (g2 > 0 ? " " + f1[g2] : "");

            if (g2 == 1 && g1 != 1)
            {
                v += " год";
            }
            else
            if (g2 >= 2 && g2 <= 4 && g1 != 1)
            {
                v += " года";
            }
            else
            {
                v += " лет";
            }
            return v;
        }
    }
}
