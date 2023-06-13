using System;

namespace array
{
    class CompressArray
    {
        static void Main()
        {
            const int oX = 5;
            int length = oX;
            int[] array = new int[oX];

            Random rand = new Random();

            for (int i = 0; i < oX; i++)
            {
                array[i] = rand.Next(0, 5);
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                if (array[i] == 0)
                {
                    length--;
                    for (int j = i; j < length; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[length] = -1;
                    i--;
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
