
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

short CulculateTheOrderDay(short Year, short Month, short Day)
{
	short a = ((14 - Month) / 12);

	short y = Year - a;

	short m = Month + 12 * a - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

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

	printf(" %s , %d/%d/%d \n", dayName.c_str(), date.day, date.month, date.year);

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

short CulculateVocationDays(stDate date, stDate date2)
{
	short Dayscount = 0;


	while (IsDate1LessThanDate2(date, date2))
	{
		if (IsBusinessDay(date))
			Dayscount++;

		date = IncreaseDateByOneDay(date);
	}


	return Dayscount;
}

stDate ReadFullDate()
{
	stDate date;

	date.day = ReadNumbers("\n Please, Enter A Day? ");
	date.month = ReadNumbers("\n Please, Enter A Month? ");
	date.year = ReadNumbers("\n Please, Enter A Year? ");

	return date;
}

void PrintResult()
{
	cout << "\n Vocation Starts : \n";
	stDate date = ReadFullDate();
	printf("\n");
	cout << "\n Vocation Ends : \n";
	stDate date2 = ReadFullDate();

	cout << "\n vocation From : ";
	PrintTheDayOfWeekOrder(date);

	cout << "\n vocation to  : ";
	PrintTheDayOfWeekOrder(date2);

	cout << "\n Actucal Vocation Days is : ";
	cout << CulculateVocationDays(date, date2);
}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}