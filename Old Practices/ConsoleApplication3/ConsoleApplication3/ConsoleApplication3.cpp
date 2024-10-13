#include <iostream>

using namespace std;


int main()
{

	short number = 0;

	cout << " please enter a number !" << endl;
	cin >> number;


	(number == 0) ? cout << " the number is zero " : (number > 0) ? cout << " the number is positive " : cout << "the nunmer is negative ";

	return 0;
}