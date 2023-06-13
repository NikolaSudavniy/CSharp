using System;

namespace array
{
    class sortByValue
    {
        static void Main()
        {
            const int oX = 5;
            int count_negative = 0;
            int[] array = new int[oX];

            Random rand = new Random();

            for (int i = 0; i < oX; i++)
            {
                array[i] = rand.Next(-5, 5);
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();

            for (int i = 0; i < oX; i++)
            {
                if (array[i] < 0)
                {
                    int b = array[i];
                    array[i] = array[count_negative];
                    array[count_negative++] = b;
                }
            }

            for (int i = 0; i < oX; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
