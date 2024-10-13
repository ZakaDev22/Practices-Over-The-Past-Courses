
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

// provides us various methods to use in an array
using System.Linq;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Note that we used System.Linq above.

            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            int[] Ages = { 21, 24 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + numbers.Max());

            Console.WriteLine("The smallest Age : " + Ages.Min());
            Console.WriteLine("The Biggest Age : " + Ages.Max());
            Console.WriteLine("The Average Age : " + Ages.Average());
            Console.WriteLine("The sum Age : " + Ages.Sum());
            Console.WriteLine("count elements : " + Ages.Count());

            Console.ReadKey();

        }
    }
}

