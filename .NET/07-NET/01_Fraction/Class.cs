using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator != 0)
            {
                this.denominator = denominator;
            }
            else
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numerator = a.numerator * (lcm / a.denominator) + b.numerator * (lcm / b.denominator);
            return new Fraction(numerator, lcm);
        }

        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a.numerator * b, a.denominator);
        }

        public static Fraction operator *(int a, Fraction b)
        {
            return b * a;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numerator = a.numerator * (lcm / a.denominator) - b.numerator * (lcm / b.denominator);
            return new Fraction(numerator, lcm);
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numeratorA = a.numerator * (lcm / a.denominator);
            int numeratorB = b.numerator * (lcm / b.denominator);
            return numeratorA < numeratorB;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numeratorA = a.numerator * (lcm / a.denominator);
            int numeratorB = b.numerator * (lcm / b.denominator);
            return numeratorA > numeratorB;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numeratorA = a.numerator * (lcm / a.denominator);
            int numeratorB = b.numerator * (lcm / b.denominator);
            return numeratorA == numeratorB;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            int lcm = LCM(a.denominator, b.denominator);
            int numeratorA = a.numerator * (lcm / a.denominator);
            int numeratorB = b.numerator * (lcm / b.denominator);
            return numeratorA != numeratorB;
        }

        public static implicit operator Fraction(double d)
        {
            int numerator = (int)(d * 10);
            int denominator = 10;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        public void Simplify()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        private static int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }
    }
}