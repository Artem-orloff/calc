using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Статичныйй класс "Фабрика"

namespace practiceCalc
{
    public static class TwoArgumentsCalculator
    {
        public static double firstArgument, secondArgument;

        // Создание математических экземпляров по условию, на вход принимается знак операции.
        public static double CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "+":
                    AdditionCalculator additionCalculator = new AdditionCalculator();
                    return additionCalculator.Calculate(firstArgument, secondArgument);
                case "-":
                    SubstractCalculator substractCalculator = new SubstractCalculator();
                    return substractCalculator.Calculate(firstArgument, secondArgument);
                case "×":
                    MultiplyCalculator multiplyCalculator = new MultiplyCalculator();
                    return multiplyCalculator.Calculate(firstArgument, secondArgument);
                case "/":
                    DivisionCalculator divisionCalculator = new DivisionCalculator();
                    return divisionCalculator.Calculate(firstArgument, secondArgument);
                case "x^y":
                    ExponentationCalculator exponentationCalculator = new ExponentationCalculator();
                    return exponentationCalculator.Calculate(firstArgument, secondArgument);
                case "x%y":
                    RemainderCalculator remainderCalculator = new RemainderCalculator();
                    return remainderCalculator.Calculate(firstArgument, secondArgument);
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
