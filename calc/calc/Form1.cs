using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static practiceCalc.TwoArgumentsCalculator;
using static practiceCalc.ITwoArgumentsCalculator;

namespace practiceCalc
{

    public partial class Form1 : Form
    {
        public string operation;
        public string x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия на кнопку, конвертирование кнопки в текст.
            Button A = (Button)sender;
            operation = A.Text;
            x = textBox1.Text;
            y = textBox2.Text;
            // Конвертирование текста в числовые значения
            firstArgument = Convert.ToDouble(x);
            secondArgument = Convert.ToDouble(y);

            // Вызов фабрики и запись результата вычислений в переменную
            double calc = CreateCalculator(operation);
            double result = calc;
            if (operation == "x^y")
            {
                if (firstArgument < 0)
                {
                    textBox3.Text = "X must be > 0";
                }
            }
            // Вывод результата в виде строки
            textBox3.Text = result.ToString();
        }
    }
}