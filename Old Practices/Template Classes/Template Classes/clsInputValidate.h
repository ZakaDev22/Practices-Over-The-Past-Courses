
#pragma once
#include <iostream>
#include <string>
#include "clsString.h";
#include "clsDate.h";

using namespace std;

class clsInputValidate
{
public:

	// Template Function.

	template<typename T> static bool IsNumberBetween(T Num, T From, T To)
	{
		return (Num >= From && Num <= To);
	}

	static bool IsDateBetween(clsDate Date, clsDate DateFrom, clsDate DateTo)
	{
		if (clsDate::IsDate1AfterDate2(DateFrom, DateTo))
		{
			clsDate::SwapDates(DateFrom, DateTo);
		}

		return ((clsDate::IsDate1AfterDate2(Date, DateFrom) || clsDate::IsDate1EqualDate2(Date, DateFrom)) && (clsDate::IsDate1BeforeDate2(Date, DateTo) || clsDate::IsDate1EqualDate2(Date, DateTo)));
	}

	// Template Function.

	template <typename T> static T ReadNumber(string ErrorMessage = "Invalid Number, Enter again : \n")
	{
		T Number;

		while (!(cin >> Number))
		{
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << ErrorMessage;
		}

		return Number;
	}

	// Template Function.

	template <typename T> static T ReadNumberBetween(T From, T To, string ErrorMessage = "Number is not within range, Enter again : \n")
	{
		T Number = ReadNumber<T>();

		while (!IsNumberBetween(Number, From, To))
		{
			cout << ErrorMessage;
			Number = ReadNumber<T>();
		}

		return Number;
	}

	static bool IsValidDate(clsDate Date)
	{
		return clsDate::IsValidDate(Date);
	}

	static string ReadString()
	{
		string S1 = "";
		getline(cin >> ws, S1);
		return S1;
	}




};