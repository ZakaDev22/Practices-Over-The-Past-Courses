using System;
using System.Diagnostics;
using System.Text;

namespace What_is_String_Builder_and_Why
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterator = 300000;

            Stopwatch stopwatch = Stopwatch.StartNew();
            ConcatonationString(iterator);
            stopwatch.Stop();
            Console.WriteLine($"\n\nStarting Concatonation Using a String took = {stopwatch.ElapsedMilliseconds} ms");


            Stopwatch stopwatch2 = Stopwatch.StartNew();
            ConcatonationStringBuilder(iterator);
            stopwatch.Stop();
            Console.WriteLine($"\n\n\nStarting Concatonation Using a StringBuilder took = {stopwatch2.ElapsedMilliseconds} ms");

            Console.ReadKey();

        }

        static void ConcatonationString(int iterator)
        {
            string s1 = "";
            for (int i = 0; i < iterator; i++)
            {
                s1 += "a";
            }
        }

        static void ConcatonationStringBuilder(int iterator)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterator; i++)
            {
                sb.Append("a");
            }
        }
    }



}
