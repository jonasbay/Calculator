using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculatorInt
    {
        double Add(double a, double b);
        double Add(double a);
        double Subtract(double a, double b);
        double Subtract(double a);
        double Multiply(double a, double b);
        double Multiply(double a);
        double Power(double x, double exp);
        double Divide(double dividend, double divisor);
        double Divide(double a);
        void clear();
    }
}
