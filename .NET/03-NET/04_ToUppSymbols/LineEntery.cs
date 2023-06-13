using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class LineEntery
    {
        public static string ToUpperEnterySymvols(string str, char sym)
        {
            StringBuilder stringBuilder = new StringBuilder(str);

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == sym)
                    stringBuilder[i] = char.ToUpper(sym);
            }

            return stringBuilder.ToString();
        }

        public static string CutFromTheLastEntrance(string str, char sym)
        {
            int lastIndex = str.LastIndexOf(sym);

            if (lastIndex != -1)
            {
                return str.Substring(0, lastIndex);
            }
            else
            {
                return str;
            }
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
