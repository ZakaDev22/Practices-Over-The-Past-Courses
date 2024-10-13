#pragma once

#include <iostream>

using namespace std;


namespace myinputlib
{

	short readAge()
	{
		short age = 0;
		cout << "please enter your age :" << endl;

		cin >> age;

		return age;
	}
}