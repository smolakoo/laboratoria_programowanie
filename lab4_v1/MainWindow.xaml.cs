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

namespace lab4_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public List<Student> Lista { get; set; }
        
        public MainWindow()
        {
            Lista = new List<Student>()
            {
                new Student(){imie="Jan", nazwisko="Kowalski", id=1234, wydzial="INF"},
                new Student(){imie="Adam", nazwisko="Nowak", id=3521, wydzial="INF"},
                new Student(){imie="Katarzyna", nazwisko="Nowakowska", id=6422, wydzial="INF"},
            };
            
            InitializeComponent();

            dgStudenci.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie")});
            dgStudenci.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudenci.Columns.Add(new DataGridTextColumn() { Header = "Id studenta", Binding = new Binding("id") });
            dgStudenci.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial") });
            dgStudenci.AutoGenerateColumns = false;
            dgStudenci.ItemsSource = Lista;
        }

        private void btnAdd_clicked(object sender, RoutedEventArgs e)
        {
            var dialog = new Window1();
            if (dialog.ShowDialog() == true)
            {
                Lista.Add(dialog.student);
                dgStudenci.Items.Refresh();
            }
        }

        private void btnRmv_clicked(object sender, RoutedEventArgs e)
        {
            if (dgStudenci.SelectedItem is Student)
            {
                Lista.Remove((Student)dgStudenci.SelectedItem);
                dgStudenci.Items.Refresh();
            }

        }
    }
}
