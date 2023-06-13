using System;

namespace switzerland
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int sizeOfFlag = random.Next(21, 42);
            int flagBorder = 1;
            int flagCross = sizeOfFlag / 5;

            for (int col = 0; col < sizeOfFlag; col++)
            {
                for (int row = 0; row < sizeOfFlag; row++)
                {
                    bool isBorder = row < flagBorder || row >= sizeOfFlag - flagBorder ||
                                         col < flagBorder || col >= sizeOfFlag - flagBorder;

                    bool isCross = row >= (sizeOfFlag - flagCross) / 2 && row < (sizeOfFlag + flagCross) / 2 ||
                                        col >= (sizeOfFlag - flagCross) / 2 && col < (sizeOfFlag + flagCross) / 2;

                    if (isBorder)
                    {
                        Console.Write("*");
                    }
                    else if (isCross)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
