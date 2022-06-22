using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "Сложение":
                    textBox3.Text = Convert.ToString(a + b);
                    break;
                case "Вычитание":
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case "Умножение":
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case "деление":
                                        if (b == 0)
                    {
                        textBox3.Text = "На ноль делить нельзя";
                    }
                    else
                    {
                        textBox3.Text=Convert.ToString(a/b);
                    }
                    break;
                case "возведение в степень":
                    textBox3.Text=Convert.ToString(Math.Pow(a, b));
                    break;
                case "остаток от деления":
                    textBox3.Text=Convert.ToString(a % b);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
