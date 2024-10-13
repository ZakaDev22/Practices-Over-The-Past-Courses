using System;


namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();

            Console.WriteLine(rn.Next(20, 25));
        }
    }
}
