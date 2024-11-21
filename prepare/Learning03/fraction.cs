using System;

namespace FractionNamespace
{
    public class Fraction
    {
        private int _numerator;   // Top number
        private int _denominator; // Bottom number

        // Default constructor (1/1)
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor with one parameter (numerator/1)
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor with two parameters (numerator/denominator)
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            _numerator = numerator;
            _denominator = denominator;
        }

        // Getter and setter for numerator
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        // Getter and setter for denominator
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                _denominator = value;
            }
        }

        // Method to return fraction as a string
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method to return decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }
}
