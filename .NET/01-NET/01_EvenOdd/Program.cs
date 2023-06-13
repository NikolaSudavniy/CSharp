using System;

namespace EvenOdd
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number from 100 to 100000000:");
            string userInput = Console.ReadLine();

            int userNumber;

            if (!int.TryParse(userInput, out userNumber) || userNumber < 100 || userNumber > 100000000)
            {
                Console.WriteLine("Invalid input. Please enter a number between 100 and 100000000.");
                return;
            }

            int countEven = 0;
            int countOdd = 0;

            foreach (char digit in userInput)
            {
                int num = int.Parse(digit.ToString());

                if (num % 2 == 0)
                    countEven++;
                else
                    countOdd++;
            }

            double evenPercentage = (double)countEven / userInput.Length * 100;
            double oddPercentage = (double)countOdd / userInput.Length * 100;

            Console.WriteLine($"Count of even numbers: {countEven} ({evenPercentage:F2}%)");
            Console.WriteLine($"Count of odd numbers: {countOdd} ({oddPercentage:F2}%)");
        }
    }
}
