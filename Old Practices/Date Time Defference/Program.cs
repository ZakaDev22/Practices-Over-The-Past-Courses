using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Defference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime(2020, 4, 11, 4, 0, 12); //11 April 2020 4:00:12
            DateTime dt2 = new DateTime(2020, 5, 11, 5, 20, 28); //11 May 2020 5:20:28
            DateTime dt3 = new DateTime(2020, 6, 11); //11 June 2020 0:00:00
            TimeSpan interval = new TimeSpan(2, 14, 18); // 02:14:15

            TimeSpan diff1 = dt2 - dt1; //DateTime - DateTime 
            TimeSpan diff2 = dt3 - dt2; //Date - DateTime
            DateTime diff3 = dt3 - interval; //Date - TimeSpan 
            DateTime diff4 = dt2 - interval; //DateTime - TimeSpan 
                                             //interval.Subtract(dt3); // error

            Console.WriteLine("{0} - {1} = {2}", dt2, dt1, diff1);
            Console.WriteLine("{0} - {1} = {2}", dt3, dt2, diff2);
            Console.WriteLine("{0} - {1} = {2}", dt3, interval, diff3);
            Console.WriteLine("{0} - {1} = {2}", dt2, interval, diff4);

            Console.ReadKey();
        }
    }
}
