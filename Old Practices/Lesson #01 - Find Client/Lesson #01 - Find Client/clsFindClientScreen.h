#pragma once

#include <iostream>
#include "clsScreen.h"
#include "clsBankClient.h"
#include "clsInputValidate.h";

using namespace std;


class clsFindClientScreen : protected clsScreen
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

	static void ShowFindClientScreen()
	{
		string AccountNumber = "";
		
		_DrawScreenHeader("\t Find Client Screen ");

			cout << "\n Please Enter Your Account Number ? ";
			AccountNumber = clsInputValidate::ReadString();
		
			while (!clsBankClient::IsClientExist(AccountNumber))
			{
				cout << "\n InValid Account Number, Try Another One ? ";
				AccountNumber = clsInputValidate::ReadString();
			}
		
			clsBankClient Client1 = clsBankClient::Find(AccountNumber);
		
			if (!Client1.IsEmpty())
			{
				cout << "\n Client Found :-) \n";
			}
			else
			{
				cout << "\n Client Was Not Found :-( \n";
			}

			_PrintClient(Client1);
		
	}

};

