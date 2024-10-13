

using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 21;
            int s = 24;

            var ss = 24.9;

            Console.WriteLine("\t z = " + z);
            Console.WriteLine("\t s = {0} ", s);

            Console.WriteLine("\t z + s = " + (z + s));

            string MyName = "\t The Wolf ";

            Console.WriteLine(MyName);

            double Salary = 21.7;

            bool ImStillYoung = true;

            //Console.WriteLine("{0} {1}", "Welcome To", "Programming Advices");
            //Console.WriteLine("My NAme Is {0} , I Live In {1} ", "The Wolf", " Morocco");

            Console.ReadKey();
        }
    }
}
