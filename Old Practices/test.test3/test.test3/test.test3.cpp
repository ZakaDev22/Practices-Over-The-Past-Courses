#include <iostream>
#include <string>
#include <iomanip>
#include <vector>
#include <fstream>

#include "MyStringLib.h";

using namespace std;

const string clientFilleName = "CL_Record.txt";

struct stClientData
{
	string accountnumber = "";
	string pincode = "";
	string fullname = "";
	string phone = "";
	double accountbalance = 0;
};

// this lines for Print All client Data. {----------------------------------------------------------------------------------------}

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

	return  vWords;
}

stClientData ConvertClientsDataFromLineToRecord(string stclientrecord, string seperator = "#//#")
{
	stClientData clientdata;

	vector <string> vRecord;

	vRecord = SplitString(stclientrecord, seperator);

	clientdata.accountnumber = vRecord[0];
	clientdata.pincode = vRecord[1];
	clientdata.fullname = vRecord[2];
	clientdata.phone = vRecord[3];
	clientdata.accountbalance = stod(vRecord[4]);

	return clientdata;
}

vector <stClientData> LoedDataFromFilleToVector(string clientFilleName)
{
	fstream Myfille;

	vector <stClientData> vclient;

	Myfille.open(clientFilleName, ios::in); // read mode.

	if (Myfille.is_open())
	{
		string line;
		stClientData client;

		while (getline(Myfille, line))
		{
			client = ConvertClientsDataFromLineToRecord(line);

			vclient.push_back(client);
		}

		Myfille.close();
	}

	return vclient;
}

void PrintClinetRecord(stClientData client)
{
	cout << "| " << setw(15) << left << client.accountnumber;
	cout << "| " << setw(25) << left << client.pincode;
	cout << "| " << setw(35) << left << client.fullname;
	cout << "| " << setw(20) << left << client.phone;
	cout << "| " << setw(10) << left << client.accountbalance;
}

void PrintAllClientsData(vector <stClientData> vclient)
{
	cout << "\n\t\t\t\t\t clients List Of (" << vclient.size() << ") Clients \n";

	cout << "\n---------------------------------------------------------------------------";
	cout << "----------------------------------------\n";

	cout << "| " << setw(15) << left << "Account Number ";
	cout << "| " << setw(25) << left << "Pine Code  ";
	cout << "| " << setw(35) << left << "Full Name ";
	cout << "| " << setw(20) << left << "Phone ";
	cout << "| " << setw(10) << left << "Balance ";

	cout << "\n---------------------------------------------------------------------------";
	cout << "----------------------------------------\n";

	for (stClientData& client : vclient)
	{
		PrintClinetRecord(client);

		cout << endl;
	}

	cout << "\n ---------------------------------------------------------------------------";
	cout << "----------------------------------------\n";
}

// this lines for Add client Function. {----------------------------------------------------------------------------------------}

stClientData Readclientdata()
{
	stClientData clientdata;

	// usage of std::WS Will Extract all the wihtSpace character.
	cout << "\n enter your account number \n";
	getline(cin >> ws, clientdata.accountnumber);

	cout << "\n enter your pin code \n";
	getline(cin, clientdata.pincode);

	cout << "\n enter your full name \n";
	getline(cin, clientdata.fullname);

	cout << "\n enter your phone number \n";
	getline(cin, clientdata.phone);

	cout << "\n enter your account balance \n";
	cin >> clientdata.accountbalance;

	return clientdata;
}

string ConvertClientsDataFromRecordToOneLine(stClientData clientdata, string seperator = "#//#")
{
	string stclientrecord = "";

	stclientrecord += clientdata.accountnumber + seperator;
	stclientrecord += clientdata.pincode + seperator;
	stclientrecord += clientdata.fullname + seperator;
	stclientrecord += clientdata.phone + seperator;
	stclientrecord += to_string(clientdata.accountbalance);

	return stclientrecord;
}

void AddDataLineToFill(string filename, string onelinerecord)
{
	fstream MyFile;

	MyFile.open(filename, ios::out | ios::app); // append mode ;

	string line = onelinerecord;

	if (MyFile.is_open())
	{
		MyFile << line << endl;

		MyFile.close();
	}

}

void AddNewClient()
{
	stClientData clientdata;

	clientdata = Readclientdata();

	AddDataLineToFill(clientFilleName, ConvertClientsDataFromRecordToOneLine(clientdata));
}

void AddClients()
{
	char pass = 'Y';

	do
	{
		mylib::resetScreen();

		cout << "\n Adding  New Client : \n\n";

		AddNewClient();

		cout << "\n client added successfully, do you want to add more clients Y/N ? \n";
		cin >> pass;

	} while (toupper(pass) == 'Y');

}

// this lines for Find client Using Account Number. {----------------------------------------------------------------------------------------}

void PrintClientDataRecord(stClientData clientdata)
{
	cout << "\n";

	cout << "\n the Following is Client Data Record : \n";

	cout << "\n   account Number   : " << clientdata.accountnumber << endl;

	cout << "\n   Pin Code         : " << clientdata.pincode << endl;

	cout << "\n   Full Name        : " << clientdata.fullname << endl;

	cout << "\n   account Phone    : " << clientdata.phone << endl;

	cout << "\n   account Balance  : " << clientdata.accountbalance << endl;

	cout << "\n\n";

}

bool IsClientNumber_Found(string AccountNumber, vector <stClientData> vclient, stClientData& client)
{

	for (stClientData& c : vclient)
	{
		if (c.accountnumber == AccountNumber)
		{
			client = c;

			return true;
		}
	}
	return false;
}

void PrintFoundedClient(string AccountNumber, vector <stClientData> vclient, stClientData client)
{
	if (IsClientNumber_Found(AccountNumber, vclient, client))
	{
		PrintClientDataRecord(client);
	}
	else
	{
		cout << "\n Client Wiht Account Number (\'" << AccountNumber << "\') Not Found! \n " << endl;
	}
}


string ReadClientNumber()
{
	string clientNumber = "";
	cout << "\n please anter your account number ? \n" << endl;
	getline(cin, clientNumber);

	return clientNumber;
}

// this lines for Delete client Data. {----------------------------------------------------------------------------------------}

int main()
{
	stClientData client;

	vector <stClientData> vclient = LoedDataFromFilleToVector(clientFilleName);

	string AccountNumber = ReadClientNumber();

	PrintAllClientsData(vclient);

	//AddClients();

	//PrintFoundedClient(AccountNumber, vclient, client);

	return 0;
}
