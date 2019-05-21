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
            string[] friendNames = { "Todd Athony ", "Kevin Holton", "Shane Laigle",null,"" };

            foreach (var friendName in friendNames)//foreach对数组内容进行只读访问，不能改变数组的值
            {
                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine("This friends name starts with a 'T' :" + $"{friendName} and is {t.Length - 1} letters long");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case null:
                        WriteLine("There was a 'null' value in the array");
                        break;
                    case var x:
                        WriteLine("This is the var pattern of type :" + $"{x.GetType().Name}");
                        break;
                    default:
                        break;
                }
            }
                int sum =0, total = 0,counter = 0 ,intValue = 0;
                int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };//问好旨在让编译器知道这个int[]数组可包含空对象，若没有这个问号，就会显示编译异常。
                foreach (var integer in myIntArray)
                {
                    switch (integer)
                    {
                        case 0:
                            WriteLine($"Integer number '{counter}' has a default value of 0");
                            counter++;
                            break;
                        case int value:
                            sum += value;
                            WriteLine($"Integer number '{counter}' has a value of {value}");
                            counter++;
                            break;
                        case null:
                            WriteLine($"Integer number '{counter}' is null");
                            counter++;
                            break;
                        default:
                            break;

                    }
                }
            total = counter;
                WriteLine($"{total} total integer ,{counter} integer with a " + $"value other than 0 or null have a sum value of {sum}");
                ReadLine();
            
        }
    }
}
