#pragma once

#include <iostream>

#include <string>


using namespace std;

 namespace MyNumbersLib
 {
	 

	 short ReadNumbers(string message)
	 {
		 short n = 0;

		 cout << message;
		 cin >> n;

		 return n;
	 }

	 bool IsDate1EquallDate2(short date1year, short date1month, short date1day, short date2year, short date2month, short date2day)
	 {
		 return  (date1year == date2year) ? ((date1month == date2month) ? ((date1day == date2day) ? true : false) : false) : false;
	 }

	 bool IsDate1LessThanDate2(short date1year,short date1month,short date1day, short date2year, short date2month, short date2day )
	 {
		 return (date1year < date2year) ? true : ((date1year == date2year) ? (date1month < date2month ? true : (date1month == date2month ? date1day < date2day : false)) : false);
	 }

	 bool IsDate1AfterDate2(short date1year, short date1month, short date1day, short date2year, short date2month, short date2day)
	 {
		 return !IsDate1LessThanDate2( date1year,  date1month,  date1day,  date2year,  date2month,  date2day) && !IsDate1EquallDate2(date1year, date1month, date1day, date2year, date2month, date2day);
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

 }


