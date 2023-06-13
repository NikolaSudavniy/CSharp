using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Work
    {
        static void Main(string[] args)
        {
            string userStr = string.Empty;
            char userSym = ' ';

            userStr = Console.ReadLine();
            char.TryParse(Console.ReadLine(), out userSym);

            string modifiedStr = LineEntery.ToUpperEnterySymvols(userStr, userSym);
            LineEntery.Print(modifiedStr);

            modifiedStr = LineEntery.CutFromTheLastEntrance(userStr, userSym);
        }
    }
}