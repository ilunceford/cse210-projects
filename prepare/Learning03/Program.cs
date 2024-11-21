using System;
using FractionNamespace;

namespace FractionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor (1/1)
            Fraction frac1 = new Fraction();
            Console.WriteLine(frac1.GetFractionString());
            Console.WriteLine(frac1.GetDecimalValue());

            // Using constructor with one parameter (5/1)
            Fraction frac2 = new Fraction(5);
            Console.WriteLine(frac2.GetFractionString());
            Console.WriteLine(frac2.GetDecimalValue());

            // Using constructor with two parameters (3/4)
            Fraction frac3 = new Fraction(3, 4);
            Console.WriteLine(frac3.GetFractionString());
            Console.WriteLine(frac3.GetDecimalValue());

            // Using constructor with two parameters (1/3)
            Fraction frac4 = new Fraction(1, 3);
            Console.WriteLine(frac4.GetFractionString());
            Console.WriteLine(frac4.GetDecimalValue());

            // Testing setters and getters
            frac4.Numerator = 7;
            frac4.Denominator = 8;
            Console.WriteLine(frac4.GetFractionString()); // Should print 7/8
            Console.WriteLine(frac4.GetDecimalValue());  // Should print 0.875
        }
    }
}
