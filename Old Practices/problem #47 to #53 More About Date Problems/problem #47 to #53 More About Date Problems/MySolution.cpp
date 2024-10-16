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

// Overload The day of Week Order to take a date structure
short CulculateTheOrderDay(stDate date)
{
	short a = ((14 - date.month) / 12);

	short y = date.year - a;

	short m = date.month + 12 * a - 2;

	return (date.day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

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
	short dayorder = CulculateTheOrderDay(date);

	return (dayorder == 0) || (dayorder == 1) || (dayorder == 2) || (dayorder == 3) || (dayorder == 4);
}

short DaysUntilTheEndOfWeek(stDate date)
{
	short dayorder = CulculateTheOrderDay(date);

	short count = 0;

	for (short i = dayorder; i < 6; i++)
	{
		count++;
	}

	return count;
}

short DaysUntilTheEndOfMonth(stDate date)
{
	short dayNumber = date.day;
	short NumberOfDaysInMonth = NumberOfDaysInOneMonth(date.month, date.year);
	short count = 0;

	for (short i = dayNumber; i <= NumberOfDaysInMonth; i++)
	{
		count++;
	}

	return count;
}

short DaysUntilTheEndOfYear(stDate date)
{
	short count = DaysUntilTheEndOfMonth(date);

	while (true)
	{
		date.month++;

		count += NumberOfDaysInOneMonth(date.month, date.year);

		if (date.month == 12)
			break;
	}

	return count;
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
	stDate date = ReadFullDate();
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