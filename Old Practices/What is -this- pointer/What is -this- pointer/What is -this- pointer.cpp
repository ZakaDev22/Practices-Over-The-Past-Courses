
#include <iostream>

using namespace std;

class clsEmployee
{
private:
    int ID;
    string Name; 
    float salary;

public:

    clsEmployee(int ID,string Name, float salary )
    {
        ID = ID;
        Name = Name;
        salary = salary;
    }

    void Print()
    {
        cout << ID << Name << salary << endl;
    }
};


int main()
{
    clsEmployee Employee;

    system("pause>0");
    return 0;
}

