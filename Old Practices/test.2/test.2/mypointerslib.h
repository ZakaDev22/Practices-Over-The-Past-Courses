#pragma once

#include <iostream>

using namespace std;



namespace myptrlib
{
	void SwapNambers(int* a, int* b)
	{
		int temp = 0;

		temp = *a;
		*a = *b;
		*b = temp;
	}
}