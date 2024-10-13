#pragma once

#include <iostream>
#include "clsScreen.h"
#include "clsBankClient.h"
#include "clsInputValidate.h";
#include <iomanip>

using namespace std;


class clsAddNewClientScreen : protected clsScreen
{
private:

    static void _ReadClientInfo(clsBankClient& Client1)
{
	cout << "\n Enter First Name ? ";
	Client1.FirstName = clsInputValidate::ReadString();

	cout << "\n Enter Last Name ? ";
	Client1.LastName = clsInputValidate::ReadString();

	cout << "\n Enter Email ? ";
	Client1.Email = clsInputValidate::ReadString();

	cout << "\n Enter Phone ? ";
	Client1.Phone = clsInputValidate::ReadString();

	cout << "\n Enter Pin Code ? ";
	Client1.PinCode = clsInputValidate::ReadString();

	cout << "\n Enter Balance ? ";
	Client1.AccountBalance = clsInputValidate::ReadFloatNumber();
}

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

    static void ShowAddNewClient()
{
	string AccountNumber = "";

	_DrawScreenHeader("\t Add New Client Screen");

	cout << "\n Please Enter Your Account Number ? ";
	AccountNumber = clsInputValidate::ReadString();

	while (clsBankClient::IsClientExist(AccountNumber))
	{
		cout << "\n InValid Account Number, Try Another One ? ";
		AccountNumber = clsInputValidate::ReadString();
	}

	clsBankClient Client1 = clsBankClient::GetAddNewClientObject(AccountNumber);

	
	cout << "\n Add New Client Info \n\n";

	_ReadClientInfo(Client1);


	clsBankClient::enSaveResults SaveResult;

	SaveResult = Client1.Save();

	switch (SaveResult)
	{

	case  clsBankClient::enSaveResults::svSucceeded:


		cout << "\n Save Done Successfully. :-) \n";
		_PrintClient(Client1);
		break;


	case  clsBankClient::enSaveResults::svFaildEmptyObject:

		cout << "\n Save Field :-( \n";
		break;

	case  clsBankClient::enSaveResults::svFieldAccountNumberExist:

		cout << "\n Save Field Account Number Already In use. :-( \n";
		break;


	}
}
};

