using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class clsCalculator
{
    private int _Result = 0;
    private int _LastNumber = 0;

    private string _CalcName = string.Empty;

    private void _AddNumber(int Number)
    {
        _Result += Number;

        _LastNumber = Number;

        _CalcName = "Adding";
    }

    private void _SubstractNumber(int Number)
    {
        _Result -= Number;

        _LastNumber = Number;

        _CalcName = "Substracting";
    }

    private void _MultiplyNumber(int Number)
    {
        _Result *= Number;

        _LastNumber = Number;

        _CalcName = "Multiplying";
    }

    private void _DevideNumber(int Number)
    {
        if (Number < 1)
        {
            Number = 1;
        }

        _Result /= Number;

        _LastNumber = Number;

        _CalcName = "Dividing";
    }

    private void _PerformResults()
    {
        Console.WriteLine("Result After {0} {1} is : {2}", _CalcName, _LastNumber, _Result);

    }

    // Aplly PUBLIC Methods

    public void PrintResult()
    {
        _PerformResults();
    }

    public void Clear()
    {
        _Result = 0;

        _LastNumber = 0;

        _CalcName = "Clear";
    }

    public int Add(int Number)
    {
        _AddNumber(Number);

        return _Result;

    }

    public int Substract(int Number)
    {

        _SubstractNumber(Number);

        return _Result;
    }

    public int Multiply(int Number)
    {
        _MultiplyNumber(Number);

        return _Result;
    }

    public int Devide(int Number)
    {
        _DevideNumber(Number);

        return _Result;
    }
}

namespace Calculator
{


    internal class Program
    {


        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();

            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Substract(20);
            Calculator1.PrintResult();

            Calculator1.Devide(0);
            Calculator1.PrintResult();

            Calculator1.Devide(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();


            Console.ReadKey();
        }
    }
}
