using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Divider
    {
        GiveNumbers numbers = new GiveNumbers();

        public double Division()
        {
            return numbers.number1 / numbers.number2;
        }
    }
}
