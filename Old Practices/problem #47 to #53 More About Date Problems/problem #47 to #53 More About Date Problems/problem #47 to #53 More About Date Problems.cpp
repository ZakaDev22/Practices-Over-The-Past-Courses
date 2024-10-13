#pragma warning(disable : 4996)

#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

using namespace std;

short ReadNumbers(string message)
{
	short n = 0;

	cout << message;
	cin >> n;

	return n;
}

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

bool IsTheLastMonthInYear(short Month)
{
	return (Month == 12);
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

stDate IncreaseDateByOneDay(stDate date)
{
	if (date.day == NumberOfDaysInOneMonth(date.month, date.year))
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


short CulculateTheOrderDay(short day, short month, short year)
{
	short a = ((14 - month) / 12);

	short y = year - a;

	short m = month + 12 * a - 2;

	return (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

}

// Overload The day of Week Order to take a date structure
short CulculateTheOrderDay(stDate date)
{

	return CulculateTheOrderDay(date.day, date.month, date.year);

}

string NameOfOrderDay(short OrderDay)
{

	string arrDays[7] = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

	return arrDays[OrderDay];
}

void PrintTheDayOfWeekOrder(stDate date)
{
	short dayorder = CulculateTheOrderDay(date);

	string dayName = NameOfOrderDay(dayorder);

	printf("\n Today is %s , %d/%d/%d \n", dayName.c_str(), date.day, date.month, date.year);

}

bool IsEndOfWeek(stDate date)
{
	short dayorder = CulculateTheOrderDay(date);

	return dayorder == 6;
}

bool IsWeekEnd(stDate date)
{
	short dayorder = CulculateTheOrderDay(date);

	return (dayorder == 5) || (dayorder == 6);
}

bool IsBusinessDay(stDate date)
{
	return !IsWeekEnd(date);
}

short DaysUntilTheEndOfWeek(stDate date)
{
	return  6 - CulculateTheOrderDay(date);
}

short DaysUntilTheEndOfMonth(stDate date)
{
	stDate EndOfTheMonthDate;

	EndOfTheMonthDate.day = NumberOfDaysInOneMonth(date.month, date.year);
	EndOfTheMonthDate.month = date.month;
	EndOfTheMonthDate.year = date.year;

	return DifferenceDaysBetweenDate1EndDate2(date, EndOfTheMonthDate, true);
}

short DaysUntilTheEndOfYear(stDate date)
{
	stDate EndOfTheYearDate;

	EndOfTheYearDate.day = 31;
	EndOfTheYearDate.month = 12;
	EndOfTheYearDate.year = date.year;

	return DifferenceDaysBetweenDate1EndDate2(date, EndOfTheYearDate, true);
}

stDate GetSustemDate()
{
	stDate date2;

	time_t t = time(0);

	tm* Now = localtime(&t);

	date2.year = Now->tm_year + 1900;
	date2.month = Now->tm_mon + 1;
	date2.day = Now->tm_mday;

	return date2;
}

void PrintResult()
{
	stDate date = GetSustemDate();
	printf("\n");

	// print name of day order
	PrintTheDayOfWeekOrder(date);

	// End Of Week
	cout << "\n Is it End Of Week? \n";

	if (IsEndOfWeek(date))
		cout << " Yes, It is End Of Week.\n";
	else
		cout << " No, It is Not End Of Week.\n";

	// Is it Week End
	cout << "\n Is it Weekend? \n";

	if (IsWeekEnd(date))
		cout << " Yes, It is Weekend.\n";
	else
		cout << " No, It is Week End.\n";

	// Is it Business Day
	cout << "\n Is it Business Day? \n";

	if (IsBusinessDay(date))
		cout << " Yes, It is Business Day.\n";
	else
		cout << " No, It Not a Business Day.\n";

	// days until the of week
	printf("\n Days Until The End Of Week is : %d Day(s). \n", DaysUntilTheEndOfWeek(date));

	// days until the of Month
	printf(" Days Until The End Of Month is : %d Day(s). \n", DaysUntilTheEndOfMonth(date));

	// days until the of Year
	printf(" Days Until The End Of Year is : %d Day(s). \n", DaysUntilTheEndOfYear(date));

}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}