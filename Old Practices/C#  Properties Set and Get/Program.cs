using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Properties_Set_and_Get
{

    class clsStudent
    {
        private int _ID;
        private string _Name = string.Empty;


        public int ID
        {
            get { return _ID; }

            set { _ID = value; }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set { _Name = value; }  

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsStudent Ziko = new clsStudent();
            clsStudent Caty= new clsStudent();

            Ziko.ID = 21;
            Ziko.Name = "The Wolf";

            Caty.ID = 24;
            Caty.Name = "SSiya";

            Console.WriteLine("Ziko Age : {0}", Ziko.ID);
            Console.WriteLine("Ziko Name : {0}", Ziko.Name);

            Console.WriteLine("==================================================================");

            Console.WriteLine("Caty Age : {0}", Caty.ID);
            Console.WriteLine("Caty Name : {0}", Caty.Name);

            Console.ReadKey();
        }
    }
}
