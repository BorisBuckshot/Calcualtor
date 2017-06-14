using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to add(a), substract(s), divide(d) or multiply(m): ");
            char choice = char.Parse(Console.ReadLine());

            switch (choice)
            {
                case 'A':
                case 'a':
                    {
                        Adder outcome = new Adder();
                        Console.WriteLine("The additions equals to: " + outcome.Addition());
                        break;
                    }

                case 'S':
                case 's':
                    {
                        Substracter outcome = new Substracter();
                        Console.WriteLine("The substraction equals to: " + outcome.Substraction());
                        break;
                    }

                case 'M':
                case 'm':
                    {
                        Multiplier outcome = new Multiplier();
                        Console.WriteLine("The multiplication equals to: " + outcome.Multipliction());
                        break;
                    }

                case 'D':
                case 'd':
                    {
                        Divider outcome = new Divider();
                        Console.WriteLine("The division equals to: " + outcome.Division());
                        break;
                    }
                
                default:
                    break;
            }
        }
    }
}
