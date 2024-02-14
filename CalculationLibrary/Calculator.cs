using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Sub(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multi(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Divid(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
