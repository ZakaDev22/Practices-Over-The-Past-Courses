using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace Nested_Case_Statements_Solution_In_C_
{
    internal class Program
    {
        public static string ConnectionString = "server=.;database=C21_DB1;user id=sa; password=sa123456";


        // First You Have The Bonus Failed In The Database To Set And Get The Value Of it
        // thene Make a Class Like Usual To Make Transactions On It 
        public class clsEmployes
        {
            public int employed { get; set; }



            public string EmployedName { get; set; }

            public string DepatementName { get; set; }

            public double Salary { get; set; }

            public int PerformanceRating { get; set; }

            public double Bonus { get; set; }


            public clsEmployes(string employeName, int PerformanceRating, double salary, double Bonus, string DepatementName)
            {
                this.EmployedName = employeName;
                this.PerformanceRating = PerformanceRating;
                this.Salary = salary;
                this.Bonus = Bonus;
                this.DepatementName = DepatementName;
            }


        }

        // Her Is The Method That Update The Bonus In The Data Base
        public static bool UpdateEmployeBonus(clsEmployes Employes, double Bonus)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();

                    string query = @"Update Employees2 Set Bonus = @Bonus
                                       where Name = @Name";

                    using (var Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Bonus", Bonus);
                        Command.Parameters.AddWithValue("@Name", Employes.EmployedName);


                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // false
            }

            return (RowEffected != 0);
        }

        // Get List Of Employees Just Like We Use Vector In C++ 
        public static List<clsEmployes> GetListOFEmployeis()
        {
            List<clsEmployes> EmployesList = new List<clsEmployes>();

            string EmployeName = null;
            int PerformanceRating = 0;
            double Salary = 0;
            double Bonus = 0;
            string DepatementName = null;

            clsEmployes Employe;

            try
            {

                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();

                    string query = "Select Name , Department, PerformanceRating , Salary , Bonus From Employees2";

                    using (var Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            // While The Records Still  in Reading Mood We Will Add Each Record In New Object And Add it To The List Of EMployees
                            while (Reader.Read())
                            {
                                EmployeName = (string)Reader["Name"];
                                PerformanceRating = (int)Reader["PerformanceRating"];
                                DepatementName = (string)Reader["Department"];

                                // Converting From Int To Float Number
                                Salary = Convert.ToDouble(Reader["Salary"]);

                                // int The First Time Theres No Need To CHeck If Bounus Is Null But Just In Case We Will Us it Another Time 
                                // I Have To Put Check Condition
                                if (Reader["Bonus"] != DBNull.Value)
                                {
                                    Bonus = Convert.ToDouble(Reader["Bonus"]);
                                }


                                // Adding A new Employee For Ech Row
                                Employe = new clsEmployes(EmployeName, PerformanceRating, Salary, Bonus, DepatementName);

                                // Now We Will Adding Each Employee In The List
                                EmployesList.Add(Employe);

                            }
                        }
                    }
                }
            }
            catch
            {
                // False
            }


            return EmployesList;
        }

        // Insted Of Using This Code In The Main Function i Just Devide it In Another Function And He will Return Bonus Number For Each EMployee
        public static double GetBonusAfterTheCalculation(string Depatement, double Salary, double PerformanceRating)
        {
            double bonus = 0;



            switch (Depatement)
            {
                case "Sales":

                    if (PerformanceRating > 90)
                    {
                        bonus = Salary * 0.15;
                    }
                    else if (PerformanceRating > 75 && PerformanceRating <= 90)
                    {
                        bonus = Salary * 0.10;
                    }
                    else
                    {
                        bonus = Salary * 0.05;
                    }


                    break;

                case "HR":

                    if (PerformanceRating > 90)
                    {
                        bonus = Salary * 0.10;
                    }
                    else if (PerformanceRating > 75 && PerformanceRating <= 90)
                    {
                        bonus = Salary * 0.08;
                    }
                    else
                    {
                        bonus = Salary * 0.04;
                    }


                    break;

                default:

                    if (PerformanceRating > 90)
                    {
                        bonus = Salary * 0.08;
                    }
                    else if (PerformanceRating > 75 && PerformanceRating <= 90)
                    {
                        bonus = Salary * 0.06;
                    }
                    else
                    {
                        bonus = Salary * 0.03;
                    }

                    break;
            }



            return bonus;
        }

        static void Main(string[] args)
        {



            List<clsEmployes> EmployiesList = GetListOFEmployeis();

            double Bonus = 0;

            // Update Every Employee At Ones
            foreach (clsEmployes Employe in EmployiesList)
            {
                Bonus = GetBonusAfterTheCalculation(Employe.DepatementName, Employe.Salary, Employe.PerformanceRating);

                if (UpdateEmployeBonus(Employe, Bonus))
                {
                    Console.WriteLine($"\n Bonus Of Employee {Employe.EmployedName} Updated Successfully. Boumus = {Bonus}");
                }
                else
                    Console.WriteLine($"\n Bonus Of Employee {Employe.EmployedName} Was Not Updated.  Boumus = {Bonus}");
            }

            Console.ReadKey();
        }
    }
}
