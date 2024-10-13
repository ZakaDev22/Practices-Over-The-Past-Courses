using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_a_List_of_Custom_Objects
{
    internal class Program
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            // Create a list of customers
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "John",
                    Age = 30
                },
                new Customer
                {
                    Id = 2,
                    Name = "Jane",
                    Age = 25
                },
                new Customer
                {
                    Id = 3,
                    Name = "Bob",
                    Age = 40
                }

            };

            // print All The Customers
            Console.WriteLine("\n\nAll Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($" Costomer ID : {customer.Id} {customer.Name} {customer.Age}");
            }

            Customer FindPerson = customers.Find(c => c.Age > 30);
            Console.WriteLine("\n\nCustomer With Age greater Than 30 Using FInd Method:");
            if (FindPerson != null)
            {
                Console.WriteLine($" Customer ID : {FindPerson.Id} {FindPerson.Name} {FindPerson.Age}");
            }


            Customer FindPerson2 = customers.FirstOrDefault(c => c.Age > 30);
            Console.WriteLine("\n\nCustomer With Age greater Than 30 Using FirsOrDefault Method:");
            if (FindPerson != null)
            {
                Console.WriteLine($" Customer ID : {FindPerson2.Id} {FindPerson2.Name} {FindPerson2.Age}");
            }

            List<Customer> sortedCustomers = customers.FindAll(c => c.Age > 20).OrderBy(c => c.Age).ToList();
            Console.WriteLine("\n\nSorted Customers With Age greater Than 30:");
            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine($" Customer ID : {customer.Id} {customer.Name} {customer.Age}");
            }

            List<Customer> filteredCustomers = customers.FindAll(c => c.Age > 30);
            Console.WriteLine("\n\nFiltered Customers With Age greater Than 30:");
            foreach (var customer in filteredCustomers)
            {
                Console.WriteLine($" Customer ID : {customer.Id} {customer.Name} {customer.Age}");
            }

            bool found = customers.Any(c => c.Age > 30);
            Console.WriteLine($"\n\nCustomers With Age greater Than 30 : {found}");

            bool found2 = customers.Exists(c => c.Age > 40);
            Console.WriteLine($"\n\nCustomers With Age greater Than 40 : {found2}");

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = Numbers.Sum();
            Console.WriteLine($"\n\nSum Of Numbers : {sum}");

            int[] arr1 = Numbers.ToArray();
            Console.WriteLine($"\n\nArray Of Numbers : {string.Join(", ", arr1)}");

            Numbers.Reverse();
            List<int> Numbers2 = Numbers;
            int[] arr2 = Numbers.ToArray();
            Console.WriteLine($"\n\nReversed Array Of Numbers : {string.Join(", ", arr2)}");

            List<int> ListNumbers = new List<int>(arr2);
            Console.WriteLine($"\n\nList Of Numbers : {string.Join(", ", ListNumbers)}");

            List<int> ListNumbers2 = arr2.ToList();
            Console.WriteLine($"\n\nList Of Numbers : {string.Join(", ", ListNumbers2)}");



            Console.ReadKey();
        }
    }
}
