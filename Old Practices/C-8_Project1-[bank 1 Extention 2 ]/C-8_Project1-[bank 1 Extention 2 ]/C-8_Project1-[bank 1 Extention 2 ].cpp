#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>

using namespace std;

const string ClientsFileName = "Clients.txt";

const string UsersFileName = "Users.txt";

void ShowMainMenue();
void GoBackToMainMenue();
void ShowTransactionsMenue();
void ShowManageUsersMenue();
void Login();

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
    bool MarkForDelete = false;

};

struct sUsers
{
    string name;
    string Password;
    int permission;
    bool mark = false;
};

enum enTransactionsMenueOptions { eDeposit = 1, eWithdraw = 2, eShowTotalBalance = 3, eShowMainMenue = 4 };

enum enMainMenueOptions { eListClients = 1, eAddNewClient = 2, eDeleteClient = 3, eUpdateClient = 4, eFindClient = 5, eShowTransactionsMenue = 6, eManageUsers = 7, eLogout = 8 };

enum pUserPermissions { eAll = -1, pListClient = 1, pAddClient = 2, pDeletClient = 4, pUpdateClient = 8, pFindClient = 16, pTransactions = 32, pManageUsers = 64 };

enum enManageUsersOptions { eUsersList = 1, eAddNewUser = 2, eDeletUser = 3, eUpdateUser = 4, eFinduser = 5, eMainMenue = 6 };

sUsers currentUser;

void ShowAccessDeniadScreen()
{
    system("cls");
    cout << "\n =========================================\n";
    cout << "\n Access Deniad, \n";
    cout << "\n You dont Have Permissions to do this, \n";
    cout << "\n Please connact your Admin. \n";
    cout << " =========================================\n";
}

bool checkAccessPermissions(pUserPermissions Permission)
{
    if (currentUser.permission == pUserPermissions::eAll)
        return true;

    if ((Permission & currentUser.permission) == Permission)
        return true;
    else
        return false;
}

vector<string> SplitString(string S1, string Delim)
{

    vector<string> vString;

    short pos = 0;
    string sWord; // define a string variable  

    // use find() function to get the position of the delimiters  
    while ((pos = S1.find(Delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos); // store the word   
        if (sWord != "")
        {
            vString.push_back(sWord);
        }

        S1.erase(0, pos + Delim.length());  /* erase() until positon and move to next word. */
    }

    if (S1 != "")
    {
        vString.push_back(S1); // it adds last word of the string.
    }

    return vString;

}

sClient ConvertLinetoRecord(string Line, string Seperator = "#//#")
{

    sClient Client;
    vector<string> vClientData;

    vClientData = SplitString(Line, Seperator);

    Client.AccountNumber = vClientData[0];
    Client.PinCode = vClientData[1];
    Client.Name = vClientData[2];
    Client.Phone = vClientData[3];
    Client.AccountBalance = stod(vClientData[4]);//cast string to double


    return Client;

}

string ConvertRecordToLine(sClient Client, string Seperator = "#//#")
{

    string stClientRecord = "";

    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord += to_string(Client.AccountBalance);

    return stClientRecord;

}

bool ClientExistsByAccountNumber(string AccountNumber, string FileName)
{

    vector <sClient> vClients;

    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    if (MyFile.is_open())
    {

        string Line;
        sClient Client;

        while (getline(MyFile, Line))
        {

            Client = ConvertLinetoRecord(Line);
            if (Client.AccountNumber == AccountNumber)
            {
                MyFile.close();
                return true;
            }


            vClients.push_back(Client);
        }

        MyFile.close();

    }

    return false;


}

sClient ReadNewClient()
{
    sClient Client;

    cout << "Enter Account Number? ";

    // Usage of std::ws will extract allthe whitespace character
    getline(cin >> ws, Client.AccountNumber);

    while (ClientExistsByAccountNumber(Client.AccountNumber, ClientsFileName))
    {
        cout << "\nClient with [" << Client.AccountNumber << "] already exists, Enter another Account Number? ";
        getline(cin >> ws, Client.AccountNumber);
    }


    cout << "Enter PinCode? ";
    getline(cin, Client.PinCode);

    cout << "Enter Name? ";
    getline(cin, Client.Name);

    cout << "Enter Phone? ";
    getline(cin, Client.Phone);

    cout << "Enter AccountBalance? ";
    cin >> Client.AccountBalance;

    return Client;

}

vector <sClient> LoadCleintsDataFromFile(string FileName)
{

    vector <sClient> vClients;

    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    if (MyFile.is_open())
    {

        string Line;
        sClient Client;

        while (getline(MyFile, Line))
        {

            Client = ConvertLinetoRecord(Line);

            vClients.push_back(Client);
        }

        MyFile.close();

    }

    return vClients;

}

void PrintClientRecordLine(sClient Client)
{

    cout << "| " << setw(15) << left << Client.AccountNumber;
    cout << "| " << setw(10) << left << Client.PinCode;
    cout << "| " << setw(40) << left << Client.Name;
    cout << "| " << setw(12) << left << Client.Phone;
    cout << "| " << setw(12) << left << Client.AccountBalance;

}

void PrintClientRecordBalanceLine(sClient Client)
{

    cout << "| " << setw(15) << left << Client.AccountNumber;
    cout << "| " << setw(40) << left << Client.Name;
    cout << "| " << setw(12) << left << Client.AccountBalance;

}

void ShowAllClientsScreen()
{
    if (!checkAccessPermissions(pUserPermissions::pListClient))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

    cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << "| " << left << setw(15) << "Accout Number";
    cout << "| " << left << setw(10) << "Pin Code";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Phone";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    if (vClients.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (sClient Client : vClients)
        {

            PrintClientRecordLine(Client);
            cout << endl;
        }

    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

}

void ShowTotalBalances()
{

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

    cout << "\n\t\t\t\t\tBalances List (" << vClients.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << "| " << left << setw(15) << "Accout Number";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    double TotalBalances = 0;

    if (vClients.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (sClient Client : vClients)
        {

            PrintClientRecordBalanceLine(Client);
            TotalBalances += Client.AccountBalance;

            cout << endl;
        }

    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    cout << "\t\t\t\t\t   Total Balances = " << TotalBalances;

}

void PrintClientCard(sClient Client)
{
    cout << "\nThe following are the client details:\n";
    cout << "-----------------------------------";
    cout << "\nAccout Number: " << Client.AccountNumber;
    cout << "\nPin Code     : " << Client.PinCode;
    cout << "\nName         : " << Client.Name;
    cout << "\nPhone        : " << Client.Phone;
    cout << "\nAccount Balance: " << Client.AccountBalance;
    cout << "\n-----------------------------------\n";

}

bool FindClientByAccountNumber(string AccountNumber, vector <sClient> vClients, sClient& Client)
{

    for (sClient C : vClients)
    {

        if (C.AccountNumber == AccountNumber)
        {
            Client = C;
            return true;
        }

    }
    return false;

}

sClient ChangeClientRecord(string AccountNumber)
{
    sClient Client;

    Client.AccountNumber = AccountNumber;

    cout << "\n\nEnter PinCode? ";
    getline(cin >> ws, Client.PinCode);

    cout << "Enter Name? ";
    getline(cin, Client.Name);

    cout << "Enter Phone? ";
    getline(cin, Client.Phone);

    cout << "Enter AccountBalance? ";
    cin >> Client.AccountBalance;

    return Client;

}

bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{

    for (sClient& C : vClients)
    {

        if (C.AccountNumber == AccountNumber)
        {
            C.MarkForDelete = true;
            return true;
        }

    }

    return false;

}

vector <sClient> SaveCleintsDataToFile(string FileName, vector <sClient> vClients)
{

    fstream MyFile;
    MyFile.open(FileName, ios::out);//overwrite

    string DataLine;

    if (MyFile.is_open())
    {

        for (sClient C : vClients)
        {

            if (C.MarkForDelete == false)
            {
                //we only write records that are not marked for delete.  
                DataLine = ConvertRecordToLine(C);
                MyFile << DataLine << endl;

            }

        }

        MyFile.close();

    }

    return vClients;

}

void AddDataLineToFile(string FileName, string  stDataLine)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out | ios::app);

    if (MyFile.is_open())
    {

        MyFile << stDataLine << endl;

        MyFile.close();
    }

}

void AddNewClient()
{
    sClient Client;
    Client = ReadNewClient();
    AddDataLineToFile(ClientsFileName, ConvertRecordToLine(Client));

}

void AddNewClients()
{
    char AddMore = 'Y';
    do
    {
        //system("cls");
        cout << "Adding New Client:\n\n";

        AddNewClient();
        cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";


        cin >> AddMore;

    } while (toupper(AddMore) == 'Y');

}

bool DeleteClientByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{

    sClient Client;
    char Answer = 'n';

    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    {

        PrintClientCard(Client);

        cout << "\n\nAre you sure you want delete this client? y/n ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
            SaveCleintsDataToFile(ClientsFileName, vClients);

            //Refresh Clients 
            vClients = LoadCleintsDataFromFile(ClientsFileName);

            cout << "\n\nClient Deleted Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
        return false;
    }

}

bool UpdateClientByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{

    sClient Client;
    char Answer = 'n';

    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    {

        PrintClientCard(Client);
        cout << "\n\nAre you sure you want update this client? y/n ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {

            for (sClient& C : vClients)
            {
                if (C.AccountNumber == AccountNumber)
                {
                    C = ChangeClientRecord(AccountNumber);
                    break;
                }

            }

            SaveCleintsDataToFile(ClientsFileName, vClients);

            cout << "\n\nClient Updated Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
        return false;
    }

}

bool DepositBalanceToClientByAccountNumber(string AccountNumber, double Amount, vector <sClient>& vClients)
{


    char Answer = 'n';


    cout << "\n\nAre you sure you want perfrom this transaction? y/n ? ";
    cin >> Answer;
    if (Answer == 'y' || Answer == 'Y')
    {

        for (sClient& C : vClients)
        {
            if (C.AccountNumber == AccountNumber)
            {
                C.AccountBalance += Amount;
                SaveCleintsDataToFile(ClientsFileName, vClients);
                cout << "\n\nDone Successfully. New balance is: " << C.AccountBalance;

                return true;
            }

        }


        return false;
    }

}

string ReadClientAccountNumber()
{
    string AccountNumber = "";

    cout << "\nPlease enter AccountNumber? ";
    cin >> AccountNumber;
    return AccountNumber;

}

void ShowDeleteClientScreen()
{
    if (!checkAccessPermissions(pUserPermissions::pDeletClient))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tDelete Client Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();
    DeleteClientByAccountNumber(AccountNumber, vClients);

}

void ShowUpdateClientScreen()
{
    if (!checkAccessPermissions(pUserPermissions::pUpdateClient))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tUpdate Client Info Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();
    UpdateClientByAccountNumber(AccountNumber, vClients);

}

void ShowAddNewClientsScreen()
{
    if (!checkAccessPermissions(pUserPermissions::pAddClient))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tAdd New Clients Screen";
    cout << "\n-----------------------------------\n";

    AddNewClients();

}

void ShowFindClientScreen()
{
    if (!checkAccessPermissions(pUserPermissions::pFindClient))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tFind Client Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    sClient Client;
    string AccountNumber = ReadClientAccountNumber();
    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
        PrintClientCard(Client);
    else
        cout << "\nClient with Account Number[" << AccountNumber << "] is not found!";

}

void ShowEndScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tProgram Ends :-)";
    cout << "\n-----------------------------------\n";

}

void ShowDepositScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tDeposit Screen";
    cout << "\n-----------------------------------\n";


    sClient Client;

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();


    while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
        AccountNumber = ReadClientAccountNumber();
    }


    PrintClientCard(Client);

    double Amount = 0;
    cout << "\nPlease enter deposit amount? ";
    cin >> Amount;

    DepositBalanceToClientByAccountNumber(AccountNumber, Amount, vClients);

}

void ShowWithDrawScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tWithdraw Screen";
    cout << "\n-----------------------------------\n";

    sClient Client;

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();


    while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
        AccountNumber = ReadClientAccountNumber();
    }

    PrintClientCard(Client);

    double Amount = 0;
    cout << "\nPlease enter withdraw amount? ";
    cin >> Amount;

    //Validate that the amount does not exceeds the balance
    while (Amount > Client.AccountBalance)
    {
        cout << "\nAmount Exceeds the balance, you can withdraw up to : " << Client.AccountBalance << endl;
        cout << "Please enter another amount? ";
        cin >> Amount;
    }

    DepositBalanceToClientByAccountNumber(AccountNumber, Amount * -1, vClients);

}

void ShowTotalBalancesScreen()
{

    ShowTotalBalances();

}

void GoBackToMainMenue()
{
    cout << "\n\nPress any key to go back to Main Menue...";
    system("pause>0");
    ShowMainMenue();

}

void GoBackToTransactionsMenue()
{
    cout << "\n\nPress any key to go back to Transactions Menue...";
    system("pause>0");
    ShowTransactionsMenue();

}

short ReadTransactionsMenueOption()
{
    cout << "Choose what do you want to do? [1 to 4]? ";
    short Choice = 0;
    cin >> Choice;

    return Choice;
}

void PerfromTranactionsMenueOption(enTransactionsMenueOptions TransactionMenueOption)
{
    switch (TransactionMenueOption)
    {
    case enTransactionsMenueOptions::eDeposit:
    {
        system("cls");
        ShowDepositScreen();
        GoBackToTransactionsMenue();
        break;
    }

    case enTransactionsMenueOptions::eWithdraw:
    {
        system("cls");
        ShowWithDrawScreen();
        GoBackToTransactionsMenue();
        break;
    }


    case enTransactionsMenueOptions::eShowTotalBalance:
    {
        system("cls");
        ShowTotalBalancesScreen();
        GoBackToTransactionsMenue();
        break;
    }


    case enTransactionsMenueOptions::eShowMainMenue:
    {

        ShowMainMenue();

    }
    }

}

void ShowTransactionsMenue()
{
    if (!checkAccessPermissions(pUserPermissions::pTransactions))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    system("cls");
    cout << "===========================================\n";
    cout << "\t\tTransactions Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] Deposit.\n";
    cout << "\t[2] Withdraw.\n";
    cout << "\t[3] Total Balances.\n";
    cout << "\t[4] Main Menue.\n";
    cout << "===========================================\n";
    PerfromTranactionsMenueOption((enTransactionsMenueOptions)ReadTransactionsMenueOption());
}

// This code for Manage Users ---------------------------------------------------------------------------------------------------------------------

short ReadManageUsersMenueOption()
{
    cout << "Choose what do you want to do? [1 to 6]? ";
    short Choice = 0;
    cin >> Choice;

    return Choice;
}

void GoBackToManageUsersMenue()
{
    cout << "\n\nPress any key to go back to Manage Users Menue...";
    system("pause>0");
    ShowManageUsersMenue();

}

string ConvertUserRecordToLine(sUsers user, string Seperator = "#//#")
{

    string stUserRecord = "";

    stUserRecord += user.name + Seperator;
    stUserRecord += user.Password + Seperator;
    stUserRecord += to_string(user.permission);

    return stUserRecord;

}

sUsers ConvertLinetoUserRecord(string Line, string Seperator = "#//#")
{

    sUsers user;
    vector<string> vUser;

    vUser = SplitString(Line, Seperator);

    user.name = vUser[0];
    user.Password = vUser[1];
    user.permission = stoi(vUser[2]);   //cast string to double

    return user;
}

vector <sUsers> LoadUsersDataFromFile(string FileName)
{
    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    vector <sUsers> vUser;

    if (MyFile.is_open())
    {

        string Line;
        sUsers User;

        while (getline(MyFile, Line))
        {

            User = ConvertLinetoUserRecord(Line);

            vUser.push_back(User);
        }

        MyFile.close();
    }

    return vUser;

}

bool FindUserByNameEndPassword(string UserName, string UserPassword, sUsers& user)
{
    vector <sUsers> vUsers = LoadUsersDataFromFile(UsersFileName);

    for (sUsers& us : vUsers)
    {
        if (us.name == UserName && us.Password == UserPassword)
        {
            user = us;
            return true;
        }
    }

    return false;
}

bool LoadUserInfo(string username, string password)
{
    if (FindUserByNameEndPassword(username, password, currentUser))
        return true;
    else
        return false;
}
//--------------------------------- Users List-------------------------------------------------
void PrintUsersRecordLine(sUsers user)
{

    cout << "| " << setw(40) << left << user.name;
    cout << "| " << setw(15) << left << user.Password;
    cout << "| " << setw(12) << left << user.permission;

}

void ShowUsersList()
{

    vector <sUsers> vUsers = LoadUsersDataFromFile(UsersFileName);

    cout << "\n\t\t\t\t\tBalances List (" << vUsers.size() << ") User(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << "| " << left << setw(40) << "User Name";
    cout << "| " << left << setw(15) << "Password";
    cout << "| " << left << setw(12) << "Permmitions";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    if (vUsers.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (sUsers& Us : vUsers)
        {

            PrintUsersRecordLine(Us);

            cout << endl;
        }

    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

}
//------------------------------ Add User ------------------------------------------//

bool UserExistsByUserName(string username, string FileName)
{

    vector <sUsers> vUsers;

    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    if (MyFile.is_open())
    {

        string Line;
        sUsers user;

        while (getline(MyFile, Line))
        {

            user = ConvertLinetoUserRecord(Line);
            if (user.name == username)
            {
                MyFile.close();
                return true;
            }


            vUsers.push_back(user);
        }

        MyFile.close();

    }

    return false;


}

void AddUserDataLineToFile(string FileName, string  stDataLine)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out | ios::app);

    if (MyFile.is_open())
    {

        MyFile << stDataLine << endl;

        MyFile.close();
    }

}

int ReadPermissions()
{
    int perm = 0;

    char answer = 'n';

    cout << "\n Do you want to geve full access? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
        return  -1;

    cout << "\n do you want to give access To : \n ";

    cout << "\n Client List ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm = pUserPermissions::pListClient;
    }

    cout << "\n Add Clieant ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pAddClient;
    }

    cout << "\n Delete Client ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pDeletClient;
    }

    cout << "\n Update Client ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pUpdateClient;
    }

    cout << "\n Find Client ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pFindClient;
    }

    cout << "\n Transactions ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pTransactions;
    }

    cout << "\n Manage Users ? Y/N ? ";
    cin >> answer;
    if (toupper(answer) == 'Y')
    {
        perm += pUserPermissions::pManageUsers;
    }

}

sUsers ReadNewUser()
{
    sUsers user;

    cout << "Enter User Name? ";

    // Usage of std::ws will extract allthe whitespace character
    getline(cin >> ws, user.name);

    while (UserExistsByUserName(user.name, UsersFileName))
    {
        cout << "\n User with [" << user.name << "] already exists, Enter another  User Name? ";
        getline(cin >> ws, user.name);
    }

    cout << "Enter Password? ";
    getline(cin, user.Password);

    user.permission = ReadPermissions();

    return user;
}

void AddNewUser()
{
    sUsers user;
    user = ReadNewUser();
    AddUserDataLineToFile(UsersFileName, ConvertUserRecordToLine(user));

}

void AddNewUsers()
{
    cout << "\n-----------------------------------\n";
    cout << "\tAdd New Users Screen";
    cout << "\n-----------------------------------\n";

    char AddMore = 'Y';
    do
    {
        //system("cls");
        cout << "Adding New users:\n\n";

        AddNewUser();
        cout << "\n User Added Successfully, do you want to add more Users? Y/N? ";

        cin >> AddMore;

    } while (toupper(AddMore) == 'Y');

}

void showAddscreen()
{
    AddNewUsers();
}

//============== Delete user ==========//

string ReadUser()
{
    string UserName = "";

    cout << "\nPlease enter User Name? ";
    cin >> UserName;
    return UserName;
}

void PrintUserCard(sUsers user)
{
    cout << "\nThe following are the User details:\n";
    cout << "-----------------------------------";
    cout << "\n Name       : " << user.name;
    cout << "\n Password   : " << user.Password;
    cout << "\n Permission : " << user.permission;
    cout << "\n-----------------------------------\n";
}

bool FindUserByName(string UserName, vector <sUsers> vUsers, sUsers& user)
{

    for (sUsers& us : vUsers)
    {
        if (us.name == UserName)
        {
            user = us;
            return true;
        }
    }

    return false;
}

bool MarkUserForDeleteUserName(string UserName, vector <sUsers>& vUsers)
{

    for (sUsers& us : vUsers)
    {

        if (us.name == UserName)
        {
            us.mark = true;
            return true;
        }

    }

    return false;

}

vector <sUsers>  SaveUsersDataToFile(string FileName, vector <sUsers> vUsers)
{

    fstream MyFile;
    MyFile.open(FileName, ios::out);//overwrite

    string DataLine;

    if (MyFile.is_open())
    {

        for (sUsers& us : vUsers)
        {

            if (us.mark == false)
            {
                //we only write records that are not marked for delete.
                DataLine = ConvertUserRecordToLine(us);
                MyFile << DataLine << endl;

            }

        }

        MyFile.close();

    }
    return vUsers;
}

bool DeletUserByUserName(string UserName, vector <sUsers>& vUsers)
{

    sUsers user;
    char Answer = 'n';

    if (FindUserByName(UserName, vUsers, user))
    {
        PrintUserCard(user);

        cout << "\n\nAre you sure you want delete this User? y/n ? ";
        cin >> Answer;
        if (toupper(Answer) == 'Y')
        {
            MarkUserForDeleteUserName(UserName, vUsers);
            SaveUsersDataToFile(UsersFileName, vUsers);

            //Refresh Clients 
            vUsers = LoadUsersDataFromFile(UsersFileName);

            cout << "\n\nUser Deleted Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\nUser with Name : (" << UserName << ") is Not Found!";
        return false;
    }

}

void DeleteUserScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tDelete User Screen";
    cout << "\n-----------------------------------\n";

    vector <sUsers> vUsers = LoadUsersDataFromFile(UsersFileName);
    string UserName = ReadUser();

    if (UserName == "admin")
    {
        cout << "\n You Cannot Delete This User. ";
        GoBackToManageUsersMenue();
    }
    DeletUserByUserName(UserName, vUsers);

}

void showDeleteScreen()
{
    DeleteUserScreen();
}
//====================== Update Users ======================================//

sUsers ChangeUserRecord(string UserName)
{
    sUsers user;

    user.name = UserName;

    cout << "\n\nEnter PassWord? ";
    getline(cin >> ws, user.Password);

    user.permission = ReadPermissions();



    return user;

}

bool UpdateUsersByUserName(string userName, vector <sUsers>& vUser)
{

    sUsers user;
    char Answer = 'n';

    if (FindUserByName(userName, vUser, user))
    {
        PrintUserCard(user);

        cout << "\n\nAre you sure you want update this User? y/n ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {

            for (sUsers& C : vUser)
            {
                if (C.name == userName)
                {
                    C = ChangeUserRecord(userName);
                    break;
                }

            }

            SaveUsersDataToFile(UsersFileName, vUser);

            cout << "\n\n User Updated Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\n User with Name : (" << userName << ") is Not Found!";
        return false;
    }

}

void ShowUpdateUsersScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tUpdate Users  Screen";
    cout << "\n-----------------------------------\n";

    vector <sUsers> vUsers = LoadUsersDataFromFile(UsersFileName);
    string UserName = ReadUser();

    if (UserName == "admin")
    {
        cout << "\n You Cannot Update This User. ";
        GoBackToManageUsersMenue();
    }

    UpdateUsersByUserName(UserName, vUsers);

}

//=========================== Find Users =====================//

void ShowFindUserScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\t Find Client Screen";
    cout << "\n-----------------------------------\n";

    vector <sUsers> vUsers = LoadUsersDataFromFile(UsersFileName);
    string UserName = ReadUser();
    sUsers user;

    if (FindUserByName(UserName, vUsers, user))
        PrintUserCard(user);
    else
        cout << "\nUser with Name : [" << UserName << "] is not found!";

}
//===================================================//

void PerfromManageUsersMenueOption(enManageUsersOptions ManageUsersOptions)
{
    switch (ManageUsersOptions)
    {
    case enManageUsersOptions::eUsersList:
    {
        system("cls");
        ShowUsersList();
        GoBackToManageUsersMenue();
        break;
    }

    case enManageUsersOptions::eAddNewUser:
    {
        system("cls");
        showAddscreen();
        GoBackToManageUsersMenue();
        break;
    }


    case enManageUsersOptions::eDeletUser:
    {
        system("cls");
        showDeleteScreen();
        GoBackToManageUsersMenue();
        break;
    }


    case enManageUsersOptions::eUpdateUser:
    {
        system("cls");
        ShowUpdateUsersScreen();
        GoBackToManageUsersMenue();
        break;
    }

    case enManageUsersOptions::eFinduser:
    {
        system("cls");
        ShowFindUserScreen();
        GoBackToManageUsersMenue();
        break;
    }

    case enManageUsersOptions::eMainMenue:
    {
        ShowMainMenue();
    }

    }

}

void ShowManageUsersMenue()
{
    if (!checkAccessPermissions(pUserPermissions::pManageUsers))
    {
        ShowAccessDeniadScreen();
        GoBackToMainMenue();
        return;
    }

    system("cls");
    cout << "===========================================\n";
    cout << "\t\Manage Users Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] List Users.\n";
    cout << "\t[2] Add New User.\n";
    cout << "\t[3] Delet User.\n";
    cout << "\t[4] Update User.\n";
    cout << "\t[5] Find User.\n";
    cout << "\t[6] Main Menue.\n";
    cout << "===========================================\n";
    PerfromManageUsersMenueOption((enManageUsersOptions)ReadManageUsersMenueOption());
}
//--------------------------------------------------------------------------

short ReadMainMenueOption()
{
    cout << "Choose what do you want to do? [1 to 8]? ";
    short Choice = 0;
    cin >> Choice;

    return Choice;
}

void PerfromMainMenueOption(enMainMenueOptions MainMenueOption)
{
    switch (MainMenueOption)
    {
    case enMainMenueOptions::eListClients:
    {
        system("cls");
        ShowAllClientsScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eAddNewClient:
        system("cls");
        ShowAddNewClientsScreen();
        GoBackToMainMenue();
        break;

    case enMainMenueOptions::eDeleteClient:
        system("cls");
        ShowDeleteClientScreen();
        GoBackToMainMenue();
        break;

    case enMainMenueOptions::eUpdateClient:
        system("cls");
        ShowUpdateClientScreen();
        GoBackToMainMenue();
        break;

    case enMainMenueOptions::eFindClient:
        system("cls");
        ShowFindClientScreen();
        GoBackToMainMenue();
        break;

    case enMainMenueOptions::eShowTransactionsMenue:
        system("cls");
        ShowTransactionsMenue();
        break;

    case enMainMenueOptions::eManageUsers:
        system("cls");
        ShowManageUsersMenue();
        break;

    case enMainMenueOptions::eLogout:
        system("cls");
        Login();
        break;
    }

}

void ShowMainMenue()
{
    system("cls");
    cout << "===========================================\n";
    cout << "\t\tMain Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] Show Client List.\n";
    cout << "\t[2] Add New Client.\n";
    cout << "\t[3] Delete Client.\n";
    cout << "\t[4] Update Client Info.\n";
    cout << "\t[5] Find Client.\n";
    cout << "\t[6] Transactions.\n";
    cout << "\t[7] Manage Users.\n";
    cout << "\t[8] Log Out.\n";
    cout << "===========================================\n";
    PerfromMainMenueOption((enMainMenueOptions)ReadMainMenueOption());
}

string ReadUserName()
{
    string UserName = "";

    cout << "\n enter User Name? ";
    getline(cin >> ws, UserName);

    return UserName;

}

string ReadUserPassword()
{
    string Password = "";

    cout << "\n enter Password ? ";
    getline(cin >> ws, Password);

    return Password;

}


void Login()
{
    bool LoginField = false;
    string username, userpassword;

    do
    {
        system("cls");
        cout << "\n-----------------------------------\n";
        cout << "\n\t  LogIn Screen";
        cout << "\n-----------------------------------\n";

        if (LoginField)
        {
            cout << "\n  Invalid UserName/Password! \n ";
        }
        username = ReadUserName();
        userpassword = ReadUserPassword();

        LoginField = !LoadUserInfo(username, userpassword);

    } while (LoginField);

    ShowMainMenue();
}

int main()

{
    Login();

    system("pause>0");
    return 0;
}