
#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

//#include "MyNumbersLib.h";

using namespace std;

struct stDate
{
	short year = 0;
	short month = 0;
	short day = 0;
};

struct StPerriod1
{
	stDate date1;
	stDate date2;
};

struct StPerriod2
{
	stDate date1;
	stDate date2;
};

short ReadNumbers(string message)
{
	short n = 0;

	cout << message;
	cin >> n;

	return n;
}

bool IsDate1EquallDate2(stDate Date1, stDate Date2)
{
	return  (Date1.year == Date2.year) ? ((Date1.month == Date2.month) ? ((Date1.day == Date2.day) ? true : false) : false) : false;
}

bool IsDate1LessThanDate2(stDate date1, stDate date2)
{
	return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
}

bool IsDate1AfterDate2(stDate date1, stDate date2)
{
	return !IsDate1LessThanDate2(date1, date2);
}


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

stDate ReadFullDate()
{
	stDate date;

	date.day = ReadNumbers("\n Please, Enter A Day? ");
	date.month = ReadNumbers("\n Please, Enter A Month? ");
	date.year = ReadNumbers("\n Please, Enter A Year? ");

	return date;
}

StPerriod1 ReadPeriod1()
{
	StPerriod1 Period1;

	cout << "\n Enter Start Date: \n";
	Period1.date1 = ReadFullDate();

	cout << "\n\n Enter End Date: \n";
	Period1.date2 = ReadFullDate();

	return Period1;
}

StPerriod2 ReadPeriod2()
{
	StPerriod2 Period2;

	cout << "\n Enter Start Date: ";
	Period2.date1 = ReadFullDate();

	cout << "\n\n Enter End Date: ";
	Period2.date2 = ReadFullDate();

	return Period2;
}

bool IsPeriodOverlap(StPerriod1 Period1, StPerriod2 Period2)
{
	while (IsDate1LessThanDate2(Period1.date1, Period1.date2))
	{
		if (IsDate1EquallDate2(Period1.date1, Period2.date1))
			return true;

		Period1.date1 = IncreaseDateByOneDay(Period1.date1);
	}

	return false;
}

void PrintResult()
{
	cout << "\n Enter Period 1  : ";
	StPerriod1 Period1 = ReadPeriod1();

	cout << "\n\n\n Enter Period 2  : ";
	StPerriod2 Period2 = ReadPeriod2();

	if (IsPeriodOverlap(Period1, Period2))
		cout << "\n Yes, Periods Overlap \n ";
	else
		cout << "\n No, Periods Is Not Overlap \n";
}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}