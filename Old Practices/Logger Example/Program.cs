using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Example
{
    internal class Program
    {

        public class Logger
        {
            public delegate void LogAction(string message);

            private LogAction _Action;

            public Logger(LogAction action)
            {
                _Action = action;
            }

            public void Log(string message)
            {
                _Action(message);
            }
        }

        public static void LogToScreen(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogToFill(string message)
        {
            string FillName = "Zaka.txt";

            using (StreamWriter writer = new StreamWriter(FillName, false))
            {
                writer.WriteLine(message);
            }
        }

        //
        /// </summary>
        //

        public class Calculator
        {
            public delegate double CalculatorAction(double x, double y);

            private CalculatorAction _Action;

            public Calculator(CalculatorAction action)
            {
                _Action = action;
            }

            public double OnCalcolation(double x, double y)
            {
                return _Action(x, y);
            }
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Sub(double x, double y)
        {
            return x - y;
        }

        public static double Mul(double x, double y)
        {
            return x * y;
        }

        public static double Devid(double x, double y)
        {
            return (x == y) ? 0 : x / y;
        }

        //
        /// <summary>
        /// Make Finc delegate to Call Back Methods

        // Func Delegate Return Value
        public static Func<double, double, double, double> Sum = SumOf3Numbers;

        // Normal Delegate
        public delegate double SumDelegate(double x, double y,double z);

        // Action Delegate - Void Functionts
        public static Action MethosOfMyName = WriteMyName;
        public static Action<int> MethosOfMyNameAndMyAge = WriteMyNameAndMyAge;

        // Predicate Delegete Returns a Boolean Value 
        public static Predicate<int> IsMyAgeAbove20Predicate = IsMyAgeAbove20;

        public static bool IsMyAgeAbove20(int Age)
        {
            return (Age > 20);
        }



        public static  double SumOf3Numbers(double x, double y,double z)
        {
            return (x + y + z) ;
        }

        public static void WriteMyName()
        {
            Console.WriteLine("\n  Im The Best 😎");
        }

        public static void WriteMyNameAndMyAge(int age)
        {
            Console.WriteLine($"\n  Im The Best And My Age Is {age} 😎");
        }


        static void Main(string[] args)
        {


            //Logger LogtoScreenOBJ = new Logger(LogToScreen);

            //Logger LogtoFillOBJ = new Logger (LogToFill);


            //LogtoScreenOBJ.Log("Hi Im Zakaria The Best Of The Best");
            //LogtoFillOBJ.Log("Hi Im Zakaria The Best Of The Best");


            Calculator CalcAdd = new Calculator(Add);

            Calculator CalcSub = new Calculator(Sub);

            Calculator CalcMul = new Calculator(Mul);

            Calculator CalcDived = new Calculator(Devid);

            Console.WriteLine($"x + y =  {CalcAdd.OnCalcolation(22, 24)}");
            Console.WriteLine($"x - y =  {CalcSub.OnCalcolation(22, 24)}");
            Console.WriteLine($"x * y =  {CalcMul.OnCalcolation(22, 24)}");
            Console.WriteLine($"x / y =  {CalcDived.OnCalcolation(22, 24)}");

            Console.WriteLine("\n\n");

            // using Func Delegate
            double Result = Sum(22, 2, 24);

            Console.WriteLine($"The Sum Of The Three Numbers 22 + 2 + 24 = {Result} ");

            // using Normal Delegate
            SumDelegate SumDeleg = new SumDelegate(SumOf3Numbers);

            double Result2 = SumDeleg(22, 2, 24);
            Console.WriteLine($"The Sum Of The Three Numbers 22 + 2 + 24 = {Result2} ");

            // using Action Delegate

            MethosOfMyName();
            MethosOfMyNameAndMyAge(22);

            // Using predecate Delegate

            Console.WriteLine($"\n\n IsMy Age Above 20 ?? {IsMyAgeAbove20Predicate(22)} "); 

            Console.ReadKey();
        }
    }
}
