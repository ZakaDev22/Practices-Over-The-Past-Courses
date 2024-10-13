
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

enum enDate
{
	befor = -1, equall = 0, after = 1
};

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

enDate CompareDates(stDate date1, stDate date2)
{
	if (IsDate1LessThanDate2(date1, date2))
		return enDate::befor;

	else if (IsDate1EquallDate2(date1, date2))
		return enDate::equall;

	else
		return enDate::after;

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


bool IsPeriodOverlap(StPerriods Period1, StPerriods Period2)
{
	if (
		CompareDates(Period2.EndDate, Period1.StartDate) == enDate::befor
		||
		CompareDates(Period2.StartDate, Period1.EndDate) == enDate::after
		)
		return false;
	else
		return true;

}

void PrintResult()
{
	cout << "\n Enter Period 1  : ";
	StPerriods Period1 = ReadPeriods();

	cout << "\n\n\n Enter Period 2  : ";
	StPerriods Period2 = ReadPeriods();

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