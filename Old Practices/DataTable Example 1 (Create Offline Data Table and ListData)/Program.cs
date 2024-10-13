using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataTable_Example_1__Create_Offline_Data_Table_and_ListData_
{
    internal class Program
    {

        public static void PrintExample()
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("ID", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Country", typeof(string));
            dtEmployee.Columns.Add("Salary", typeof(Double));
            dtEmployee.Columns.Add("Date", typeof(DateTime));

            dtEmployee.Rows.Add(1, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(2, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(3, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(4, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(5, "The Best", "Morocco", 5099.99, DateTime.Now);

            int TotalEmployess = 0;
            double TotalSalaries = 0;
            double AverageSalaries = 0;
            double MaxSalary = 0;
            double MinSalary = 0;

            TotalEmployess = dtEmployee.Rows.Count;
            TotalSalaries = Convert.ToDouble(dtEmployee.Compute("SUM(Salary)", string.Empty));
            AverageSalaries = Convert.ToDouble(dtEmployee.Compute("AVG(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(dtEmployee.Compute("MAX(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(dtEmployee.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            Console.WriteLine($"\n Total Employees  : {TotalEmployess}");
            Console.WriteLine($"\n Total Salaries   : {TotalSalaries}");
            Console.WriteLine($"\n Average Salaries : {AverageSalaries}");
            Console.WriteLine($"\n Max Salary       : {MaxSalary}");
            Console.WriteLine($"\n Min Salary       : {MinSalary}");

            // Filter Employees By Country Name

            DataRow[] dtRow;

            dtRow = dtEmployee.Select("Country = 'Jordan' ");

            Console.WriteLine("\n\n\t Filter Table By Country Jordan\n");
            foreach (DataRow row in dtRow)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            TotalEmployess = dtRow.Count();
            TotalSalaries = Convert.ToDouble(dtEmployee.Compute("SUM(Salary)", "Country = 'Jordan' "));
            AverageSalaries = Convert.ToDouble(dtEmployee.Compute("AVG(Salary)", "Country = 'Jordan' "));
            MaxSalary = Convert.ToDouble(dtEmployee.Compute("MAX(Salary)", "Country = 'Jordan' "));
            MinSalary = Convert.ToDouble(dtEmployee.Compute("MIN(Salary)", "Country = 'Jordan' "));

            Console.WriteLine($"\n Total Employees  : {TotalEmployess}");
            Console.WriteLine($"\n Total Salaries   : {TotalSalaries}");
            Console.WriteLine($"\n Average Salaries : {AverageSalaries}");
            Console.WriteLine($"\n Max Salary       : {MaxSalary}");
            Console.WriteLine($"\n Min Salary       : {MinSalary}");

            dtRow = dtEmployee.Select("Country = 'Jordan' or Country = 'Morocco' ");

            Console.WriteLine("\n\n\t Filter Table By Country Jordan And Morocco\n");
            foreach (DataRow row in dtRow)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            TotalEmployess = dtRow.Count();
            TotalSalaries = Convert.ToDouble(dtEmployee.Compute("SUM(Salary)", "Country = 'Jordan' or Country = 'Morocco' "));
            AverageSalaries = Convert.ToDouble(dtEmployee.Compute("AVG(Salary)", "Country = 'Jordan' or Country = 'Morocco' "));
            MaxSalary = Convert.ToDouble(dtEmployee.Compute("MAX(Salary)", "Country = 'Jordan' or Country = 'Morocco' "));
            MinSalary = Convert.ToDouble(dtEmployee.Compute("MIN(Salary)", "Country = 'Jordan' or Country = 'Morocco' "));

            Console.WriteLine($"\n Total Employees  : {TotalEmployess}");
            Console.WriteLine($"\n Total Salaries   : {TotalSalaries}");
            Console.WriteLine($"\n Average Salaries : {AverageSalaries}");
            Console.WriteLine($"\n Max Salary       : {MaxSalary}");
            Console.WriteLine($"\n Min Salary       : {MinSalary}");



            Console.WriteLine("\n\n\t Filter Table By Country Jordan And Morocco\n");

            dtRow = dtEmployee.Select("ID = 1");

            Console.WriteLine("\n\n\t Filter Table By ID = 1 \n");
            foreach (DataRow row in dtRow)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
        }

        public static void PrintExample2()
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("ID", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Country", typeof(string));
            dtEmployee.Columns.Add("Salary", typeof(Double));
            dtEmployee.Columns.Add("Date", typeof(DateTime));

            dtEmployee.Rows.Add(1, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(2, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(3, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(4, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(5, "The Best", "Morocco", 5099.99, DateTime.Now);


            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            dtEmployee.DefaultView.Sort = "ID desc";

            dtEmployee = dtEmployee.DefaultView.ToTable();

            Console.WriteLine("\n\n\t Employees List Order By ID desc : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }


            dtEmployee.DefaultView.Sort = "Name ASC";

            dtEmployee = dtEmployee.DefaultView.ToTable();

            Console.WriteLine("\n\n\t Employees List Order By Name ASC : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

        }

        public static void PrintExample3()
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("ID", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Country", typeof(string));
            dtEmployee.Columns.Add("Salary", typeof(Double));
            dtEmployee.Columns.Add("Date", typeof(DateTime));

            dtEmployee.Rows.Add(1, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(2, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(3, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(4, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(5, "The Best", "Morocco", 5099.99, DateTime.Now);


            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            DataRow[] dtRow = dtEmployee.Select("ID=3");

            foreach (DataRow row in dtRow)
            {
                row.Delete();
            }


            // if you Are Online To Database 
            // dtEmployee.AcceptChanges();

            Console.WriteLine("\n\n\t Employees List After Deleting Employee Number 3 : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            dtRow = dtEmployee.Select("ID=5");

            foreach (var row in dtRow)
            {
                row["Name"] = "Best Of The Best";
                row["Salary"] = "21000";
            }

            // if you Are Online To Database 
            // dtEmployee.AcceptChanges();

            Console.WriteLine("\n\n\t Employees List After Updating Employee Number 5 : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
        }

        public static void printExample4()
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("ID", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Country", typeof(string));
            dtEmployee.Columns.Add("Salary", typeof(Double));
            dtEmployee.Columns.Add("Date", typeof(DateTime));

            dtEmployee.Rows.Add(1, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(2, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(3, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(4, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(5, "The Best", "Morocco", 5099.99, DateTime.Now);


            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            dtEmployee.Clear();

            Console.WriteLine("\n\n\t Employees List After Clear Method : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }


        }

        public static void PrintExample5()
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("ID", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Country", typeof(string));
            dtEmployee.Columns.Add("Salary", typeof(Double));
            dtEmployee.Columns.Add("Date", typeof(DateTime));

            dtEmployee.Rows.Add(1, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(2, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(3, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(4, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(5, "The Best", "Morocco", 5099.99, DateTime.Now);

            DataColumn[] primaryKeyColum = new DataColumn[1];
            primaryKeyColum[0] = dtEmployee.Columns["ID"];
            dtEmployee.PrimaryKey = primaryKeyColum;

            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
        }

        public static void PrintExample9AutoincrementandOthers()
        {

        }


        static void Main(string[] args)
        {

            // PrintExample();

            // PrintExample2();

            // PrintExample3();

            // printExample4();

            DataTable dtEmployee = new DataTable();

            DataColumn dcColumn;

            dcColumn = new DataColumn();
            dcColumn.DataType = typeof(int);
            dcColumn.ColumnName = "ID";
            dcColumn.Caption = "EmployeeID";
            dcColumn.AutoIncrement = true;
            dcColumn.AutoIncrementSeed = 1;
            dcColumn.AutoIncrementStep = 1;

            dcColumn.Unique = true;
            dcColumn.ReadOnly = true;

            dtEmployee.Columns.Add(dcColumn);

            dcColumn = new DataColumn();
            dcColumn.DataType = typeof(string);
            dcColumn.ColumnName = "Name";
            dcColumn.Caption = "EmployeeName";
            dcColumn.AutoIncrement = false;
           

            dcColumn.Unique = false;
            dcColumn.ReadOnly = false;

            dtEmployee.Columns.Add(dcColumn);

            dcColumn = new DataColumn();
            dcColumn.DataType = typeof(string);
            dcColumn.ColumnName = "Country";
            dcColumn.Caption = "CountryNmae";
            dcColumn.AutoIncrement = false;


            dcColumn.Unique = false;
            dcColumn.ReadOnly = false;

            dtEmployee.Columns.Add(dcColumn);

            dcColumn = new DataColumn
            {
                DataType = typeof(Double),
                ColumnName = "Salary",
                Caption = "EmployeeSalary",
                AutoIncrement = false,


                Unique = false,
                ReadOnly = false
            };

            dtEmployee.Columns.Add(dcColumn);

            dcColumn = new DataColumn
            {
                DataType = typeof(DateTime),
                ColumnName = "DateOfBirth",
                Caption = "Birth",
                AutoIncrement = false,


                Unique = false,
                ReadOnly = false
            };

            dtEmployee.Columns.Add(dcColumn);

            DataColumn[] primaryKeyColum = new DataColumn[1];
            primaryKeyColum[0] = dtEmployee.Columns["ID"];
            dtEmployee.PrimaryKey = primaryKeyColum;

            dtEmployee.Rows.Add(null, "Zakaria Elfakhar", "Morocco", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(null, "Mohammed Abu-Hadhoud", "Jordan", 5099.99, DateTime.Now);
            dtEmployee.Rows.Add(null, "ME", "FF", 50000, DateTime.Now);
            dtEmployee.Rows.Add(null, "The King ", "Morocco", 10999.99, DateTime.Now);
            dtEmployee.Rows.Add(null, "The Best", "Morocco", 5099.99, DateTime.Now);

          

            Console.WriteLine("\n\n\t Employees List : \n\n");
            foreach (DataRow row in dtEmployee.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                        row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
            }

         


            Console.ReadKey();

        }
    }
}
