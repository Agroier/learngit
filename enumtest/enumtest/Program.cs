using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumtest
{
        enum orientation :byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4

    }
    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equvalent = {directionString}");
            Console.ReadKey();
        }
    }
}
