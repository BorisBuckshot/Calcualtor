using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class GiveNumbers
    {
        public double number1, number2;

        public GiveNumbers()
        {
            Console.Write("Give me the first number: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Give me the second number: ");
            number2 = double.Parse(Console.ReadLine());
        }




    }
}
