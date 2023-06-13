using System;

namespace stringManipulation
{
    class ChangeString
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string userText = Console.ReadLine();
            Console.WriteLine("Enter substring for search:");
            string searchSubstr = Console.ReadLine();
            Console.WriteLine("Enter substring for change:");
            string cangeSubstr = Console.ReadLine();
            string changedText = changeSubstring(userText, searchSubstr, cangeSubstr);

            Console.WriteLine("Result:");
            Console.WriteLine(changedText);
        }

        static string changeSubstring(string userText, string searchSubstr, string cangeSubstr)
        {
            int index = userText.IndexOf(searchSubstr);
            if (index < 0)
            {
                return userText;
            }

            string changedText = userText.Substring(0, index) + cangeSubstr + userText.Substring(index + searchSubstr.Length);
            return changeSubstring(changedText, searchSubstr, cangeSubstr);
        }
    }
}