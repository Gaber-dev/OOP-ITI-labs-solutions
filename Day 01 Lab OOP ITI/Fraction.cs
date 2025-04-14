using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Lab_OOP_ITI
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int den) // Constructor
        {
            numerator = num;
            denominator = den;
            
        }

        
        public void Display()
        {
            Console.WriteLine($"{numerator}/{denominator} ");
        }

        public static  Fraction Add(Fraction f1 ,  Fraction f2)
        {
            int commonDenominator = f1.denominator * f2.denominator; // common
            
            int newNumerator1 = f1.numerator * f2.denominator; // X
            int newNumerator2 = f2.numerator * f1.denominator; // X

            int sumNumerator = newNumerator1 + newNumerator2; // +

            return new Fraction(sumNumerator, commonDenominator); // Result
        }

    }
}
