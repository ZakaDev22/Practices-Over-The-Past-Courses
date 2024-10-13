using System;


namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter Your Full Name : ");

            string FullName = Console.ReadLine();

            Console.WriteLine("\n\n\t\t My Full Name : " + FullName);

            Console.Write("\n\n Enter Your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n My Age Is : " + Age);

            Console.ReadKey();
        }
    }
}
