using System;


namespace Lambda_Expression
{
    internal class Program
    {
        public delegate int Operations(int x,int y);

        public static int SumOf2Numbers(int x,int y)
        {
            return x + y;
        }

        public static int SubOf2Numbers(int x, int y)
        {
            return x - y;
        }

        public static void PrintResult(int x,int y, Func<int,int,int> Operation)
        {
            int result = Operation(x,y);

            Console.WriteLine($"Result = {result}");
        }

        static void Main(string[] args)
        {

            Operations AddFunc = new Operations(SumOf2Numbers);
            int AddResult = AddFunc(22, 24);


            Operations SubFunc = new Operations(SubOf2Numbers);
            int SubResult = SubFunc(22, 24);


            Console.WriteLine($"Sum Of x + Y = {AddResult}");
            Console.WriteLine($"Sub Of x - Y = {SubResult}");

            //
            //

            Console.WriteLine("\n\n");

           Func<int,int,int> Sum = (x,y) => x + y;
            Func<int, int, int> Sub = (x, y) => x - y;

            PrintResult(32, 24, Sum);
            PrintResult(32, 24, Sub);




            Console.ReadKey();
        }
    }
}
