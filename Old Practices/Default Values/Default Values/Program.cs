
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
    internal class Program
    {



        static void Main(string[] args)
        {

            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(c);

            
            Console.WriteLine(i2);
            Console.WriteLine(f2);
            Console.WriteLine(d2);
            Console.WriteLine(b2);
            Console.WriteLine(c2);



            Console.ReadKey();

        }
    }
}

