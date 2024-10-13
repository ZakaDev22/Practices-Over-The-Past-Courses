
#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

#include "DateLib++.h";

//#include "MyNumbersLib.h";

using namespace std;

struct stDate
{
	short year = 0;
	short month = 0;
	short day = 0;
};

struct StPerriods
{
	stDate StartDate;
	stDate EndDate;
};


short ReadNumbers(string message)
{
	short n = 0;

	cout << message;
	cin >> n;

	return n;
}

stDate ReadFullDate()
{
	stDate date;

	date.day = ReadNumbers("\n Please, Enter A Day? ");
	date.month = ReadNumbers("\n Please, Enter A Month? ");
	date.year = ReadNumbers("\n Please, Enter A Year? ");

	return date;
}

StPerriods ReadPeriods()
{
	StPerriods Period;

	cout << "\n Enter Start Date: \n";
	Period.StartDate = ReadFullDate();

	cout << "\n\n Enter End Date: \n";
	Period.EndDate = ReadFullDate();

	return Period;
}

bool IsDate1LessThanDate2(stDate date1, stDate date2)
{
	return (date1.year < date2.year) ? true : ((date1.year == date2.year) ? (date1.month < date2.month ? true : (date1.month == date2.month ? date1.day < date2.day : false)) : false);
}

bool IsDate1EquallDate2(stDate Date1, stDate Date2)
{
	return  (Date1.year == Date2.year) ? ((Date1.month == Date2.month) ? ((Date1.day == Date2.day) ? true : false) : false) : false;
}

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

bool IsTheLastDayInMonth(stDate date)
{
	return (date.day == NumberOfDaysInAMonth(date.month, date.year));
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

bool IsDateWithinThisPeriod(StPerriods Period, stDate date)
{
	while (IsDate1LessThanDate2(Period.StartDate, Period.EndDate))
	{
		if (IsDate1EquallDate2(Period.StartDate, date))
			return true;

		Period.StartDate = IncreaseDateByOneDay(Period.StartDate);
	}

	return false;
}

void PrintResult()
{
	cout << "\n Enter Period 1  : ";
	StPerriods Period1 = ReadPeriods();

	cout << "\n Enter Date To check?  ";
	stDate date = ReadFullDate();

	if (IsDateWithinThisPeriod(Period1, date))
		cout << "\n Yes, Date Is Within Period \n";
	else
		cout << "\n No, Date Is Not In Within Period \n";
}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}