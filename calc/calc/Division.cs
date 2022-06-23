using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Операция деления двух чисел

namespace practiceCalc
{
    public partial class DivisionCalculator : ITwoArgumentsCalculator
    {
        public static double firstArgument, secondArgument;
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }

    }
}