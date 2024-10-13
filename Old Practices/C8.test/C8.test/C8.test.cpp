
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


string ReplaceStringWords(string s1, string stringtoReplece, string replaceTo)
{

	short pos = s1.find(stringtoReplece);

	while (pos != string::npos)
	{
		s1.replace(pos, stringtoReplece.length(), replaceTo);

		pos = s1.find(stringtoReplece);
	}


	return s1;
}

string FormateDate(stDate date, string DateFormat = "dd/mm/yyyy")
{
	string FormattedDateString = "";

	FormattedDateString = ReplaceStringWords(DateFormat, "dd", to_string(date.day));

	FormattedDateString = ReplaceStringWords(FormattedDateString, "mm", to_string(date.month));

	FormattedDateString = ReplaceStringWords(FormattedDateString, "yyyy", to_string(date.year));

	return FormattedDateString;
}

void PrintResult()
{

	string s1;
	cout << "\n Please Enter Your String? ";
	getline(cin >> ws, s1);

	stDate date;

	date = StringToDate(s1);

	cout << endl;
	
	cout << "\n" << FormateDate(date) << "\n";

	cout << "\n" << FormateDate(date, "yyyy/dd/mm") << "\n";

	cout << "\n" << FormateDate(date, "mm/dd/yyyy") << "\n";

	cout << "\n" << FormateDate(date, "mm-dd-yyyy") << "\n";

	cout << "\n" << FormateDate(date, "dd-mm-yyyy") << "\n";

	cout << "\n" << FormateDate(date, "Day:dd, Month:mm, Year:yyyy") << "\n";

}

int main()
{

	PrintResult();

	system("pause>0");
	printf("\n\n");
	return 0;
}