using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Dataset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable dtEmployees = new DataTable("EmployeesDataTable");

            dtEmployees.Columns.Add("ID", typeof(int));
            dtEmployees.Columns.Add("Name", typeof(string));
            dtEmployees.Columns.Add("Country", typeof(string));
            dtEmployees.Columns.Add("Salary", typeof(Double));
            dtEmployees.Columns.Add("DateOfBirth", typeof(DateTime));

            dtEmployees.Rows.Add(1, "Zakaria", "Morocco", 10221.21, DateTime.Now);
            dtEmployees.Rows.Add(2, "Ziko", "FF", 10221.21, DateTime.Now);
            dtEmployees.Rows.Add(3, "The King", "SS", 10221.21, DateTime.Now);

            DataTable dtDepartements = new DataTable("DepertementDataTable");

            dtDepartements.Columns.Add("ID", typeof(int));
            dtDepartements.Columns.Add("Name", typeof(string));

            dtDepartements.Rows.Add(1, "IT");
            dtDepartements.Rows.Add(2, "HR");
            dtDepartements.Rows.Add(3, "Marketing");



            Console.WriteLine("\n\t Employees List\n\n");
            foreach (DataRow row in dtEmployees.Rows)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", row["ID"], row["Name"], row["Country"], row["DateOfBirth"], row["Salary"]);
            }


            Console.WriteLine("\n\t Departement List\n\n");
            foreach (DataRow row in dtDepartements.Rows)
            {
                Console.WriteLine("{0}, {1}  ", row["ID"], row["Name"]);
            }

            DataSet dsDataSet = new DataSet();

            dsDataSet.Tables.Add(dtEmployees);
            dsDataSet.Tables.Add(dtDepartements);

            Console.WriteLine("\n\t Employees List From Data Set\n\n");
            foreach (DataRow row in dsDataSet.Tables["EmployeesDataTable"].Rows)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", row["ID"], row["Name"], row["Country"], row["DateOfBirth"], row["Salary"]);
            }


            Console.WriteLine("\n\t Departement List From DataSet\n\n");
            foreach (DataRow row in dsDataSet.Tables["DepertementDataTable"].Rows)
            {
                Console.WriteLine("{0}, {1}  ", row["ID"], row["Name"]);
            }


            Console.ReadKey();

        }
    }
}
