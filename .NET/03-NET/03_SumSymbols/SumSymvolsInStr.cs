using System.Linq;

namespace String
{
    public class SumSymvolsInStr
    {
        public static int SumAllSymvols(string str) { return str.Length; }
        public static int SumSpaces(string str) { return str.Count(char.IsWhiteSpace); }
        public static int SumNumerals(string str) { return str.Count(char.IsDigit); }
        public static int SumPunctuationSymvols(string str) { return str.Count(char.IsPunctuation); }
        public static int SumUpperSymvols(string str) { return str.Count(char.IsUpper); }
        public static int SumLoverSymvols(string str) { return str.Count(char.IsLower); }
    }
}
