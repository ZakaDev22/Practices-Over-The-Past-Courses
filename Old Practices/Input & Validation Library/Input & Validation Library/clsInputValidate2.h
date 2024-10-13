#pragma once

#include <iostream>

using namespace std;


class clsInputValidate
{
public:

	/*static bool IsNumberBetween(int Number, int Number1, int Number2)
	{
		for (int i = Number1; i <= Number2; i++)
		{
			if (i == Number)
				return true;
		}
		return false;
	}*/

	static bool IsNumberBetween(int Number, int Number1, int Number2)
	{
		return ((Number > Number1) && (Number < Number2));
	}

	static bool IsNumberBetween(double Number, double Number1, double Number2)
	{
		return ((Number > Number1) && (Number < Number2));
	}

	// You need IsNumberBetween For Dates her...

	static int ReadIntNumber(string message)
	{
		int Number = 0;

		cout << "\n Enter, a Valid Number ? ";
		cin >> Number;

		while (cin.fail())
		{
			// user didn't input a number
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

			cout << message;
			cin >> Number;
		}

		return Number;
	}

	static double ReadDblNumber(string message)
	{
		double Number = 0;

		cout << "\n Enter, a Valid Number ? ";
		cin >> Number;

		while (cin.fail())
		{
			// user didn't input a number
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

			cout << message;
			cin >> Number;
		}

		return Number;
	}

	static int ReadIntNumberInRange(int From, int To, string message)
	{
		int Num = 0;
		cout << "\n Enter a Number ? ";
		cin >> Num;

		while ((Num < From) || (Num > To)) {

			cout << message;
			cin >> Num;

		}

		return Num;
	}

	static double ReadDblNumberInRange(double From, double To, string message)
	{
		double Num;

		cout << "\n Enter a Number ? ";
		cin >> Num;

		while ((Num < From) || (Num > To)) {

			cout << message;
			cin >> Num;

		}

		return Num;
	}
};

