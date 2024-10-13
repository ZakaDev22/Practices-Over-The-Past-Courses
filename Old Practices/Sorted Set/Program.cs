using System;
using System.Collections.Generic;
using System.Linq;


namespace Sorted_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> SortedSet = new SortedSet<int>
            {
                {1 },
                {2 },
                {3 },
                {4 },
                {5 }
            };

            Console.WriteLine();
            foreach (var item in SortedSet)
            {
                Console.WriteLine(item);
            }

            SortedSet.RemoveWhere(x => x == 2);

            SortedSet.Add(6);
            SortedSet.Add(7);
            SortedSet.Add(8);
            SortedSet.Add(9);
            SortedSet.Add(10);
            SortedSet.Add(11);
            SortedSet.Add(12);
            SortedSet.Add(13);
            SortedSet.Add(14);
            SortedSet.Add(15);
            SortedSet.Add(16);
            SortedSet.Add(17);
            SortedSet.Add(18);
            SortedSet.Add(19);

            Console.WriteLine();
            foreach (var item in SortedSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n The first method using the query exprition :" + SortedSet.Any(x => x > 10));

            SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Find even numbers and project them to their square
            var evenNumbersSquared = numbers.Where(x => x % 2 == 0)
                                            .Select(x => x * x)
                                            .OrderByDescending(x => x);

            Console.WriteLine("Squares of even numbers:");
            foreach (var item in evenNumbersSquared)
            {
                Console.Write(item + " ");
            }

            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


            // Union
            SortedSet<int> unionSet = new SortedSet<int>(set1);
            unionSet.UnionWith(set2);
            Console.WriteLine("\nUnion:");
            foreach (int item in unionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Intersection
            SortedSet<int> intersectSet = new SortedSet<int>(set1);
            intersectSet.IntersectWith(set2);
            Console.WriteLine("\nIntersection:");
            foreach (int item in intersectSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Difference
            SortedSet<int> differenceSet = new SortedSet<int>(set1);
            differenceSet.ExceptWith(set2);
            Console.WriteLine("\nDifference (set1 - set2):");
            foreach (int item in differenceSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Subset and Superset
            Console.WriteLine("\nSubset:");
            if (set1.IsSubsetOf(set2))
                Console.WriteLine("Set1 is a subset of Set2");
            else
                Console.WriteLine("Set1 is not a subset of Set2");


            Console.WriteLine("\nSuperset:");
            if (set1.IsSupersetOf(set2))
                Console.WriteLine("Set1 is a superset of Set2");
            else
                Console.WriteLine("Set1 is not a superset of Set2");


            Console.ReadKey();
        }
    }
}
