using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class clsStudent
    {
        public int Id { get; set; }

        private string _Name = string.Empty;



        public string Name
        {
            set
            {
                _Name = value;
            }

            get
            {
                return _Name;
            }
        }
    }

    class clsSettings
    {
      public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;   
        }
    }

    internal class Program
    {

       

        static void Main(string[] args)
        {

            clsStudent student = new clsStudent();

            student.Id = 21;
            student.Name = "The Zaka";

            Console.WriteLine( " Student ID : {0}",student.Id);
            Console.WriteLine(" Student Name = {0}", student.Name);


            Console.WriteLine("Day Number = {0}", clsSettings.DayNumber);
            Console.WriteLine("Day Name = {0}", clsSettings.DayName);

            clsSettings.ProjectPath = "C:/ProjectPath";

            Console.WriteLine("Project Path : {0}", clsSettings.ProjectPath);

          

            Console.ReadKey();
        }
    }
}
