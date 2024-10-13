using System;

using MyClassLibrary;

namespace TestMyFirstClassLibary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi By :-)");
            
            Console.WriteLine(MyMath.Sum(21, 24));

            Console.WriteLine(MyMath.Sum(21, 24,45));

            Console.ReadKey();
        }
    }
}
