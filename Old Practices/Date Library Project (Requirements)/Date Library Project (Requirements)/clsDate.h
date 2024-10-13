#pragma once
#pragma warning(disable : 4996)

#include <iostream>
#include <ctime>
#include <string>
#include <vector>

#include "clsString.h";

using namespace std;

class clsDate
{
private :

	int   _Year;
	short _Day;
	short _Month;


public :

	clsDate()
	{
		time_t t = time(0);
		tm* now = localtime(&t);

		_Year = now->tm_year + 1900;
		_Month = now->tm_mon + 1;
		_Day = now->tm_mday;
	}

	clsDate(short Day, short Month, int Year)
	{
		_Year = Year;
		_Day = Day;
		_Month = Month;
	}

	clsDate(string date)
	{
		vector <string> vwords = clsString::Split(date, "/");

		_Day = stoi(vwords[0]);
		_Month = stoi(vwords[1]);
		_Year = stoi(vwords[2]);
	}

	//----------------------------------------------------------//

	// property Set
	void SetYear(int Year)
	{
		_Year = Year;
	}

	// property Get
	int GetYear()
	{
		return _Year;
	}
	__declspec(property(get = GetYear, put = SetYear)) int Year;

	// property Set
	void SetMonth(short Month)
	{
		_Month = Month;
	}

	// property Get
	short GetMonth()
	{
		return _Month;
	}
	__declspec(property(get = GetMonth, put = SetMonth)) short Month;

	// property Set
	void SetDay(short Day)
	{
		_Day = Day;
	}

	// property Get
	short GetDay()
	{
		return _Day;
	}
	__declspec(property(get = GetDay, put = SetDay)) short Day;

	void Print()
	{
		cout << _Day << "/" << _Month << "/" << _Year << endl;
	}

	//--------------------------------------------------------//

	static bool Is_LeapYear(short Year)
	{

		return ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0));

	}

	bool Is_LeapYear() {

		return   Is_LeapYear(_Year);
	}

	static short NumberOfDaysInOneMonth(short Month, short Year)
	{
		if (Month < 1 || Month > 12)
		{
			return 0;
		}

		short NumberOfDays[13];

		NumberOfDays[0] = 0, NumberOfDays[1] = 31, NumberOfDays[2] = 28, NumberOfDays[3] = 31, NumberOfDays[4] = 30, NumberOfDays[5] = 31, NumberOfDays[6] = 30;
		NumberOfDays[7] = 31, NumberOfDays[8] = 31, NumberOfDays[9] = 30, NumberOfDays[10] = 31, NumberOfDays[11] = 30, NumberOfDays[12] = 31;

		return (Month == 2) ? (Is_LeapYear(Year) ? 29 : 28) : NumberOfDays[Month];
	}

	short NumberOfDaysInOneMonth()
	{
		return   NumberOfDaysInOneMonth(_Month, _Year);
	}


	static bool IsTheLastDayInMonth(clsDate date)
	{
		return (date.Day == NumberOfDaysInOneMonth(date.Month, date.Year));
	}

	bool IsTheLastDayInMonth()
	{
		return IsTheLastDayInMonth(*this);
	}

	static bool IsTheLastMonthInYear(short Month)
	{
		return (Month == 12);
	}

	bool IsTheLastMonthInYear()
	{
		return IsTheLastMonthInYear(this->Month);
	}

	static bool IsTheFirstDayInMonth(short Month)
	{
		return (Month == 1);
	}

	bool IsTheFirstDayInMonth()
	{
		return IsTheFirstDayInMonth(this->Month);
	}

	static bool IsDate1LessThanDate2(clsDate date1, clsDate date2)
	{
		return (date1.Year < date2.Year) ? true : ((date1.Year == date2.Year) ? (date1.Year < date2.Month ? true : (date1.Month == date2.Month ? date1.Day < date2.Day : false)) : false);
	}

	bool IsDate1LessThanDate2( clsDate date2)
	{
		return IsDate1LessThanDate2(*this, date2);
	}

	// Days Functions
	static clsDate IncreaseDateByOneDay(clsDate date)
	{
		if (IsTheLastDayInMonth(date))
		{
			if (IsTheLastMonthInYear(date.Month))
			{
				date.Day = 1;
				date.Month = 1;
				date.Year++;
			}
			else
			{
				date.Day = 1;
				date.Month++;
			}
		}

		else
			date.Day++;



		return date;
	}

	clsDate IncreaseDateByOneDay()
	{
		return  IncreaseDateByOneDay(*this);
	}

	static int DifferenceDaysBetweenDate1EndDate2(clsDate date, clsDate date2, bool encludingEndDay = false)
	{
		int Days = 0;

		while (IsDate1LessThanDate2(date, date2))
		{
			Days++;
			date = IncreaseDateByOneDay(date);
		}

		return encludingEndDay ? ++Days : Days;
	}

	
	int DifferenceDaysBetweenDate1EndDate2( clsDate date2, bool encludingEndDay = false)
	{
		return  DifferenceDaysBetweenDate1EndDate2(*this, date2, encludingEndDay);
	}

	// counting All days From the begening of the year.
	static short SumOfAllDaysFromTheBigining(clsDate date)
	{
		short totalDays = 0;

		for (short i = 1; i <= date.Month - 1; i++)
		{
			totalDays += NumberOfDaysInOneMonth(i, date.Year);
		}

		totalDays += date.Day;

		return totalDays;
	}

	short SumOfAllDaysFromTheBigining()
	{
		return SumOfAllDaysFromTheBigining(*this);
	}

	// Gregorian Calendar :
	//0:sun, 1:Mon, 2:Tue...etc
	static short CalculateTheOrderDay(short Year, short Month, short Day)
	{
		short a = ((14 - Month) / 12);

		short y = Year - a;

		short m = Month + 12 * a - 2;

		return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

	}

	static short CalculateTheOrderDay(clsDate date)
	{
		return  CalculateTheOrderDay(date.Year, date.Month, date.Day);
	}
	
	short CalculateTheOrderDay()
	{
		return  CalculateTheOrderDay(this->Day, this->Month, this->Year);
	}

	// print Calendar
     static  void PrintAMonthCalendar(clsDate date)
	{
		short NUmberOFDays;

		short current = CalculateTheOrderDay(date);

		NUmberOFDays = NumberOfDaysInOneMonth(date.Month, date.Year);

		printf("\n_________________%s_________________\n\n", "Feb" /*MonthOrder(Month).c_str()*/);

		printf("  Sun  Mon  Tue  Wed  Thu  Fri  Sat\n");

		short i;
		for (i = 0; i < current; i++)
			printf("     ");


		for (short j = 1; j <= NUmberOFDays; j++)
		{
			printf("%5d", j);

			if (++i == 7)
			{
				i = 0;
				printf("\n");
			}
		}
		printf("\n_____________________________________\n\n");
	}

	 void PrintAMonthCalendar()
	 {
		 PrintAMonthCalendar(*this);
	 }

	/*static void PrintA_YearCalendar(clsDate date)
	 {
		 printf("\n_____________________________________\n");
		 printf("\n            Calendar - %d \n", date.Year);
		 printf("_____________________________________\n");

		 for (short i = 1; i <= 12; i++)
		 {
			 PrintAMonthCalendar(date);
		 }
	 }*/


	 // count Days in a Year
	 static short NumberOfDaysInOneYear(short Year)
	 {
		 return (Is_LeapYear(Year) ? 366 : 365);
	 }

	 short NumberOfDaysInOneYear()
	 {
		 return  NumberOfDaysInOneYear(this->Year);
	 }

	 // count Hours in a Year
	static short NumberOfHoursInOneYear(short Year)
	 {
		 return NumberOfDaysInOneYear(Year) * 24;
	 }

	short NumberOfHoursInOneYear()
	{
		return  NumberOfHoursInOneYear(this->Year);
	}

	 // count minutes in a Year
	static int NumberOfMinutesInOneYear(short Year)
	 {
		 return NumberOfHoursInOneYear(Year) * 60;
	 }

	int NumberOfMinutesInOneYear()
	{
		return  NumberOfMinutesInOneYear(this->Year);
	}

	 // count Seconds in a Year
	 static int NumberOfSecondInOneYear(short Year)
	 {
		 return NumberOfMinutesInOneYear(Year) * 60;
	 }

	 int NumberOfSecondInOneYear()
	 {
		 return  NumberOfSecondInOneYear(this->Year);
	 }

};

