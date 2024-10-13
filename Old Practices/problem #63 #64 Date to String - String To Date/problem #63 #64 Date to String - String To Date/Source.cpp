
#include <iostream>

#include <string>
#include <vector>
#include <cctype>
#include <iomanip>

using namespace std;

struct stDate
{
	short year = 0;
	short month = 0;
	short day = 0;
};

// Split String
vector <string> SplitString(string s1, string delim)
{
	vector <string> vWords;

	short pos = 0;

	string sWord;

	while ((pos = s1.find(delim)) != std::string::npos)
	{
		sWord = s1.substr(0, pos);

		if (sWord != "")
		{
			vWords.push_back(sWord);

		}
		s1.erase(0, pos + delim.length());
	}

	if (sWord != "")
	{
		vWords.push_back(s1);
	}

	return vWords;
}

stDate StringToDate(string s1)
{
	stDate date;

	vector <string> vDateInfo = SplitString(s1, "/");

	date.day = stoi(vDateInfo[0]);
	date.month = stoi(vDateInfo[1]);
	date.year = stoi(vDateInfo[2]);

	return date;
}

string DateToString(stDate date, string seperator = "/")
{
	return  to_string(date.day) + seperator + to_string(date.month) + seperator + to_string(date.year);
}


void PrintResult()
{

	string s1;
	cout << "\n Please Enter Your String? ";
	getline(cin >> ws, s1);

	stDate date;

	date = StringToDate(s1);

	cout << "\n Day : " << date.day << endl;
	cout << "\n Month : " << date.month << endl;
	cout << "\n Year : " << date.year << endl;


	cout << "\n You Entered : " << DateToString(date, "/") << endl;
}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}