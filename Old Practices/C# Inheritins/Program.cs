using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsPerson
{
    public int Id { get; set; }
    public string LastName { get; set; } 
    public string FirstName { get; set; }
    public int Age { get; set; }
    public string Title { get; set; }

    public clsPerson(int id , string lastname,string firstname, int age, string title) 
    { 
    
        Id = id;
        LastName = lastname;
        FirstName = firstname;
        Age = age;
        Title = title;
    
    }

    public string FullName()
    {
        return FirstName + " " + LastName;
    }
}

public class clsEmployee : clsPerson
{
    public string Departeent { get; set; }
    public float Salary { get; set; }

   public clsEmployee(int id, string lastname, string firstname, int age, string title, string departement, float salary) : base(id, lastname, firstname, age, title)
    {
      this.Departeent = departement;
        this.Salary = salary;

    }

    public float IncreaseSalaryBy(float Amount)
    {
        return Salary += Amount;
    }
}

namespace C__Inheritins
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //clsPerson Person = new clsPerson();

           // Person.Age = 10;

            clsEmployee employee = new clsEmployee(21,"z","s",24," ","it",5921.24f);


            Console.WriteLine("Employee ID          : {0}", employee.Id);
            Console.WriteLine("Employee Full Name   : {0}", employee.FullName());
            Console.WriteLine("Employee Age         : {0}", employee.Age);
            Console.WriteLine("Employee Title       : {0}", employee.Title);
            Console.WriteLine("Employee Department  : {0}", employee.Departeent);
            Console.WriteLine("Employee Salary      : {0}", employee.Salary);


            Console.ReadKey();

        }
    }
}
