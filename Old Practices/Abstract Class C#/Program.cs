using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class clsPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public abstract void Introduce();
    

    public void SayGoodBy()
    {
        Console.WriteLine("Good By");
    }
}


public class clsEmployee : clsPerson
{

    public float Salary { get; set; }

    public int EmployeedId { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"Hi Im {FirstName} {LastName} , My ID is : {EmployeedId} , My Salary Is : {Salary} ");
    }
}

namespace Abstract_Class_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // clsPerson Perspn1 = new clsPerson();

            clsEmployee EMployee1 = new clsEmployee();

            EMployee1.FirstName = "Ziko ";
            EMployee1.LastName = "The King";

            EMployee1.EmployeedId = 21;

            EMployee1.Salary = 5521.24f;

            EMployee1.SayGoodBy();
            EMployee1.Introduce();

            Console.ReadKey();
        }
    }
}
