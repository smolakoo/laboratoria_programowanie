using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_v1
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int id { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int id, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id = id;
            this.wydzial = wydzial;
        }
        public Student()
        : this("", "", 0, "")
        { }
    }
 }
