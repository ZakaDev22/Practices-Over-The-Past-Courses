#pragma once

#include <iostream>

using namespace std;


namespace mysum
{
	 int MySum(int a, int b) 
	{
		return (a + b);
	}

	double MySum(double a, double b)
	{
		return (a + b);
	}

	int MySum(int a, int b, int c)
	{
		return (a + b + c);
	}


}