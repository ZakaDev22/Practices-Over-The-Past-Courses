using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_List_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(" My List Count = " + MyList.Count);

            Console.WriteLine(" My List Capacity = " + MyList.Capacity);

            MyList.Insert(0, 0);

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            MyList.RemoveAt(4);

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            MyList.InsertRange(4, new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            MyList.Remove(1);

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            MyList.RemoveAt(0);

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            MyList.RemoveAll(n => n == 7);

            Console.WriteLine(" My List Numbers : " + string.Join(", ", MyList));

            //  MyList.Clear();

            Console.WriteLine(" My List Numbers Count After Clearing All Numbers : " + MyList.Count);

            // Looping Through a List in C# =======================================================================

            Console.WriteLine("\n\n\n");
            Console.WriteLine(" My List Numbers Using For Loop : ");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.WriteLine(MyList[i]);
            }

            Console.WriteLine(" My List Numbers Using For Loop : ");
            foreach (int i in MyList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" My List Numbers Using Lambda Expression : ");

            MyList.ForEach(n => Console.WriteLine(n));

            //   Aggregating Data Using LINQ with List ========================================================

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Sum Of My List : " + MyList.Sum());

            Console.WriteLine("Average Of My List : " + MyList.Average());

            Console.WriteLine("Minimum Of My List : " + MyList.Min());

            Console.WriteLine("Maximum Of My List : " + MyList.Max());

            Console.WriteLine("My List Count : " + MyList.Count);

            // Filtering Data with LINQ in C# Using List ===================

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Even Numbers in My List : " + string.Join(", ", MyList.Where(n => n % 2 == 0)));

            Console.WriteLine("Odd Numbers in My List : " + string.Join(", ", MyList.Where(n => n % 2 != 0)));

            Console.WriteLine("My List Members Greater Than 10 : " + string.Join(", ", MyList.Where(n => n > 10)));

            Console.WriteLine("My List Members Greater Than 10  And Less Than 15 : " + string.Join(", ", MyList.Where(n => n > 10 && n < 15)));

            MyList.Insert(2, 22);


            Console.WriteLine("Printing My Age Number In My List : " + string.Join(", ", MyList.Where(n => n == 22)));
            Console.WriteLine("Printing My Age Number In My List Using Find Method : " + string.Join(", ", MyList.Find(n => n == 22)));

            Console.WriteLine("Printing Number Each Time : " + string.Join(", ", MyList.Where((n, index) => index % 2 == 0)));

            //  Sorting a List in C# Using Various Methods =================================================
            MyList.Sort();
            Console.WriteLine("My List Numbers Order By Sort Method : " + string.Join(", ", MyList));

            MyList.Reverse();
            Console.WriteLine("My List Numbers Order By Reverse Method : " + string.Join(", ", MyList));

            Console.WriteLine("My List Numbers Order By ToArray Method : " + string.Join(", ", MyList.OrderBy(n => n)));

            Console.WriteLine("My List Numbers Order By ToArray Method : " + string.Join(", ", MyList.OrderByDescending(n => n)));

            //  Exploring Contains, Exists, Find, FindAll, and Any with List of Integers ===========================================

            Console.WriteLine("\n\n\n");
            if (MyList.Contains(22))
                Console.WriteLine("Yes, 22 is in My List");
            else
                Console.WriteLine("No, 22 is not in My List");

            if (MyList.Exists(n => n == 23))
                Console.WriteLine("Yes, 23 is in My List");
            else
                Console.WriteLine("No, 23 is not in My List");

            if (MyList.Any(n => n == 23))
                Console.WriteLine("Yes, 23 is in My List");
            else
                Console.WriteLine("No, 23 is not in My List");

            Console.WriteLine("My List Numbers By Find Method : " + string.Join(", ", MyList.Find(n => n > 22)));
            Console.WriteLine("My List Numbers By  FindAll Method : " + string.Join(", ", MyList.FindAll(n => n < 22)));

            //=====================================
            List<string> Words = new List<string> { "zaka", "King", "ali", "Ziko", "SS$" };

            Console.WriteLine("\nStrings Filtering 🔥");
            Console.WriteLine("My List Strings By  Contain Method : " + string.Join(", ", Words.Contains("zaka")));

            Console.WriteLine("My List Strings By  Exists Method : " + string.Join(", ", Words.Exists(word => word.Length > 2)));

            bool isWordGreaterThan3Characters(string word)
            {
                return word.Length > 3;
            }

            Console.WriteLine("My List Strings By  My Any Named Method : " + string.Join(", ", Words.Any(isWordGreaterThan3Characters)));

            Console.WriteLine("My List Strings By  Find Method : " + string.Join(", ", Words.Find(Word => Word.Length == 3)));

            Console.WriteLine("My List Strings By  Find Method : " + string.Join(", ", Words.FindAll(Word => Word.Length == 3)));

            Console.ReadKey();
        }
    }
}
