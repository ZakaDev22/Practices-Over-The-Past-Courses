#pragma once

#include <iostream>
#include <iomanip>

using namespace std;

template <class T>
class clsCalculator
{
private:

	T  _Number1, _Number2;

public:

	clsCalculator(T N1, T N2)
	{
		_Number1 = N1;
		_Number2 = N2;
	}

	void PrintResults()
	{
		cout << setw(10) << left << "" << "---------------------------------------------------\n\n";
		cout << setw(20) << left << ""  << " Number To Calculate : " << _Number1 << " And " << _Number2 << endl<< endl;
		cout << setw(15) << left << "" << "  ======================================\n";
		cout << setw(20) << left << "" << _Number1 << " + " << _Number2 << " = " << Add() << endl;
		cout << setw(20) << left << "" << _Number1 << " - " << _Number2 << " = " << Subtract() << endl;
		cout << setw(20) << left << "" << _Number1 << " * " << _Number2 << " = " << Multiply() << endl;
		cout << setw(20) << left << "" << _Number1 << " / " << _Number2 << " = " << divide() << endl;
		cout << setw(10) << left << "" << "---------------------------------------------------\n";
	}

	T Add()
	{
		return _Number1 + _Number2;
	}

	T Subtract()
	{
		return _Number1 - _Number2;
	}

	T Multiply()
	{
		return _Number1 * _Number2;
	}

	T divide()
	{
		return _Number1 / _Number2;
	}


};
