﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float wagaStd;
            try
            {
                
                float x = float.Parse(textBox1.Text);
                if (checkBox2.Checked) 
                {
                    
                    wagaStd = (x - 100);
                    textBox2.Text=wagaStd.ToString();
                    
                }

                if (checkBox1.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        wagaStd = (x - 100);
                        textBox2.Text = (wagaStd * 0.85).ToString();
                    }
                    else 
                    {
                        wagaStd = (x - 100);
                        textBox2.Text = (wagaStd * 0.9).ToString();
                    }
                    
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak.");            
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
