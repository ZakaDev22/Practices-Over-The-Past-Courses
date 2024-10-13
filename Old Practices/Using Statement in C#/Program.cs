using System;


using Koko = System.Console;

using static System.Math;

namespace Using_Statement_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Koko.WriteLine("Zaka the best");

            double MyFolwers = Math.Round(8.6);

            Koko.WriteLine($"My CurrentFollowers in LinkedIn Is {MyFolwers}K");

            Koko.ReadKey();

        }
    }
}
