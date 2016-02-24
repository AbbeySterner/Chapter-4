using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //int even = 10;
            //if(even % 2 == 0) Console.WriteLine("EVEN! :D");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
