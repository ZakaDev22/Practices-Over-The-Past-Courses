using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_Dictionary_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> MyFriuts = new Dictionary<string, int>();

            MyFriuts.Add("Apple", 100);
            MyFriuts.Add("Banana", 200);
            MyFriuts.Add("Orange", 300);
            MyFriuts.Add("Mango", 400);
            MyFriuts.Add("Pineapple", 500);

            Console.WriteLine("My Friuts Name and Quantity");
            foreach (KeyValuePair<string, int> Fruit in MyFriuts)
            {
                Console.WriteLine($" Fruit Name {Fruit.Key}, Fruit Quantity {Fruit.Value}");
            }


            //MyFriuts.Remove("Mango");

            Console.WriteLine("\n\nNew My Friuts Name and Quantity After Removing Mango");
            foreach (KeyValuePair<string, int> Fruit in MyFriuts)
            {
                Console.WriteLine($" Fruit Name {Fruit.Key}, Fruit Quantity {Fruit.Value}");
            }

            Console.WriteLine($"\n\nIs Orange Present in My Friuts : {MyFriuts.ContainsKey("Orange")}");

            Console.WriteLine($"\n\nMy Friuts Count : {MyFriuts.Count}");

            MyFriuts.Remove("Orange");
            Console.WriteLine($"\n\nIs Orange Present in My Friuts : {MyFriuts.Any(x => x.Key == "Orange")}");

            var pp = MyFriuts.First();
            Console.WriteLine($"\n\nFirst Item in My Friuts : {pp.Key}");
            var pp1 = MyFriuts.Last();
            Console.WriteLine($"\n\nLast Item in My Friuts : {pp1.Key}");

            var pp2 = MyFriuts.First(x => x.Value == 400);
            Console.WriteLine($"\n\nFirst Item in My Friuts with Value 400 : {pp2.Key}");
            var pp3 = MyFriuts.Last(x => x.Value == 500);
            Console.WriteLine($"\n\nLast Item in My Friuts with Value 500 : {pp3.Key}");

            var zz = MyFriuts.FirstOrDefault(x => x.Value == 400);
            Console.WriteLine($"\n\nFirst Item in My Friuts with Value 400 : {zz.Key}");
            var zz1 = MyFriuts.LastOrDefault(x => x.Value == 500);
            Console.WriteLine($"\n\nLast Item in My Friuts with Value 500 : {zz1.Key}");

            Console.WriteLine();
            var FruitInfo = MyFriuts.Select(x => new { x.Key, x.Value });
            foreach (var fruit in FruitInfo)
            {
                Console.WriteLine($"Fruit Name {fruit.Key}, Fruit Quantity {fruit.Value}");
            }

            Console.WriteLine();
            var FilteredFruit = MyFriuts.Where(x => x.Value > 300);
            foreach (var fruit in FilteredFruit)
            {
                Console.WriteLine($"Fruit Name {fruit.Key}, Fruit Quantity {fruit.Value}");
            }

            Console.WriteLine();
            var sortedFruitASC = MyFriuts.OrderBy(x => x.Value);
            foreach (var fruit in sortedFruitASC)
            {
                Console.WriteLine($"Fruit Name {fruit.Key}, Fruit Quantity {fruit.Value}");
            }


            Console.WriteLine();
            var sortedFruitDESC = MyFriuts.OrderByDescending(x => x.Value);
            foreach (var fruit in sortedFruitDESC)
            {
                Console.WriteLine($"Fruit Name {fruit.Key}, Fruit Quantity {fruit.Value}");
            }


            Dictionary<string, int> ZikiDictionary = new Dictionary<string, int>
            {
                { "Ziko", 22},
                {"SS" , 24}

            };

            Console.WriteLine();
            if (ZikiDictionary.TryGetValue("Ziko", out int Age))
            {
                Console.WriteLine($"My Age is {Age}");
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }

            if (ZikiDictionary.TryGetValue("SS", out int Age1))
            {
                Console.WriteLine($"My Age is {Age1}");
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }

            Dictionary<string, string> MyFriuts1 = new Dictionary<string, string>();
            MyFriuts1.Add("Apple", "tree");
            MyFriuts1.Add("Banana", "bush");
            MyFriuts1.Add("Orange", "tree");
            MyFriuts1.Add("Mango", "bush");
            MyFriuts1.Add("Pineapple", "herb");

            var ss = MyFriuts1.GroupBy(x => x.Value)
                              .OrderBy(x => x.Key);

            foreach (var fruit in ss)
            {
                Console.WriteLine($"\n\nCategory: {fruit.Key}");
                foreach (var d in fruit)
                {
                    Console.WriteLine($"-- Fruit Name {d.Key}");
                }
            }

            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Combined LINQ queries
            var sortedFilteredFruits = fruitBasket
                .Where(z => z.Value > 3)
                .OrderBy(x => x.Key)
                .Select(x => x.Value);

            Console.WriteLine("\nSorted and Filtered Fruits:");
            foreach (var fruit in sortedFilteredFruits)
            {
                Console.WriteLine($"Fruit Quantity: {fruit}");
            }

            Console.ReadKey();
        }
    }
}
