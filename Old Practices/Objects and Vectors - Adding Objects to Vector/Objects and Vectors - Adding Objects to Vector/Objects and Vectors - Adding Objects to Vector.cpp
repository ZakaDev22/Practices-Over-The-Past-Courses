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
		cout << "The value of x=" << x << endl;
	}

};


int main()

{

	vector <clsA> v1;
	short NumberOfObjects = 10;

	// inserting object at the end of vector
	for (int i = 0; i < NumberOfObjects; i++)
	{
		v1.push_back(clsA(i));
	}

	// printing object content
	for (int i = 0; i < NumberOfObjects; i++)
	{
		v1[i].Print();

	}

	system("pause>0");

}

