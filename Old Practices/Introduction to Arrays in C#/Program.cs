using System;
using System.Linq;

namespace Introduction_to_Arrays_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string[] arr2 = { "zaka", "Ziko", "zaki" };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("\n Reversed Array");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Sorted Array");
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Index Of Number 20");
            var index = Array.IndexOf(arr, 20);
            Console.WriteLine(index);


            Console.WriteLine("\n 2D Array");
            int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Original array
            int[] original = { 1, 2, 3, 4, 5, 6 };


            // Array to hold the copy
            int[] copy = new int[5];


            // Copying array
            Array.Copy(original, copy, copy.Length);


            // Displaying the copied array
            Console.WriteLine("Copied Array:");
            foreach (var element in copy)
            {
                Console.WriteLine(element);
            }

            var arr3 = GetNewArray(arr);

            Console.WriteLine("\n New Array");
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Using linq");

            var arr4 = arr.Where(x => x % 2 == 0).Select(x => x * 2);

            foreach (var item in arr4)
            {
                Console.WriteLine(item);
            }

            // Array of people with Name and Age
            var people = new[]
            {
            new { Name = "Alice", Age = 30 },
            new { Name = "Bob", Age = 25 },
            new { Name = "Charlie", Age = 35 },
            new { Name = "Diana", Age = 30 },
            new { Name = "Ethan", Age = 25 }
             };

            var GroupingPeople = people.GroupBy(x => x.Age)
                               .Select(x => new { Age = x.Key, people = x.OrderBy(y => y.Name) });

            foreach (var item in GroupingPeople)
            {
                Console.WriteLine($"Age Group: {item.Age}");
                foreach (var person in item.people)
                {
                    Console.WriteLine(person.Name);
                }
            }

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var EvenNumbers = array.Where(x => x % 2 == 0);

            var SumOfEvenNumbers = EvenNumbers.Sum();

            Console.WriteLine("\n Even Numbers : {0}", string.Join(",", EvenNumbers));

            Console.WriteLine("\n Sum of Even Numbers : {0}", SumOfEvenNumbers);

            // Array of employees
            var employees = new[]
            {
            new { Id = 1, Name = "Alice", DepartmentId = 2 },
            new { Id = 2, Name = "Bob", DepartmentId = 1 }
        };


            // Array of departments
            var departments = new[]
            {
            new { Id = 1, Name = "Human Resources" },
            new { Id = 2, Name = "Development" }
        };


            // Joining employees with departments and projecting the result
            var employeeDetails = employees.Join(departments,
                                                 e => e.DepartmentId,
                                                 d => d.Id,
                                                 (e, d) => new { e.Id, e.Name, Department = d.Name });


            // Displaying the results
            foreach (var detail in employeeDetails)
            {
                Console.WriteLine($"EmployeeID: {detail.Id}, Name: {detail.Name}, Department: {detail.Department}");
            }

            Console.WriteLine("\n jagged array \n");
            int[][] jaggedArr = new int[3][];

            jaggedArr[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArr[1] = new int[] { 4, 5, 6 };
            jaggedArr[2] = new int[] { 7, 8, 9 };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Declare and initialize a jagged array
            int[][] jaggedArray = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9, 10 }
        };


            // Flatten the jagged array and sum all elements
            int totalSum = jaggedArray.SelectMany(subArray => subArray).Sum();
            Console.WriteLine("Total Sum: " + totalSum);


            // Find the maximum element in the jagged array
            int maxElement = jaggedArray.SelectMany(subArray => subArray).Max();
            Console.WriteLine("Maximum Element: " + maxElement);


            // Filter arrays having more than 3 elements and select their first element
            var firstElements = jaggedArray.Where(subArray => subArray.Length > 3)
                                           .Select(subArray => subArray.FirstOrDefault());
            Console.Write("First Elements of Long Rows: ");
            foreach (var element in firstElements)
            {
                Console.Write(element + " ");
            }

            Console.ReadLine();
        }

        public static int[] GetNewArray(int[] source)
        {
            if (source == null || source.Length == 0)
            {
                return null;
            }
            int[] array = new int[source.Length];
            Array.Copy(source, array, source.Length);
            return array;
        }
    }
}
