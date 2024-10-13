#include <iostream>

#include <vector>

using namespace std;



int main()
{

	vector <int>  num{ 21,2,23,11 };


	try
	{
		cout << num.at(5);
	}

	catch (...)
	{
		cout << " out of bound \n";
	}


	return 0;
}

