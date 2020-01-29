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
            CalculatorInt beregneren = new CalculatorInt();
            double res = beregneren.Power(2, 2);

            Console.WriteLine("*********************");
            Console.WriteLine($"The result is: {res}");
            Console.WriteLine("*********************");
        }
    }
}
