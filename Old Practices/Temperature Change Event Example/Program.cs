using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{


     

    internal class Program
    {
        static void Main(string[] args)
        {

            //clsTermostat termostat = new clsTermostat();
            //clsDisplay Display = new clsDisplay();

            //Display.Subscribe( termostat );

            //termostat.SetTemperature(25);

            //termostat.SetTemperature(28);

            //
            // News Publesher Event
            //

            clsPublisher publisher = new clsPublisher();
            clsNewsSubscribers subscriber1 = new clsNewsSubscribers("Zakaria");

            subscriber1.Subscribe( publisher );

            clsNewsSubscribers subscriber2 = new clsNewsSubscribers("The Wolf");

            subscriber2.Subscribe(publisher);

            publisher.PubleshNews("New", "Im The King");

            subscriber1.UnSubscribe( publisher );

            publisher.PubleshNews("New2", "I will Winnnnn");

            subscriber2.UnSubscribe( publisher );

            publisher.PubleshNews("New3", "I will Winnnnn bi idni allah");


            Console.ReadKey();
        }
    }
}
