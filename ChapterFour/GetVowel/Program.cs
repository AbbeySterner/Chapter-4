using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a vowel: ");
            String user = Console.ReadLine().ToLower();
            while (user != null)
            {
                if (user == "a" || user == "e" || user == "i" || user == "o" || user == "u")
                    Console.WriteLine("OKAY");
                else
                {
                    Console.WriteLine("ERROR!");
                }
                Console.Write("Type a vowel: ");
                user = Console.ReadLine();
            }
        }
    }
}
