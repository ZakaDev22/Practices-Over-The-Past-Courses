#include <iostream>

using namespace std;


int main()
{
	short mark = 0;

	cout << " pleae enter your mark ! " << endl;
	cin >> mark;

	string result = "";

	/*if (mark >= 50)
	{
		system("color 2F");
		cout << " pass ";
	}

	else
	{
		system("color 4F");
		cout << "fial";
	}*/
	
	(mark >= 50) ?  cout << " pass " << system("color 2F")  : cout << "fial" << system("color 4F");
	//cout << result << endl;

	return 0;
}