
#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

using namespace std;

struct stDate
{
	short year = 0;
	short month = 0;
	short day = 0;
};

short ReadNumbers(string message)
{
	short n = 0;

	cout << message;
	cin >> n;

	return n;
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

bool IsValideDate(stDate date)
{
	return  !((date.day != NumberOfDaysInAMonth(date.month, date.year)) || (date.month < 1 || date.month > 12)) ? true : false;
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
	cout << "\n Enter a Date  : ";
	stDate date = ReadFullDate();

	if (IsValideDate(date))
		cout << "\n Yes, Date is a Valide date " << endl;
	else
		cout << "\n No, Date is Not a Valide date " << endl;

}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}