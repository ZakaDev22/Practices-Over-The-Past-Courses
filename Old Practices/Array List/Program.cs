using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Add("Zaka");
            list.Add(true);
            list.Add(22.6);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 2, 2, 5, 6, 7, 2, 8, 9, 10 };

            //var x = arrayList.Cast<int>().Where(a => a % 2 == 0);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            arrayList.Add(22);
            arrayList.Add(33);
            arrayList.Add(44);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            var minValue = arrayList.Cast<int>().Min();
            int min = arrayList.Cast<int>().Min();

            var max = arrayList.Cast<int>().Max();
            var avg = arrayList.Cast<int>().Average();
            var count = arrayList.Cast<int>().Count();
            var sum = arrayList.Cast<int>().Sum();

            SortedDictionary<string, int> sd = new SortedDictionary<string, int>
            {
                {"Min",min },
                {"Max",max },
                {"Count",count },
                {"Sum",sum },
            };

            sd.Add("AVG", (int)avg);

            Console.WriteLine("\n Aggreget Functions : ");


            foreach (var item in sd)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var arr = arrayList.OfType<int>().OrderByDescending(a => a);

            Console.WriteLine("Array List Elements Order By Descending :" + string.Join(", ", arr));

            int target = 2;


            int targetCount = arr.Cast<int>().Count(x => x == target);

            Console.WriteLine("\n\nTarget Count : " + targetCount);


            Console.ReadKey();
        }
    }
}
