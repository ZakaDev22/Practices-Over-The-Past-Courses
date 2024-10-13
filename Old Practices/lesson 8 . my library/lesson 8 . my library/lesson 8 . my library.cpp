#include <iostream>
#include "MyLib.h";
#include "MyInputLib.h";

using namespace std;


int main()
{
	mylib::MyFullName();

	cout << mylib::SumOf3Numbers(1, 10, 10) << endl;

	short number = myinputlib::readAge();

	cout << "your age is = " << number << endl;

		return 0;
}