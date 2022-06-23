using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static calc.TwoArgumentsCalculator;
using static calc.ITwoCalculator;

namespace calc
{

    public partial class Form1 : Form
    {
        public string operation;
        public string firstArgument, secondArgument;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button A = (Button)sender;
            operation = A.Text;
            firstArgument = textBox10.Text;
            secondArgument = textBox11.Text;

            firstNum = Convert.ToDouble(firstArgument);
            secondNum = Convert.ToDouble(secondArgument);

            double calc = Creatror(operation);
            double result = calc;
            if (operation == "Степень")
            {
                if(firstNum < 0)
                {
                    textBox12.Text = "Число должно быть > 0";
                }
            }
            textBox12.Text = result.ToString();
        }
    }
}