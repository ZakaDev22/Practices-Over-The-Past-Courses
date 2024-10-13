#pragma once

#include <iostream>

using namespace std;


namespace myinputslib
{

	short readnumbers()
	{
		short num = 0;

		cout << " please enter the number you want in the static variabel : " << endl;
		cin >> num;

		return num;
	}
}