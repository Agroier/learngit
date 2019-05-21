using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace foreachtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Athony ", "Kevin Holton", "Shane Laigle" };
            WriteLine($"Here are {friendNames.Length} of my friend");
            foreach (string friendName in friendNames)
            {
                WriteLine(friendName);
            }
            ReadKey();
        }
    }
}
