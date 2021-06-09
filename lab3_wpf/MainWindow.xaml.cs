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

namespace lab3_wpf
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

        float a;
        float b;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             a = float.Parse(tb1.Text);
             b = float.Parse(tb2.Text);
             float suma = a + b;
             tb3.Text = ("Suma wynosi: ")+ suma.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            b = float.Parse(tb2.Text);
            if (b==0)
            {
                tb3.Text = "Nie można podzielić przez 0!";
            }
            else
            {
                float iloraz = a / b;
                tb3.Text = ("Iloraz wynosi: ") + iloraz.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            b = float.Parse(tb2.Text);
            float roznica = a - b;
            tb3.Text = ("Różnica wynosi: ") + roznica.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            b = float.Parse(tb2.Text);
            float iloczyn = a * b;
            tb3.Text = ("Iloczyn wynosi: ") + iloczyn.ToString();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
