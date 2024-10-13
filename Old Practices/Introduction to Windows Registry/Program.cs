using Microsoft.Win32;
using System;

namespace Introduction_to_Windows_Registry
{
    internal class Program
    {


        static void Main(string[] args)
        {



            string KeyPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\DVLdTest";
            // string KeyPath = "HKEY_CURRENT_USER\\SOFTWARE\\DVLdTest";

            string KeyName = "ThisIsMyProjectName";
            string KeyValue = "2002211";

            try
            {
                Registry.SetValue(KeyPath, KeyName, KeyValue, RegistryValueKind.String);

                Console.WriteLine($"Value {KeyValue} successfully written to the Registry.");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            //string Value;

            //try
            //{
            //    Value = Registry.GetValue(KeyPath, KeyName, null) as string;

            //    if (Value != null)
            //    {
            //        Console.WriteLine($"The value of {KeyName} is: {Value}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Value {KeyName} not found in the Registry.");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}

            Console.ReadKey();
        }
    }
}
