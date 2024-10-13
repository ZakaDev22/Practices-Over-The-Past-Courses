using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction_to_Asynchronous_Programming
{
    internal class Program
    {
        public delegate void MyDelegate(object sender, clsEventArg e);

        public static event MyDelegate callbackEvent;

        public class clsEventArg : EventArgs
        {
            public int Age { get; set; }

            public string Name { get; set; }

            public clsEventArg(int age, string name)
            {
                this.Age = age;
                this.Name = name;
            }
        }

        static List<string> urls = new List<string>
    {
        "https://www.cnn.com",
        "https://www.amazon.com",
        "https://www.programmingadvices.com"
    };

        static async Task Main()
        {
            //Task<int> ResultTask = PerformAsyncOperation();

            //Console.WriteLine("Doin Some Other Work");

            //int result = await ResultTask;

            //Console.WriteLine("Result : " + result);

            Task task1 = Task.Run(() => DownloedFiles("File 1"));
            Task task2 = Task.Run(() => DownloedFiles("File 2"));
            Thread task3 = new Thread(() => DownloedFiles("File 3"));
            task3.Start();



            callbackEvent += ZakaMethod;
            callbackEvent += SSMethod;

            Task PerformTask = PerformAsyncOparestion(callbackEvent);

            Console.WriteLine("Another Work Start");

            await Task.WhenAll(task1, task2);

            task3.Join();

            Console.WriteLine("All Functions Are Dons Successfully.");

            //
            /////////////////////////////////////
            /////////////////
            ///

            // Define a cancellation token so we can stop the task if needed
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;


            // Create a TaskFactory with some common configuration
            TaskFactory taskFactory = new TaskFactory(
                token,
                TaskCreationOptions.AttachedToParent,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);


            // Use the TaskFactory to create and start a new task
            Task task6 = taskFactory.StartNew(() =>
            {
                Console.WriteLine("Task 1 is running");
                // Simulate some work
                Thread.Sleep(2000);
                Console.WriteLine("Task 1 completed");
            });


            // Create another task using the same TaskFactory
            Task task7 = taskFactory.StartNew(() =>
            {
                Console.WriteLine("Task 2 is running");
                // Simulate some work
                Thread.Sleep(1000);
                Console.WriteLine("Task 2 completed");
            });


            try
            {
                // Wait for both tasks to complete
                Task.WaitAll(task6, task7);
                Console.WriteLine("All tasks completed.");
            }
            catch (AggregateException ae)
            {
                // Handle exceptions if any task throws
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine($"Exception: {e.Message}");
            }


            // Dispose of the CancellationTokenSource
            cts.Dispose();

            // Use Parallel.For to execute the loop in parallel
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
                // Simulate some work
                Task.Delay(500).Wait();
                Thread.Sleep(500);
            });

            Console.WriteLine("All iterations completed.");


            // Use Parallel.ForEach to download the web pages concurrently
            Parallel.ForEach(urls, url =>
            {
                DownloadContent(url);

            });


            Console.WriteLine("Done!");


            // Run the functions in parallel
            Parallel.Invoke(Function1, Function2, Function3);

            //This code executes three actions in parallel. Each action is a lambda expression
            //that prints a message including the ID of the thread it's running on.
            Parallel.Invoke
                (
                  () => Console.WriteLine("Hi Number 4"),
                   () => Console.WriteLine("Hi Number 5"),
                    () => Console.WriteLine("Hi Number 6")
                );


            Console.ReadKey();

        }

        static void Function1()
        {
            Console.WriteLine("Hi Number 1");
        }

        static void Function2()
        {
            Console.WriteLine("Hi Number 2");
        }

        static void Function3()
        {
            Console.WriteLine("Hi Number 3");
        }

        static void DownloadContent(string url)
        {
            string content;


            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                Thread.Sleep(100);


                // Download the content of the web page
                content = client.DownloadString(url);
            }

            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }

        static void DownloedFiles(string fileName)
        {
            Console.WriteLine($"Downloed {fileName} Done");
        }

        static void ZakaMethod(object sender, clsEventArg e)
        {
            Console.WriteLine($"Zaka My Age = {e.Age} ANd My Name = {e.Name}");
        }

        static void SSMethod(object sender, clsEventArg e)
        {
            Console.WriteLine($"SS My Age = {e.Age} ANd My Name = {e.Name}");
        }

        static async Task PerformAsyncOparestion(MyDelegate CalBackEvent)
        {
            await Task.Delay(2000);

            clsEventArg evnt = new clsEventArg(22, "Zaka");

            CalBackEvent?.Invoke(null, evnt);
        }

        static async Task<int> PerformAsyncOperation()
        {
            await Task.Delay(4000);

            return 22;
        }
    }
}
