using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_zad2
{
    public partial class Form1 : Form
    {
        bool startNewNum = true;
        string znak;
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBt_Click("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NumberBt_Click("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NumberBt_Click("3");
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            NumberBt_Click("4");

        }
        private void button5_Click(object sender, EventArgs e)
        {
            NumberBt_Click("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            NumberBt_Click("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            NumberBt_Click("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            NumberBt_Click("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            NumberBt_Click("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            NumberBt_Click("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operacja("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            znak = String.Empty;
            startNewNum = true;
        }

        
        private void NumberBt_Click(string number)
        {
            if (startNewNum == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                startNewNum = false;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Operacja("+");
        }

        private void buttonPomnoz_Click(object sender, EventArgs e)
        {
            Operacja("*");
        }

        private void buttonPodziel_Click(object sender, EventArgs e)
        {
            Operacja("/");
        }

        private void buttonRowne_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "Nie dziel przez 0.";
                    }
                    textBox1.Text = Convert.ToString(num1 / num2);
                    break;
            }
        }

        private void buttonPrzecinek_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',')==-1)
            {
                textBox1.Text += ",";
                startNewNum = false;
            }
        }

        private void Operacja(string znak)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            this.znak = znak;
            startNewNum = true;
        
        }
    
    }


}
