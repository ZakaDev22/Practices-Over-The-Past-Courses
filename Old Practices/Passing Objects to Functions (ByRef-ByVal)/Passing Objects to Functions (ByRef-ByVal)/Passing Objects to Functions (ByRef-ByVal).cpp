//ProgrammingAdivces.com
//Mohammed Abu-Hadhoud

 // Objects can be treated like any data type such as int, bool, string ...etc,
// They can be passed to functions as parameters either by reference or by value.

#include<iostream>

using namespace std;

class clsA
{

public:
	int x;

	void Print()
	{
		cout << "The value of x=" << x << endl;
	}

};


//object sent by value, any updated will not b reflected
// on the original object
void Fun1(clsA A1)
{

	A1.x = 100;
}


//object sent by reference, any updated will be reflected
// on the original object
void Fun2(clsA& A1)
{

	A1.x = 200;
}


int main()

{
	clsA A1;

	A1.x = 50;
	cout << "\nA.x before calling function1: \n";
	A1.Print();


	//Pass by value, object will not be affected.

	Fun1(A1);
	cout << "\nA.x after calling function1 by val: \n";
	A1.Print();


	//Pass by Ref , object will be affected.

	Fun2(A1);
	cout << "\nA.x after calling function2 by ref: \n";
	A1.Print();


	system("pause>0");
	return 0;
}
