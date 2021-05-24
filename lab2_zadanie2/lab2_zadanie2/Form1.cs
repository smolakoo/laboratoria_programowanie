using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (rdoSmall.Checked) 
            { 
            Font czcionka = new Font("Times New Roman", 6.0f);
                textBox1.Font = czcionka;
            }
            if (rdoBig.Checked)
            {
                Font czcionka = new Font("Times New Roman", 14.0f);
                textBox1.Font = czcionka;
            }
            if (rdoVBig.Checked)
            {
                Font czcionka = new Font("Times New Roman", 20.0f);
                textBox1.Font = czcionka;
            }
           
            
            if (chkBold.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (chkCurved.Checked) 
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (chkUnderline.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }

            if (chkBold.Checked && chkCurved.Checked && chkUnderline.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            if (chkBold.Checked && chkCurved.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (chkBold.Checked && chkUnderline.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (chkCurved.Checked && chkUnderline.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (rdoRed.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (rdoBlue.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (rdoGreen.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }


        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoBig_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoVBig_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCurved_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
