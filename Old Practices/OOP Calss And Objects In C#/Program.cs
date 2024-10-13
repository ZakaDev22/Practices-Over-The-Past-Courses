using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Console_App
{
    class clsPerson
    {
        public string FirstNam;
        public string LastNam;

        public string FullName()
        {
            return FirstNam + " " + LastNam;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson TheWolf = new clsPerson(); 

            TheWolf.FirstNam = "Ziko";
            TheWolf.LastNam = "The King";

            Console.WriteLine(TheWolf.FullName());


            clsPerson MyCaty = new clsPerson();

            MyCaty.FirstNam = "SSiya";
            MyCaty.LastNam = "My Caty";




            Console.Write(MyCaty.FullName());

            Console.Write(Environment.NewLine);


            Console.WriteLine(MyCaty.FullName());


            Console.ReadLine();
        }
    }
}
