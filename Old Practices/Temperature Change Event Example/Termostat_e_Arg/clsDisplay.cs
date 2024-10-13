using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{
    internal class clsDisplay
    {
        public void Subscribe(clsTermostat Termostat)
        {
            Termostat.OnTemperatureChangeEvent += HandelTemperatureChanges;
        }

      

        public void HandelTemperatureChanges(object sender, TemperatureChangeEventArg e)
        {
            Console.WriteLine("\n Temperature Changed : ");
            Console.WriteLine($"\n  Old Temperature         :  {e.OldTemperature} ");
            Console.WriteLine($"\n  Current Temperature     :  {e.NewTemperature} ");
            Console.WriteLine($"\n  Temperature Difference  :  {e.Diferrent} \n");
        }
    }
}
