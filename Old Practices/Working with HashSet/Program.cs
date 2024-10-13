using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("One");
            set.Add("Two");
            set.Add("Three");
            set.Add("Four");
            set.Add("Five");

            set.Add("One");

            foreach (string set2 in set)
            {
                Console.WriteLine(set2);
            }

            Console.WriteLine($"\n {set.Contains("One")} and {set.Any(x => x == "One")} ");

            Console.WriteLine($"\nMy Hash Set Count : {set.Count}");

            set.RemoveWhere(x => x == "Four");

            Console.WriteLine($"\nMy Hash Set Count : {set.Count}");
            foreach (string set2 in set)
            {
                Console.WriteLine(set2);
            }

            int[] arr = { 1, 2, 3, 3, 4, 5, 4, 5 };

            HashSet<int> ints = new HashSet<int>(arr);

            var set3 = ints.Where(x => x > 2 && x < 5);

            Console.WriteLine();
            foreach (var item in set3)
            {
                Console.WriteLine(item);
            }

            HashSet<string> Names = new HashSet<string> { "Ahmed", "Mohamed", "Ali", "Zakaria", "ZSsiya", "Ziko" };

            // Using LINQ to filter names that start with 'C'
            var namesStartingWithC = Names.Where(name => name.StartsWith("C"));

            var NamesStartWithZZ = Names.Where(x => x.StartsWith("Z") && x.EndsWith("a"))
                                        .OrderByDescending(x => x[1] == 'a');

            Console.WriteLine("\n");
            foreach (string item in NamesStartWithZZ)
            {

                Console.WriteLine(item);
            }


            HashSet<int> Numbers2 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 21, 22, 23, 23, 25 };
            HashSet<int> Numbers3 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            HashSet<int> Numbers4 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("\n\n Numbers 3 Befor");
            foreach (int item in Numbers3)
            { Console.WriteLine(item); }

            Numbers3.UnionWith(Numbers4);

            Console.WriteLine("\n\n Number 3 After Union with 4");
            foreach (int item in Numbers3)
            { Console.WriteLine(item); }



            Numbers2.UnionWith(Numbers3);

            var NumbersOrderByDesc = Numbers2.OrderBy(x => x);

            Console.WriteLine("\n\n Number 2 After Union with 3");
            foreach (int item in NumbersOrderByDesc)
            {
                Console.WriteLine(item);
            }

            HashSet<int> Numbers5 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            HashSet<int> Numbers6 = new HashSet<int> { 2, 3, 6, 7, 8, 9, 10, 11, 12, 21, 22 };

            Numbers5.SymmetricExceptWith(Numbers6);

            Console.WriteLine("\n\n Number 5 After SymmetricExceptWith with 6");
            foreach (int item in Numbers5)
            {
                Console.WriteLine(item);
            }

            var IntersectionNumbersBetween2And3 = Numbers5.Intersect(Numbers6);

            Console.WriteLine("\n\n Number 5 After Intersect with 6");
            foreach (int item in IntersectionNumbersBetween2And3)
            {
                Console.WriteLine(item);
            }

            Numbers5.IntersectWith(Numbers6);

            Console.WriteLine("\n\n Number 5 After Intersect with 6");
            foreach (int item in IntersectionNumbersBetween2And3)
            {
                Console.WriteLine(item);
            }

            Numbers6.ExceptWith(Numbers5);

            Console.WriteLine("\n\n Number 6 After Except with 5");
            foreach (int item in Numbers6)
            {
                Console.WriteLine(item);
            }

            HashSet<int> Numbers7 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            HashSet<int> Numbers8 = new HashSet<int> { 2, 3, 6, 7, 8, 9, 10, 11, 12, 21, 22 };
            HashSet<int> Numbers9 = new HashSet<int> { 2, 3, 6, 7, 8, 9, 10, 11, 12, 21, 22 };
            HashSet<int> Numbers10 = new HashSet<int> { 1, 2, 3 };

            Console.WriteLine("\n Is Set 7 Equals to Set 8 :" + Numbers7.SetEquals(Numbers8));

            Console.WriteLine("\n Is Set 8 Equals to Set 9 :" + Numbers8.SetEquals(Numbers9));

            Console.WriteLine("\n Is set 7 Is Sub Set OF Set 8 : " + Numbers7.IsSubsetOf(Numbers8));

            Console.WriteLine("\n Is set 8 Is Sub Set OF Set 7 : " + Numbers8.IsSubsetOf(Numbers7));

            Console.WriteLine("\n Is set 10 Is Sub Set OF Set 7 : " + Numbers10.IsSubsetOf(Numbers7));

            Console.WriteLine("\n Is Set 7 Is Sub Set For Set 10 " + Numbers7.IsSupersetOf(Numbers10));

            Console.WriteLine("\n Is Set 9 Overlaps With Set 10 : " + Numbers9.Overlaps(Numbers10));

            Console.ReadKey();
        }
    }
}
