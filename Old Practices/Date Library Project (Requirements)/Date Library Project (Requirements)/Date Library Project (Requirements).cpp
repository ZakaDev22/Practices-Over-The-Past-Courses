
#include <iostream>
#include <string>

#include "clsDate.h";
#include "clsString.h";


using namespace std;

int main()
{
   
    clsDate date1(11, 2, 2002);

    clsDate date2("10/2/2001");

    clsDate date3;

    date3.Print();
    cout << date3.SumOfAllDaysFromTheBigining() << endl;

  //  cout << date1.IsTheLastDayInMonth() << endl;
    date1.Print();

    //date2.IncreaseDateByOneDay();
    date2.Print();

   // cout << date2.IsDate1LessThanDate2(date1);

  //  cout << date2.DifferenceDaysBetweenDate1EndDate2(date1,true);

   // cout << date1.SumOfAllDaysFromTheBigining(date1);

    // date1.PrintAMonthCalendar();

    cout << "\n Number of seconds in this year : " << date1.NumberOfSecondInOneYear();


    system("pause>0");
    return 0;
}
