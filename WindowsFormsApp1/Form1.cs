using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double fValue, sValue;
        char obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "1000-7";
            textBox1.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += button20.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            fValue = Convert.ToDouble(textBox1.Text);
            obj = '+';
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fValue = Convert.ToDouble(textBox1.Text);
            obj = 'x';
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fValue = Convert.ToDouble(textBox1.Text);
            obj = '-';
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fValue = Convert.ToDouble(textBox1.Text);
            obj = '/';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //textBox1.Text += ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sValue = Convert.ToDouble(textBox1.Text);

            switch(obj)
            {
                case '+':
                    textBox1.Text = Convert.ToString(fValue + sValue);
                    break;
                case 'x':
                    textBox1.Text = Convert.ToString(fValue * sValue);
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(fValue - sValue);
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(fValue / sValue);
                    break;
                default:
                    break;
            }
        }
    }
}
