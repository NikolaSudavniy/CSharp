using System;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main()
        {
            var array = new TornArray<int>();

            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add(40);

            Console.WriteLine("Length: " + array.Length);

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            array[1] = 50;

            Console.WriteLine("Changed array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
