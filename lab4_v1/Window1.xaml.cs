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
using System.Windows.Shapes;





namespace lab4_v1
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Student student;

        public Window1(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                tb1.Text = student.imie;
                tb2.Text = student.nazwisko;
                tb3.Text = student.id.ToString();
                tb4.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAddStud_clicked(object sender, RoutedEventArgs e)
        {
           
            student.imie = tb1.Text;
            student.nazwisko = tb2.Text;
            student.id = int.Parse(tb3.Text);
            student.wydzial = tb4.Text;
            this.ShowDialog();
             
        }
    }
}
