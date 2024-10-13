#pragma once

#include <iostream>
using namespace std;


namespace myinputslib
{

	int ReadNumbersOnly()
	{
		int number = 0;

		cout << "please enter your number !" << endl;
		cin >> number;

		while (cin.fail())
		{
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

			cout << " invalide number , please enter a valide one ! " << endl;
			cin >> number;
		}

		return number;
	}
}