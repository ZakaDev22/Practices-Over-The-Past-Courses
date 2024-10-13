#include <iostream>
#include <string>
#include <iomanip>
#include <vector>

using namespace std;


class clsPerson
{
private:

	int _ID = 0 ;
	string _FirstName;
	string _LastName;
	string _Phone;
	string _Email; 
	string _SMS;

public:

	clsPerson(float ID, string FirstName, string LastName, string Phone, string Email)
	{
		_ID = ID;
		_FirstName = FirstName;
		_LastName = LastName;
		_Phone = Phone;
		_Email = Email;
	}

	int ID()
	{
		return _ID;
	}

	//-------------------------------------

	void SetFirstName(string FirstName)
	{
		_FirstName = FirstName;
	}

	string GetFirstName()
	{
		return _FirstName;
	}

	__declspec(property(get = GetFirstName, put = SetFirstName)) string FirstName;

	//--------------------------------------------------------

	void SetLastName(string LastName)
	{
		_LastName = LastName;
	}

	string GetLastName()
	{
		return _LastName;
	}

	__declspec(property(get = GetLastName, put = SetLastName)) string LastName;

	//-------------------------------------------

	string FullName()
	{
		return _FirstName + " " + _LastName;
	}
	//--------------------------------------

	void SetPhone(string Phone)
	{
		_Phone = Phone;
	}

	string GetPhone()
	{
		return _Phone;
	}

	__declspec(property(get = GetPhone, put = SetPhone)) string Phone;

	//-----------------------------------

	void SetEmail(string Email)
	{
		_Email = Email;
	}

	string GetEmail()
	{
		return _Email;
	}

	__declspec(property(get = GetEmail, put = SetEmail)) string Email;

	//--------------------------------------

	void SendEmail(string Subject, string Body)
	{
		cout << "\n\n The Following Message Sent Successfully to Email : " << _Email << endl;
		cout << " Subject : " << Subject << endl;
		cout << " Body    : " << Body << endl;
	}

	void SendSMS(string Subject)
	{
		cout << "\n\n The Following SMS Sent Successfully to Phone : " << _Phone << endl;
		cout << "Subject : " << Subject << endl;
	}

	//-------------------------------

	void Print()
	{
		cout << "\n Person Information : \n";
		cout << "\n================================================\n";
		cout << "\n ID           : " << _ID << endl;
		cout << " First Name   : " << _FirstName << endl;
		cout << " Last Name    : " << _LastName << endl;
		cout << " Full Name    : " << FullName() << endl;
		cout << " Email        : " << _Email << endl;
		cout << " Phone        : " << _Phone << endl;
		cout << "\n================================================\n";
	}
};

class clsEmployee : public clsPerson
{
private:

	float  _Salary;
	string _Department;
	string _Title;

public:

	clsEmployee(float ID,string FirstName,string LastName, string Phone, string Email ,string Departement,string Title,float Salary)
		: clsPerson(ID, FirstName, LastName, Phone, Email)
	{
		_Salary = Salary;
		_Department = Departement;
		_Title = Title;
	}

	// set Property
	void SetTitle(string Title)
	{
		_Title = Title;
	}

	// get Property
	string GetTitle()
	{
		return _Title;
	}

	__declspec(property(get = GetTitle, put = SetTitle)) string Title;


	// set Property
	void SetSalary(float Salary)
	{
		_Salary = Salary;
	}

	// get Property
	float GetSalary()
	{
		return _Salary;
	}

	__declspec(property(get = GetSalary, put = SetSalary)) float Salary;

	// set Property
	void SetDepartment(string Department)
	{
		_Department = Department;
	}

	// get Property
	string GetDepartment()
	{
		return _Department;
	}

	__declspec(property(get = GetDepartment, put = SetDepartment)) string Department;

	void Print()
	{
		//clsPerson::Print();

		cout << "\n Employee Information : \n";
		cout << "\n================================================\n";
		cout << "\n ID           : " << ID() << endl;
		cout << " First Name   : " <<   GetFirstName() << endl;
		cout << " Last Name    : " <<   GetLastName() << endl;
		cout << " Full Name    : " <<   FullName() << endl;
		cout << " Email        : " <<   GetEmail() << endl;
		cout << " Phone        : " <<   GetPhone() << endl;
		cout << " Department   : " <<   _Department << endl;
		cout << " Title        : " <<   _Title << endl;
		cout << " Salary       : " <<   _Salary << endl;
		cout << "\n================================================\n";
	}
};

class clsDeveloper : public clsEmployee
{
private:

	string _MainProgramminLanguage;

public:

	clsDeveloper(float ID, string FirstName, string LastName, string Phone, string Email, string Departement, string Title, float Salary,string MainProgLang)
		: clsEmployee(ID, FirstName, LastName, Phone, Email, Departement, Title, Salary)
	{
		_MainProgramminLanguage = MainProgLang;
	}

	void SetMainProgLang(string MainProgLang)
	{
		_MainProgramminLanguage = MainProgLang;
	}

	string GetMainProgLang()
	{
		return _MainProgramminLanguage;
	}

	__declspec(property(get = GetMainProgLang, put = SetMainProgLang)) string MainProgramminLanguage;

	void Print()
	{
		//clsEmployee::Print();

		cout << "\n Developer Information : \n";
		cout << "\n================================================\n";
		cout << "\n ID           : " << ID() << endl;
		cout << " First Name   : " << GetFirstName() << endl;
		cout << " Last Name    : " << GetLastName() << endl;
		cout << " Full Name    : " << FullName() << endl;
		cout << " Email        : " << GetEmail() << endl;
		cout << " Phone        : " << GetPhone() << endl;
		cout << " Department   : " << GetDepartment() << endl;
		cout << " Title        : " << GetTitle() << endl;
		cout << " Salary       : " << GetSalary() << endl;
		cout << " Main PR Lang : " << _MainProgramminLanguage << endl;
		cout << "\n================================================\n";
	}
};

int main()
{
	clsDeveloper Developer1(24,"s","wolf","213060606","ss@s.com","Loli","Ilizabith",2500,"C++");

	Developer1.Print();

	Developer1.MainProgramminLanguage = "C#";
	Developer1.Print();

	Developer1.Email = "haha@.com";
	Developer1.Print();

	/*clsEmployee Employee1(21,"king","Of Wolfs","023901010","A@s.net","ProgrammingAdvices","CEO",50000);
	Employee1.Print();
	Employee1.SendSMS("again ?");*/

	/*clsPerson Person1(10, "The King", "Of wolfs", "0893928","my@Gmail.com");
	Person1.Print();
	Person1.SendEmail("Hi", "How Are you ?");
	Person1.SendSMS("Hi again !");*/
	
	system("pause>0");
	return 0;
}