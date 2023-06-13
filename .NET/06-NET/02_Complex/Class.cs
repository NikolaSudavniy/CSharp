using System;
using System.Collections.Generic;
using System.Text;

namespace Complex
{
    using System;

    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(real, imaginary);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            if (denominator == 0)
                throw new DivideByZeroException("Division by zero");

            double real = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator;
            double imaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator;
            return new Complex(real, imaginary);
        }

        public static Complex operator +(Complex c, double n)
        {
            double real = c.Real + n;
            double imaginary = c.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator +(double n, Complex c)
        {
            double real = n + c.Real;
            double imaginary = c.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex c, double n)
        {
            double real = c.Real - n;
            double imaginary = c.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(double n, Complex c)
        {
            double real = n - c.Real;
            double imaginary = -c.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator *(Complex c, double n)
        {
            double real = c.Real * n;
            double imaginary = c.Imaginary * n;
            return new Complex(real, imaginary);
        }

        public static Complex operator *(double n, Complex c)
        {
            double real = n * c.Real;
            double imaginary = n * c.Imaginary;
            return new Complex(real, imaginary);
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", Real, Imaginary);
        }
    }
}
