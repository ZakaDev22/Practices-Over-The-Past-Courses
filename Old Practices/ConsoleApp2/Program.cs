using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class clsEmployees
    {
        private int _ID = 21;
        private string _Name = string.Empty;


        public int ID
        {
            get { return _ID; }
        }

        public string Name
        {
              set { _Name = value; }

            get { return _Name; }
        }

        public int Age { get; set; }

        public string Catty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployees Employee = new clsEmployees();

            //Employee.ID = 1;

            Employee.Name = "im The Best";

            Console.WriteLine("\n\t\t Employee Name = {0}", Employee.Name);

            Console.WriteLine("\n\t\t Employee ID   = {0}", Employee.ID);

            Console.WriteLine("================================================================================================");

            Employee.Age = 24;
            Employee.Catty = "My Catty";

            Console.WriteLine("\n\t\t Ssiya Age = {0}", Employee.Age);
            Console.WriteLine("\n\t\t Ssiya Name = {0}", Employee.Catty);


            Console.ReadKey();

        }
    }
}
