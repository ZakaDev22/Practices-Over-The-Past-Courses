
#include <iostream>
#include <string>

using namespace std;

class clsEmployee
{
private:

	int ID;
	string Name;
	float salary;

public:

	clsEmployee(int ID, string Name, float salary)
	{
		this->ID = ID;
		this->Name = Name;
		this->salary = salary;
	}

	static void fun1(clsEmployee Employee)
	{
		Employee.Print();
	}

	void fun2()
	{
		fun1( *this);
	}

	void Print()
	{
		cout << ID << Name << salary << endl;
	}
};


int main()
{
	clsEmployee Employee1(21," king ", 5021);

	Employee1.Print();

	Employee1.fun2();
   
	return 0;
}
