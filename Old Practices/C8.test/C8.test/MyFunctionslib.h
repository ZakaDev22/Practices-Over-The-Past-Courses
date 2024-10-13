#pragma warning(disable : 4996)
#pragma once


#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

using namespace std;

static struct stDate
{
	short year = 0;
	short month = 0;
	short day = 0;
};


namespace MyIncreaseDateLib
{

	
	bool Is_LeapYear(short Year)
	{

		return ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0));

	}

	short NumberOfDaysInOneMonth(short Month, short Year)
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

	bool IsTheLastDayInMonth(stDate date)
	{
		return (date.day == NumberOfDaysInOneMonth(date.month, date.year));
	}

	bool IsTheLastMonthInYear(short Month)
	{
		return (Month == 12);
	}

	// Days Functions
	stDate IncreaseDateByOneDay(stDate date)
	{
		if (IsTheLastDayInMonth(date))
		{
			if (IsTheLastMonthInYear(date.month))
			{
				date.day = 1;
				date.month = 1;
				date.year++;
			}
			else
			{
				date.day = 1;
				date.month++;
			}
		}

		else
			date.day++;



		return date;
	}

	stDate IncreaseDateByXDay(stDate date, short XDays = 10)
	{


		for (short i = 1; i <= XDays; i++)
		{
			date = IncreaseDateByOneDay(date);
		}


		return date;
	}

	// Weeks Functions
	stDate IncreaseDateByOneWeek(stDate date)
	{

		for (short i = 1; i <= 7; i++)
		{
			date = IncreaseDateByOneDay(date);
		}

		return date;
	}

	stDate IncreaseDateByXWeek(stDate date, short Xweeks = 10)
	{

		for (short i = 1; i <= Xweeks; i++)
		{
			date = IncreaseDateByOneWeek(date);
		}

		return date;
	}

	// Months Functions
	stDate IncreaseDateByOneMonth(stDate date)
	{
		if (date.month == 12)
		{
			date.month = 1;
			date.year++;
		}
		else
			date.month++;

		short NumberOfDaysInCurrentMonth = NumberOfDaysInOneMonth(date.month, date.year);
		if (date.day > NumberOfDaysInCurrentMonth)
		{
			date.day = NumberOfDaysInCurrentMonth;
		}

		return date;
	}

	stDate IncreaseDateByXMonths(stDate date, short XMonths = 5)
	{
		for (short i = 1; i <= XMonths; i++)
		{
			date = IncreaseDateByOneMonth(date);
		}
		return date;
	}

	// Year Functions
	stDate IncreaseDateByOneYear(stDate date)
	{
		date.year++;

		return date;
	}

	stDate IncreaseDateByXYear(stDate date, int XYears = 10)
	{
		for (int i = 1; i <= XYears; i++)
		{
			date = IncreaseDateByOneYear(date);
		}

		return date;
	}

	stDate IncreaseDateByXYear_Faster(stDate date, int XYears = 10)
	{
		date.year += XYears;
		return date;
	}

	// Decades Functions
	stDate IncreaseDateByOneDecade(stDate date)
	{
		date.year += 10;
		return date;
	}

	stDate IncreaseDateByXDecade(stDate date, int XDecades = 10)
	{
		for (int i = 1; i <= XDecades; i++)
		{
			date = IncreaseDateByOneDecade(date);
		}
		return date;
	}

	stDate IncreaseDateByXDecade_Faster(stDate date, int XDecades = 10)
	{
		date.year += XDecades * 10;
		return date;
	}

	// Century End Millennium Functions
	stDate IncreaseDateByOneCentury(stDate date)
	{
		date.year += 100;
		return date;
	}

	stDate IncreaseDateByOneMillennium(stDate date)
	{
		date.year += 1000;
		return date;
	}
}

namespace MyDecreaseLib
{
	struct stDate
	{
		short year = 0;
		short month = 0;
		short day = 0;
	};

	bool Is_LeapYear(short Year)
	{

		return ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0));

	}

	short NumberOfDaysInAMonth(short Month, short Year)
	{

		if (Month < 1 || Month>12)
			return  0;

		int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
		return (Month == 2) ? (Is_LeapYear(Year) ? 29 : 28) : days[Month - 1];

	}

	short NumberOfDaysInOneMonth(short Month, short Year)
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

	bool IsTheFirstDayInMonth(stDate date)
	{
		return (date.day == 1);
	}

	bool IsTheFirstMonthInYear(short Month)
	{
		return (Month == 1);
	}

	// Days Functions
	stDate DecreaseDateByOneDay(stDate date)
	{
		if (IsTheFirstDayInMonth(date))
		{
			if (IsTheFirstMonthInYear(date.month))
			{
				date.year--;
				date.month = 12;
				date.day = NumberOfDaysInOneMonth(date.month, date.month);

			}
			else
			{
				date.month--;
				date.day = NumberOfDaysInOneMonth(date.month, date.year);
			}
		}

		else
			date.day--;



		return date;
	}

	stDate DecreaseDateByXDays(stDate date, int Xdays)
	{
		for (short i = 1; i <= Xdays; i++)
		{
			date = DecreaseDateByOneDay(date);
		}
		return date;
	}

	// Week Functions
	stDate DecreaseDateByOneWeek(stDate date)
	{
		for (short i = 1; i <= 7; i++)
		{
			date = DecreaseDateByOneDay(date);
		}
		return date;
	}

	stDate DecreaseDateByXWeeks(stDate date, int Xweeks)
	{
		for (int i = 1; i <= Xweeks; i++)
		{
			date = DecreaseDateByOneWeek(date);
		}
		return date;
	}

	// Months Functions
	stDate DecreaseDateByOneMonth(stDate date)
	{
		if (date.month == 1)
		{
			date.year--;
			date.month = 12;
		}
		else
			date.month--;

		short NumberOfDaysInCurrentMonth = NumberOfDaysInOneMonth(date.month, date.year);
		if (date.day > NumberOfDaysInCurrentMonth)
		{
			date.day = NumberOfDaysInCurrentMonth;
		}

		return date;
	}

	stDate DecreaseDateByXMonths(stDate date, int XMonths)
	{
		for (int i = 1; i <= XMonths; i++)
		{
			date = DecreaseDateByOneMonth(date);
		}

		return date;
	}

	// Years Functions
	stDate DecreaseDateByOneYear(stDate date)
	{
		date.year--;
		return date;
	}

	stDate DecreaseDateByXYears(stDate date, int XYears)
	{
		for (int i = 1; i <= XYears; i++)
		{
			date = DecreaseDateByOneYear(date);
		}

		return date;
	}

	stDate DecreaseDateByXYears_Faster(stDate date, int XYears)
	{
		date.year -= XYears;
		return date;
	}

	// Decades Functions
	stDate DecreaseDateByOneDecade(stDate date)
	{
		date.year -= 10;
		return date;
	}

	stDate DecreaseDateByXDecades(stDate date, int XDecade)
	{
		for (int i = 1; i <= XDecade; i++)
		{
			date = DecreaseDateByOneDecade(date);
		}

		return date;
	}

	stDate DecreaseDateByXDecades_Faster(stDate date, int XDecade)
	{
		date.year -= XDecade * 10;
		return date;
	}

	// Century and Millennium Functions
	stDate DecreaseDateByOneCentury(stDate date)
	{
		date.year -= 100;
		return date;
	}

	stDate DecreaseDateByOneMillennium(stDate date)
	{
		date.year -= 1000;
		return date;
	}

}


namespace MyCalculateDateLib
{
	struct stDate
	{
		short year = 0;
		short month = 0;
		short day = 0;
	};

	bool IsDate1LessThanDate2(stDate date1, stDate date2)
	{
		return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
	}

	int DifferenceDaysBetweenDate1EndDate2(stDate date, stDate date2, bool encludingEndDay = false)
	{
		int Days = 0;

		while (IsDate1LessThanDate2(date, date2))
		{
			Days++;
			date = IncreaseDateByOneDay(date);
		}

		return encludingEndDay ? ++Days : Days;
	}

	


	// counting All days From the begening of the year.
	short SumOfAllDaysFromTheBIgining(short year, short month, short days)
	{
		short totalDays = 0;

		for (short i = 1; i <= month - 1; i++)
		{
			totalDays += NumberOfDaysInOneMonth(i, year);
		}

		totalDays += days;

		return totalDays;
	}

	// print Calendar
	void PrintAMonthCalendar(short Month, short Year) 
	{
		short NUmberOFDays;

		short current = CulculateTheOrderDay(Year, Month, 1);

		NUmberOFDays = NumberOfDaysInOneMonth(Month, Year);

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

	// Gregorian Calendar :
	//0:sun, 1:Mon, 2:Tue...etc
	short CulculateTheOrderDay(short Year, short Month, short Day)
	{
		short a = ((14 - Month) / 12);

		short y = Year - a;

		short m = Month + 12 * a - 2;

		return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

	}

	short CulculateTheOrderDay(stDate date)
	{

		return CulculateTheOrderDay(date.day, date.month, date.year);

	}

	// chack if its A Leap Year.
	bool Is_LeapYear(short Year)
	{

		return ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0));

	}

	// count Days in a Year
	short NumberOfDaysInOneYear(short Year)
	{
		return (Is_LeapYear(Year) ? 366 : 365);
	}

	// coutn Hours in a Year
	short NumberOfHoursInOneYear(short Year)
	{
		return NumberOfDaysInOneYear(Year) * 24;
	}

	// count minutes in a Year
	int NumberOfMinutesInOneYear(short Year)
	{
		return NumberOfHoursInOneYear(Year) * 60;
	}

	// count Seconds in a Year
	int NumberOfSecondInOneYear(short Year)
	{
		return NumberOfMinutesInOneYear(Year) * 60;
	}

	//-------------------------------------------------//
	// This Function To Count D-H-M-S In Amonth 
	short NumberOfDaysInOneMonth(short Month, short Year)
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


	short NumberOfHoursInOneMonth(short Month, short Year)
	{
		return NumberOfDaysInOneMonth(Month, Year) * 24;
	}

	int NumberOfMenutessInOneMonth(short Month, short Year)
	{
		return NumberOfHoursInOneMonth(Month, Year) * 60;
	}

	int NumberOfSecondsInOneMonth(short Month, short Year)
	{
		return NumberOfMenutessInOneMonth(Month, Year) * 60;
	}
	//-------------------------------------------------//

	bool IsTheLastDayInMonth(stDate date)
	{
		return (date.day == NumberOfDaysInOneMonth(date.month, date.year));
	}

	bool IsTheLastMonthInYear(short Month)
	{
		return (Month == 12);
	}


	stDate IncreaseDateByOneDay(stDate date)
	{
		if (IsTheLastDayInMonth(date))
		{
			if (IsTheLastMonthInYear(date.month))
			{
				date.day = 1;
				date.month = 1;
				date.year++;
			}
			else
			{
				date.day = 1;
				date.month++;
			}
		}

		else
			date.day++;

		return date;
	}

	void SwapDates(stDate& date, stDate& date2)
	{
		stDate TempDate;

		TempDate.year = date.year;
		TempDate.month = date.month;
		TempDate.day = date.day;

		date.year = date2.year;
		date.month = date2.month;
		date.day = date2.day;

		date2.year = TempDate.year;
		date2.month = TempDate.month;
		date2.day = TempDate.day;

	}
}

