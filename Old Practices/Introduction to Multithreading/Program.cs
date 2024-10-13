using System;
using System.Net;
using System.Threading;

namespace Introduction_to_Multithreading
{
    internal class Program
    {
        static int Counter = 0;
        static object lockObject = new object();

        static void IncrementCounter(object obj)
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (obj)
                {
                    Counter++;
                }
            }
        }


        static void GetProgrammingAdvicesChar(string url)
        {
            string Content = null;

            using (WebClient webClient = new WebClient())
            {
                Content = webClient.DownloadString(url);
            }

            Console.WriteLine($" Programming Advices Characters Number : {Content.Length} ");
        }

        static void Main(string[] args)
        {

            Thread t = new Thread(() => Method1("Zaka1"));

            Thread t2 = new Thread(() => Method2("Zaka2"));


            Thread t3 = new Thread(() => GetProgrammingAdvicesChar("https://programmingadvices.com/"));
            t3.Start();
            t3.Join();

            t.Start();

            t2.Start();

            // Make The Main Function With  The Threads to Finish There Jobs 

            t.Join();
            t2.Join();



            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(500);

            }

            //
            ///////////////////////////////////
            //

            // Create two threads that increment a shared counter
            Thread t5 = new Thread(() => IncrementCounter(lockObject));
            Thread t4 = new Thread(() => IncrementCounter(lockObject));


            t5.Start();
            t4.Start();


            // Wait for both threads to complete
            t5.Join();
            t4.Join();


            Console.WriteLine("Final Counter Value: " + Counter);

            Console.ReadKey();
        }

        static void Method1(string Name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 : {Name} {i}");
                Thread.Sleep(500);
            }
        }

        static void Method2(string Name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method2 : {Name} {i}");
                Thread.Sleep(500);
            }
        }
    }
}
