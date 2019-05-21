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
            foreach (string friendName in friendNames)//foreach对数组内容进行只读访问，不能改变数组的值
            {
                WriteLine(friendName);
            }
            ReadKey();
        }
    }
}
