using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Substracter
    {
        GiveNumbers numbers = new GiveNumbers();

        public double Substraction()
        {
            return numbers.number1 - numbers.number2;
        }
    }
}
