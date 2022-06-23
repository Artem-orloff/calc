using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Операция умножения двух чисел

namespace practiceCalc
{
    public partial class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public static double firstArgument, secondArgument;
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

    }
}