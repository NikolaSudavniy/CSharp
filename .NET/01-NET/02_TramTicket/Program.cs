using System;

namespace TramTicket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your tram ticket number (6-digit number):");
            string userInput = Console.ReadLine();

            int ticketNum;

            if (!int.TryParse(userInput, out ticketNum) || userInput.Length != 6)
            {
                Console.WriteLine("Invalid input.Please enter a 6 digit number.");
                return;
            }

            int firstHalfSum = 0;
            int secondHalfSum = 0;

            for (int i = 0; i < userInput.Length / 2; i++)
            {
                firstHalfSum += int.Parse(userInput[i].ToString());
                secondHalfSum += int.Parse(userInput[userInput.Length - 1 - i].ToString());
            }

            if (firstHalfSum == secondHalfSum)
            {
                Console.WriteLine("Hooray! This ticket is lucky!");
            }
            else
            {
                Console.WriteLine("This ticket is not lucky.");
            }
        }
    }
}
