using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRateLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hourly Pay-rate: ");
            double user = Convert.ToDouble(Console.ReadLine());

            while (user < 5.65 || user > 49.99)
            {
                Console.Write("Enter your hourly Pay-rate: ");
                user = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
