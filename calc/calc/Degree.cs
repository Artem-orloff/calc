using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Degree : ITwoCalculator
    {
        public double Calculate(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
