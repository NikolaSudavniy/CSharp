using System;
using System.Text;


namespace palindrome
{
    class StringPalindrom
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string userString = string.Empty;
            userString = Console.ReadLine();
            string noSpaceUserString = userString.Replace(" ", "");


            bool isPalindrome = IsPalindrome(noSpaceUserString);

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            Console.WriteLine();
        }

        static bool IsPalindrome(string str)
        {
            var comparer = StringComparer.CurrentCultureIgnoreCase;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            return comparer.Equals(str, reversedString);
        }
    }
}