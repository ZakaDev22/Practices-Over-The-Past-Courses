using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 internal class Program
    {
        static void Main(string[] args)
        {

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


        DataView EmployeesDataView = new DataView();

        EmployeesDataView = dtEmployee.DefaultView;

        Console.WriteLine("\n\n\t Employees List From Data Table : \n\n");
        foreach (DataRow row in dtEmployee.Rows)
        {
            Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
        }


        Console.WriteLine("\n\n\t Employees List From Data View : \n\n");

        for (int i = 0; i < EmployeesDataView.Count; i++) 
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", EmployeesDataView[i][0], EmployeesDataView[i][1],
                                                         EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
        }

        //EmployeesDataView.RowFilter = "Country='Jordan'";

        //Console.WriteLine("\n\n\t Employees List From Data View After Filer It In (Jordan) : \n\n");

        //for (int i = 0; i < EmployeesDataView.Count; i++)
        //{
        //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", EmployeesDataView[i][0], EmployeesDataView[i][1],
        //                                                 EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
        //}



        EmployeesDataView.Sort = "Name ASC";

        Console.WriteLine("\n\n\t Employees List From Data View Order By Name : \n\n");

        for (int i = 0; i < EmployeesDataView.Count; i++)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", EmployeesDataView[i][0], EmployeesDataView[i][1],
                                                         EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
        }


        Console.ReadKey();
    }
    }

