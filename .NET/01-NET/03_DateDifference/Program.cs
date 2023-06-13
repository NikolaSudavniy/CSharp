using System;

namespace DateDifference
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter date of your birthday (format DD.MM.YYYY):");
            string userBrthInput = Console.ReadLine();
            Console.WriteLine("Enter the current date (format DD.MM.YYYY):");
            string currentInput = Console.ReadLine();

            DateTime birthday;
            DateTime current;

            if (!DateTime.TryParseExact(userBrthInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthday) ||
                !DateTime.TryParseExact(currentInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out current))
            {
                Console.WriteLine("Invalid input. Please use the format DD.MM.YYYY to enter the date.");
                return;
            }

            TimeSpan diff = current.Date - birthday.Date;
            int daysDiff = diff.Days;

            Console.WriteLine($"Difference between date of birth and current date: { daysDiff} days.");
        }
    }
}
