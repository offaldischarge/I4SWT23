using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExercise
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                //throw new System.DivideByZeroException();
            }
            return dividend / divisor;
        }
    }

    class Program
    {
        static void Main()
        {
            var calc = new Calculator();

            double result;

            result = calc.Add(3.5,5.3);

            Console.WriteLine($"Result of addition: {result}");

            result = calc.Subtract(0.5, 9.8);

            Console.WriteLine($"Result of Subtraction: {result}");

            result = calc.Multiply(4, 9.99);

            Console.WriteLine($"Result of Multiplication: {result}");

            result = calc.Power(2, 12);

            Console.WriteLine($"Result of Power: {result}");
        }
    }
}
