#include <iostream>
#include <vector>

using namespace std;


int main()
{

	vector <int> vNumbers;

	vNumbers.push_back(10);
	vNumbers.push_back(11);
	vNumbers.push_back(21);
	vNumbers.push_back(23);

	
	for (int& numbers : vNumbers)
	{
		cout << numbers << " ";
	}






	return 0;
}