using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class clsPeson
{

    public  int ID { get; set; }
    public string Name { get; set; }

    public byte Age { get; set; }


    public clsPeson()
    {
        ID = -1;
        Name = "Zaka";
        Age = 21;
    }

    public clsPeson(int id, string Name, byte Age)
    {
        this.ID = id;
        this.Name = Name;
        this.Age = Age;
    }

    //private clsPeson()
    //{

    //}
}

namespace C__Course_16_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPeson Person1 = new clsPeson(2,"Ssiya",24);

            clsPeson Person2 = new clsPeson();

            Console.WriteLine("Person 1 ID = {0} ", Person1.ID);
            Console.WriteLine("Person 1 Name = {0}", Person1.Name);
            Console.WriteLine("Person 1 Age = {0}", Person1.Age);

            Console.WriteLine("Person 2 ID = {0} ", Person2.ID);
            Console.WriteLine("Person 2 Name = {0}", Person2.Name);
            Console.WriteLine("Person 2 Age = {0}", Person2.Age);

            Console.ReadKey();
        }
    }
}
