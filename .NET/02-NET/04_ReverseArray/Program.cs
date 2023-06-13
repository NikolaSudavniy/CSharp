using System;

namespace array
{
    class reverseArray
    {
        static void Main(string[] args)
        {
            const int oX = 5;
            const int oY = 5;
            int tmp = 0;
            int col1 = 1, col2 = 3;

            int[,] array = new int[oY, oX];

            Random rand = new Random();

            for (int i = 0; i < oY; i++)
            {
                for (int j = 0; j < oX; j++)
                {
                    //array[i, j] = rand.Next(-500, 500);
                    array[i, j] = rand.Next(-10, 10);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < oY; i++)
            {
                tmp = array[i, col1];
                array[i, col1] = array[i, col2];
                array[i, col2] = tmp;
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
