using System;

namespace Fraction
{
    public class Program
    {
        public static void Main()
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + (Fraction)d;

            Console.WriteLine("f: " + f +
                              "\nf1: " + f1 +
                              "\nf2: " + f2 +
                              "\nf3: " + f3.ToString() +
                              $"\nf < f1: {f < f1}" +
                              $"\nf1 > f2: {f1 > f2}" +
                              $"\nf == f2: {f == f2}" +
                              $"\nf != f3: {f != f3}");
            f3.Simplify();
            Console.WriteLine("f3 simplifyed: " + f3);
        }
    }
}
