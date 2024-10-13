using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Very_Important_Real_life_Application_of_Using_Static_and_Constructors
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }

        public string _UserName { get; set; }
        public string _Password { get; set; }

       public  clsPerson(int Id, String Name, short Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }


        public static clsPerson Find(int Id)
        {
            if (Id == 10)
            {
                return new clsPerson(24, "sZ", 21);
            }
            else
                return null;
        }

        public static clsPerson Find(string UserName,string Password)
        {
            if (UserName == "zas" && Password == "2124")
            {
                return new clsPerson(1, "a", 2);
            }
            else
                return null;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //clsPerson Person = new clsPerson(21, "zS",24);

            clsPerson Person2 = clsPerson.Find(10);

            clsPerson Person3 = clsPerson.Find("zas","2124");

            if (Person2 != null)
            {
                Console.WriteLine("\n\n Person Found :-)");
                Console.WriteLine(" Person 2 Id   : {0}", Person2.Id);
                Console.WriteLine(" Person 2 Name : {0}", Person2.Name);
                Console.WriteLine(" Person 2 Age  : {0}", Person2.Age);
            }
            else
            {
                Console.WriteLine("Person 2 Was Not Found, Try Again");
            }

            Console.WriteLine("\n\n");

            if (Person3 != null)
            {
                Console.WriteLine("\n\n Person Found :-)");
                Console.WriteLine(" Person 3 Id   : {0}", Person3.Id);
                Console.WriteLine(" Person 3 Name : {0}", Person3.Name);
                Console.WriteLine(" Person 3 Age  : {0}", Person3.Age);
            }
            else
            {
                Console.WriteLine("Person 2 Was Not Found, Try Again");
            }

            Console.ReadKey();
        }
    }
}
