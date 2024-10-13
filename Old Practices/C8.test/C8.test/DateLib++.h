
#pragma once

#include <iostream>

using namespace std;


namespace MyDate
{
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

	stDate ReadFullDate()
	{
		stDate date;

		date.day = ReadNumbers("\n Please, Enter A Day? ");
		date.month = ReadNumbers("\n Please, Enter A Month? ");
		date.year = ReadNumbers("\n Please, Enter A Year? ");

		return date;
	}


	struct StPerriods
	{
		stDate StartDate;
		stDate EndDate;
	};

	StPerriods ReadPeriod()
	{
		StPerriods Period1;

		cout << "\n Enter Start Date: \n";
		Period1.StartDate = ReadFullDate();

		cout << "\n\n Enter End Date: \n";
		Period1.EndDate = ReadFullDate();

		return Period1;
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

	int PeriodLengthInDays(StPerriods Period, bool encludingEndDay = false)
	{
		return DifferenceDaysBetweenDate1EndDate2(Period.StartDate, Period.EndDate, encludingEndDay);
	}

	bool IsDateWithinThisPeriod(StPerriods Period, stDate date)
	{
		return !(CompareDates(date, Period.StartDate) == enDate::befor || CompareDates(date, Period.EndDate) == enDate::after);
	}

	/*int CountOverlapDays(StPerriods Period1, StPerriods Period2)
	{
		int Period1Length = PeriodLengthInDays(Period1, true);
		int Period2Length = PeriodLengthInDays(Period2, true);

		int OverlapDays = 0;

		if (!IsPeriodOverlap(Period1, Period2))
			return 0;

		if (Period1Length < Period2Length)
		{
			while (IsDate1LessThanDate2(Period1.StartDate, Period1.EndDate))
			{
				if (IsDateWithinThisPeriod(Period1.StartDate, Period2))
					OverlapDays++;

				Period1.StartDate = IncreaseDateByOneDay(Period1.StartDate);
			}
		}

		else
		{
			while (IsDate1LessThanDate2(Period2.StartDate, Period2.EndDate))
			{
				if (IsDateWithinThisPeriod(Period2.StartDate, Period1))
					OverlapDays++;

				Period2.StartDate = IncreaseDateByOneDay(Period2.StartDate);
			}
		}

		return OverlapDays;
	}*/


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

	bool IsValideDate(stDate date)
	{
		return  !((date.day != NumberOfDaysInAMonth(date.month, date.year)) || (date.month < 1 || date.month > 12)) ? true : false;
	}


}
