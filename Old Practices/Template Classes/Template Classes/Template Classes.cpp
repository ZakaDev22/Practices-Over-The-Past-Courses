
#include <iostream>
#include "clsCalculator.h"
#include "clsInputValidate.h"

using namespace std;


int main()
{
  
	if (clsInputValidate::IsNumberBetween<int>(21, 19, 24))
	{
		cout << "\n\nhhhhhhhhhhhhhhh\n\n";
	}
	else
	{
		cout << "\nhihihiihihihihihi\n\n";
	}

	clsCalculator <int> Calc1(21, 24);

	clsCalculator <float> Calc2(21.6, 24.9);

	cout << "\n\t\t\t Int Calculator : \n";
	Calc1.PrintResults();

	cout << "\n\t\t\t float Calculator : \n";
	Calc2.PrintResults();

	return 0;
}
