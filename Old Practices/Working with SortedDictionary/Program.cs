using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>
            {
                 { 1, "zaka" },
                { 2, "ali" },
                { 3, "ahmed"}
            };

            foreach (var k in sd)
            {
                Console.WriteLine("The soerted Key : " + k.Value + " Value : " + k.Key);
            }

            Dictionary<int, string> ssd = new Dictionary<int, string>
            {
                 { 1, "zaka" },
                { 2, "ali" },
                { 3, "ahmed"}
            };

            foreach (var k in ssd)
            {
                Console.WriteLine("The soerted Key : " + k.Value + " Value : " + k.Key);
            }


            sd.Add(5, "mohamed");
            sd.Add(4, "hassan");

            ssd.Add(5, "mohamed");
            ssd.Add(4, "hassan");

            foreach (var k in sd)
            {
                Console.WriteLine("The soerted Key : " + k.Value + " Value : " + k.Key);
            }

            foreach (var k in ssd)
            {
                Console.WriteLine("The soerted Key : " + k.Value + " Value : " + k.Key);
            }

            var a = sd.Where(x => x.Value.StartsWith("a"))
                       .OrderByDescending(x => x.Value)
                       .Select(x => x.Key);

            Console.WriteLine("Sorted Key : ");
            foreach (var k in a)
            {
                Console.WriteLine("The soerted Key : " + k);
            }


            Console.ReadKey();
        }
    }
}
