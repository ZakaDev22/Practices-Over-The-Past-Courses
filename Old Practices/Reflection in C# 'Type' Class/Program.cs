using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_in_C___Type__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Type MyType = typeof(DateTime);

            Console.WriteLine(MyType.FullName);
            Console.WriteLine(MyType.IsClass);
            Console.WriteLine(MyType.IsInterface);
            Console.WriteLine(MyType.IsEnum);
            Console.WriteLine(MyType.IsArray);

            


            // Get the assembly containing the System.String type
            Assembly mscorlib = typeof(string).Assembly;


            // Get the System.String type
            Type stringType = mscorlib.GetType("System.string");


            if (stringType != null)
            {
                Console.WriteLine($"Methods of the System.String class:\n");


                // Get all public methods of the System.String class
                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .OrderBy(method => method.Name);


                foreach (var method in stringMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine("System.String type not found.");
            }


            // I Use Special Comments In This Method
            add(22, 24);

            
            Console.ReadKey();


        }

        /// <summary>
        /// this method will Get A List Arrays Of Parrameters And Return Them In One String
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }

        /// <summary>
        /// hhhhhhhhhhhhhhhhhhhhh
        /// </summary>
        /// <param name="num"></param>
        /// <param name="num2"></param>
        static void add(int num,int num2)
        {
            
        }
    }
}
