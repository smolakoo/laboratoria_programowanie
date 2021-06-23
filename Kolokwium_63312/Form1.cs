using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium_63312
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtn12.Checked | rbtn22.Checked | rbtn32.Checked)
            {
                MessageBox.Show("Zaznaczyłeś ocenę 2.0, nie można obliczyć średniej studenta.");
            }
            else
            {
                double a=0;
                double b=0;
                double c=0;
                
                if(rbtn13.Checked)
                { a = 3; }
                if (rbtn135.Checked)
                { a = 3.5; }
                if (rbtn14.Checked)
                { a = 4; }
                if (rbtn145.Checked)
                { a = 4.5; }
                if (rbtn15.Checked)
                { a = 5; }
                if (rtbn23.Checked)
                { b = 3; }
                if (rbtn235.Checked)
                { b = 3.5; }
                if (rbtn24.Checked)
                { b = 4; }
                if (rbtn245.Checked)
                { b = 4.5; }
                if (rbtn25.Checked)
                { b = 5; }
                if(rtbn33.Checked)
                { c = 3; }
                if (rbtn335.Checked)
                { c = 3.5; }
                if (rbtn34.Checked)
                { c = 4; }
                if (rbtn345.Checked)
                { c = 4.5; }
                if (rbtn35.Checked)
                { c = 5; }
                double avg;
                avg = (a + b + c) / 3;
                textBox4.Text = avg.ToString();
                if (avg > 4.01)
                {
                    textBox5.Text = "Tak.";
                }
                else { textBox5.Text = "Nie."; }

            }
        }

        private void rbtn12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbn23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbn33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(rbtn12);
            groupBox1.Controls.Add(rbtn13);
            groupBox1.Controls.Add(rbtn14);
            groupBox1.Controls.Add(rbtn15);
            groupBox1.Controls.Add(rbtn135);
            groupBox1.Controls.Add(rbtn145);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            groupBox3.Controls.Add(rbtn22);
            groupBox3.Controls.Add(rbtn24);
            groupBox3.Controls.Add(rbtn25);
            groupBox3.Controls.Add(rbtn235);
            groupBox3.Controls.Add(rbtn245);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            groupBox4.Controls.Add(rbtn32);
            groupBox4.Controls.Add(rbtn34);
            groupBox4.Controls.Add(rbtn35);
            groupBox4.Controls.Add(rbtn335);
            groupBox4.Controls.Add(rbtn345);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
