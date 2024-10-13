
#include <iostream>
using namespace std;

class clsPerson
{
public:

	virtual void Print()
	{
		cout << "\n Hi, Im a Person \n";
	}
};

class clsEmployee : public clsPerson
{
public:

	void Print()
	{
		cout << "\n Hi, Im a Employee \n";
	}
};

class clsStudent : public clsEmployee
{
public:

	void Print()
	{
		cout << "\n Hi, Im a Student \n";
	}
};

int main()
{

	clsPerson Person1; 
	clsEmployee Employee1;
	clsStudent Student1;

	//Early-Static Binding: at compilation time
	Person1.Print(); 
	Employee1.Print(); 
	Student1.Print();  

	clsPerson* Person2 = &Employee1; 
	clsPerson* Person3 = &Student1;

	//Late-Dynamic Binding : at runtime
	Person2->Print();
	Person3->Print();
	



	return 0;
}

