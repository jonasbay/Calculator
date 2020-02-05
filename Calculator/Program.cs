using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program : CalculatorInt
    {
        static void Main(string[] args)
        {
            double res = 0;
            double cal;

            try
            {
                CalculatorInt beregneren = new CalculatorInt();
                res = beregneren.Power(4, 0);
                cal = beregneren.Accumulator;

            }
            catch (DivideException ex)
            {
                Console.WriteLine("Please try again.");
                return;
            }

            // 
            Console.WriteLine("*********************");
            Console.WriteLine($"The result is: {res}");
            Console.WriteLine("*********************");

            Console.WriteLine($"{cal}");

        }
    }
}
