using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_SortedList
{
    public class Program
    {



        static void Main(string[] args)
        {
            SortedList<string, int> SortedList = new SortedList<string, int>
            {
                {"zaka",1 },
                {"mohamed",2 },
                {"ali",3 },
                {"SSiya",4 }

            };

            SortedList.Add("zika", 55);

            foreach (var item in SortedList)
            {
                Console.WriteLine(item);
            }

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(1, "zika");
            keyValuePairs.Add(2, "mohamed");
            keyValuePairs.Add(3, "ali");
            keyValuePairs.Add(4, "SSiya");

            var query = from x in keyValuePairs
                        where x.Value.StartsWith("S")
                        select x;
            Console.WriteLine("\n The first method using the query exprition :");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var query2 = keyValuePairs.Where(x => x.Value.StartsWith("z"));

            Console.WriteLine("\n The Second method using the Where Method  :");
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }

            var query4 = keyValuePairs.ToArray();

            Console.WriteLine("\n The Third method using the ToArray Method  :");
            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }

            SortedList<int, string> Sset = new SortedList<int, string>();

            Sset.Add(1, "Apple");
            Sset.Add(2, "Banana");
            Sset.Add(3, "Orange");
            Sset.Add(4, "Grapes");
            Sset.Add(5, "Strawberry");
            Sset.Add(6, "Watermelon");

            var Groups = Sset.GroupBy(x => x.Value.Length);

            Console.WriteLine("\n The GroupBy Method :");
            foreach (var group in Groups)
            {
                // this will print each element with the key of it
                // Console.WriteLine($"Group of length {group.Key} : {string.Join(",", group.Select(x => x))}");

                Console.WriteLine($"Group of length {group.Key} : {string.Join(",", group.Select(x => x.Value))}");

            }

            SortedList<int, clsEmployees> EMployees = new SortedList<int, clsEmployees>
            {
                    {1, new clsEmployees(1, "zaka", 2500, "FF") },
                {2, new clsEmployees(2, "mohamed", 2500, "HR") },
                {3, new clsEmployees(3, "ali", 2500, "IT") },
                {4, new clsEmployees(4, "SSiya", 2500, "FF") }


            };

            var SertedEmployees = EMployees.Where(x => x.Value.Department == "FF")
                                           .OrderByDescending(x => x.Value.Salary)
                                           .Select(x => x.Value);
            Console.WriteLine("\n\n The OrderBy FF Method :");
            foreach (var item in SertedEmployees)
            {
                item.Salary *= 1.1;
            }

            Console.WriteLine("\n\n The FF Method After Make Each Salary With * 1.1 For FF Members :");
            foreach (var item in SertedEmployees)
            {
                Console.WriteLine(item.Name + "the New Salary Is : " + item.Salary);
            }



            Console.ReadKey();
        }


    }
}

public class clsEmployees
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public string Department { get; set; }

    public clsEmployees(int ID, string Name, float Salary, string Department)
    {
        this.ID = ID;
        this.Name = Name;
        this.Salary = Salary;
        this.Department = Department;
    }


}