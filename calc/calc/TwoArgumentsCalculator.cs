using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    static class TwoArgumentsCalculator
    {
        public static double firstNum, secondNum;
        public static double Creatror(string calculatorName)

        {
            switch (calculatorName)
            {
                case "Сложение":
                    Addition addition = new Addition();
                    return addition.Calculate(firstNum, secondNum);

                case "Вычитание":
                    Subtraction subtraction = new Subtraction();
                    return subtraction.Calculate(firstNum, secondNum);

                case "Умножение":
                    Multiplication multiplication = new Multiplication();
                    return multiplication.Calculate(firstNum, secondNum);

                case "Деление":
                    Division division = new Division();
                    return division.Calculate(firstNum, secondNum);

                case "Степень":
                    Degree degree = new Degree();
                    return degree.Calculate(firstNum, secondNum);

                case "Остаток от деления":
                    Remainder remainder = new Remainder();
                    return remainder.Calculate(firstNum, secondNum);

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
