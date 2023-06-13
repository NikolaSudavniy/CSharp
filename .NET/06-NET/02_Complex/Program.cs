using System;

namespace Complex
{
    public class Program
    {
        public static void Main()
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - ((z * z * z) - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
}
