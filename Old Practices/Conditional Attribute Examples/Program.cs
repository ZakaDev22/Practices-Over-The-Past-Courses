
//#define DEBUG

using System;
using System.Diagnostics;


namespace Conditional_Attribute_Examples
{
    [Serializable]
    internal class Program
    {
        [Conditional("DEBUG")]
        public static void LogTrac(string Message)
        {
            Console.WriteLine($"[Trac1] {Message}");     
        }

        public static void LogTrac2(string Message)
        {
            Console.WriteLine($"[Trac2] {Message}");
        }

        [Obsolete("This method Will Be Debrecate In The future")]
        public static void ObsoletMethod()
        {
            Console.WriteLine("Hi Im The Best");
        }


        static void Main(string[] args)
        {

            LogTrac("Hi Trac 1");

            LogTrac2("Hi Trac 2");

            ObsoletMethod();

            Console.ReadKey();

        }
    }
}
