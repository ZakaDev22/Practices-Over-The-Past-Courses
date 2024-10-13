//ProgrammingAdivces.com
//Mohammed Abu-Hadhoud
#include<iostream>
#include<vector>

using namespace std;

class clsA
{
public:

	int x;

	//Parameterized Constructor
	clsA(int value)
	{
		x = value;
	}

	void Print()
	{
		cout << "The value of x = " << x << endl;
	}

};


int main()

{

	// Initializing 3 array Objects with function calls of
	// parameterized constructor as elements of that array

	clsA obj[] = { clsA(10), clsA(20), clsA(30), clsA(24)};

	// using print method for each of three elements.

	for (int i = 0; i < 4; i++) {
		obj[i].Print();
	}


	system("pause>0");

	return 0;
	
}

