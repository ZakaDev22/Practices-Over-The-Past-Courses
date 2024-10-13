
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
    internal class Program
    {


        struct stStudent
        {
            public string FirstName;
            public string LastName;
            public byte MyAge;
        }

        static void Main(string[] args)
        {

            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            stStudent Student;
            stStudent Student2 = new stStudent();


            Student.FirstName = "Mohammed";
            Student.LastName = "Abu-Hadhoud";
            Student.MyAge = 21;


            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);
            Console.WriteLine(Student.MyAge);


            Student2.FirstName = "Ali";
            Student2.LastName = "Ahmed";
            Student2.MyAge = 20;



            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);
            Console.WriteLine(Student2.MyAge);

            Console.ReadKey();

        }
    }
}
