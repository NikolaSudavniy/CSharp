using System;

namespace String
{
    class Work
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sumSpaces = 0;
            int sumNums = 0;
            int sumPunctuation = 0;
            int sumUpper = 0;
            int sumLover = 0;

            string userStr = string.Empty;
            userStr = Console.ReadLine();

            sum = SumSymvolsInStr.SumAllSymvols(userStr);
            sumSpaces = SumSymvolsInStr.SumSpaces(userStr);
            sumNums = SumSymvolsInStr.SumNumerals(userStr);
            sumPunctuation = SumSymvolsInStr.SumPunctuationSymvols(userStr);
            sumUpper = SumSymvolsInStr.SumUpperSymvols(userStr);
            sumLover = SumSymvolsInStr.SumLoverSymvols(userStr);

            Console.WriteLine($"Sum all symvols: {sum}, Sum spaces: {sumSpaces}, Sum numerals: {sumNums}");
            Console.WriteLine($"Sum punctuation: {sumPunctuation}, Sum upper: {sumUpper}, Sum lover: {sumLover}");
            Console.WriteLine();
        }
    }
}
