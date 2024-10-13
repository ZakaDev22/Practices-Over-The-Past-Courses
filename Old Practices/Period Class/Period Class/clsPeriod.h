#pragma once
#include "clsDate.h"

class clsPeriod
{
private:
    clsDate StartDate;
    clsDate EndDate;

public:

    clsPeriod(clsDate StartDate, clsDate EndDate)
    {
        this->StartDate = StartDate;
        this->EndDate = EndDate;

    }

    // property Set
    void SetPeriod(clsDate StartDate,clsDate EndDtae)
    {
        this->StartDate = StartDate;
        this->EndDate = EndDtae;
    }

    clsPeriod GetPeriod()
    {
        return clsPeriod(this->StartDate, this->EndDate);
    }

    __declspec(property(get = GetEndDate, put = SetEndDate)) clsDate EndDate;

    //---------------------------------------------------------------------//

    static bool IsOverlapPeriods(clsPeriod Period1, clsPeriod Period2)
    {

        if (
            clsDate::CompareDates(Period2.EndDate, Period1.StartDate) == clsDate::enDateCompare::Before
            ||
            clsDate::CompareDates(Period2.StartDate, Period1.EndDate) == clsDate::enDateCompare::After
            )
            return false;
        else
            return true;

    }


    bool IsOverLapWith(clsPeriod Period2)
    {
        return IsOverlapPeriods(*this, Period2);
    }

    void Print()
    {
        cout << "Period Start: ";
        StartDate.Print();


        cout << "Period End: ";
        EndDate.Print();


    }

    static short CalculatePeriodLengthInDays(clsPeriod Period, bool IncludeingEndDay = false)
    {
        return clsDate::GetDifferenceInDays(Period.StartDate, Period.EndDate, IncludeingEndDay);
    }

    short CalculatePeriodLengthInDays()
    {
        return CalculatePeriodLengthInDays(*this);
    }

};
