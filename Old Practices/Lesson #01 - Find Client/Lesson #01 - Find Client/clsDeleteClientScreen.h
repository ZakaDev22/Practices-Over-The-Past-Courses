#pragma once

#include <iostream>
#include "clsScreen.h"
#include "clsBankClient.h"
#include "clsInputValidate.h";
#include <iomanip>

using namespace std;


class clsDeleteClientScreen : protected clsScreen
{
private:

	static void _PrintClient(clsBankClient Client)
	{
		cout << "\nClient Card:";
		cout << "\n___________________";
		cout << "\nFirstName   : " << Client.FirstName;
		cout << "\nLastName    : " << Client.LastName;
		cout << "\nFull Name   : " << Client.FullName();
		cout << "\nEmail       : " << Client.Email;
		cout << "\nPhone       : " << Client.Phone;
		cout << "\nAcc. Number : " << Client.AccountNumber();
		cout << "\nPassword    : " << Client.PinCode;
		cout << "\nBalance     : " << Client.AccountBalance;
		cout << "\n___________________\n";

	}


public:

	static void ShowDeleteClientScreen()
{
	string AccountNumber = "";

	_DrawScreenHeader("\t Delete Client Screen ");

	cout << "\n Please Enter Your Account Number ? ";
	AccountNumber = clsInputValidate::ReadString();

	while (!clsBankClient::IsClientExist(AccountNumber))
	{
		cout << "\n InValid Account Number, Try Another One ? ";
		AccountNumber = clsInputValidate::ReadString();
	}

	clsBankClient Client1 = clsBankClient::Find(AccountNumber);

	_PrintClient(Client1);

	cout << "\n Delete Client Screen \n\n";

	
	cout << "\n Are Yoy Sure, You Want To Delete This Client ? ";
	
	char Answer = 'n';
	cin >> Answer;

	if (toupper(Answer) == 'Y')
	{
		if (Client1.Delete())
		{
			cout << "\n Client Deleted Successfully. :-) \n";
			_PrintClient(Client1);
		}

		else
		{
			cout << "\n Field. Client still In the Fille . :-( \n";
		}
	}


}

};

