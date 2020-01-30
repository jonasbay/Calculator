using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DivideException : Exception
    {
        public DivideException()
        {
            Console.WriteLine("You are not allowed to divide by 0!");
        }
    }
}
