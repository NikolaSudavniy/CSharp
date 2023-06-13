using System;

namespace array
{
    class SortArray
    {
        static void Main()
        {
            const int oX = 5;
            const int oY = 5;
            int[,] array = new int[oY, oX];
            int[] sum_array = new int[oX];
            int tmp;

            Random rand = new Random();

            for (int i = 0; i < oY; i++)
            {
                for (int j = 0; j < oX; j++)
                {
                    //array[i, j] = rand.Next(-500, 500);
                    array[i, j] = rand.Next(0, 5);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < oY; i++)
            {
                for (var j = 0; j < oX; j++)
                {
                    sum_array[j] += array[i, j];
                }
            }
            Console.WriteLine();

            for (int i = 0; i < oY; i++)
            {
                Console.Write($"{sum_array[i]}\t");
            }
            Console.WriteLine();

            for (int i = 0; i < oX; i++)
            {
                for (int j = 0; j < oX - 1; j++)
                {
                    if (sum_array[j + 1] < sum_array[j])
                    {
                        tmp = sum_array[j + 1];
                        sum_array[j + 1] = sum_array[j];
                        sum_array[j] = tmp;

                        for (var x = 0; x < oY; x++)
                        {
                            tmp = array[x, j + 1];
                            array[x, j + 1] = array[x, j];
                            array[x, j] = tmp;
                        }
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < oY; i++)
            {
                for (int j = 0; j < oX; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
