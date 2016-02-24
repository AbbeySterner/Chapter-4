using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum += user;
            while (user != 999)
            {
                user = Convert.ToInt32(Console.ReadLine());
                sum += user;
                
            }
            Console.WriteLine(sum-999);
        }
    }
}
