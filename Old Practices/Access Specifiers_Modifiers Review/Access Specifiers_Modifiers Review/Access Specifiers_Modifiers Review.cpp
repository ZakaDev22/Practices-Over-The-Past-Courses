
#include <iostream>
#include <string>
#include <iomanip>
#include <vector>

using namespace std;

class clsA
{
private:

    //only accessible inside this class, neither derived classes nor outside class
    int var1 = 0;
    void Fun1()
    {
        cout << "\n Im Function 1 :-) \n";
    }

protected:

    //only accessible inside this class and all derived classes, but not outside class
    int age = 21;
    void Fun2()
    {
        cout << "\n Im Function 2 :-) \n";
        cout << "\n My Age Is " << age << " :-) \n";
    }

public:

    // Accessible inside this class, all derived classes, and outside class
    int var3 = 0;
    void Fun3()
    {
        cout << "\n Im Function 3 :-) \n";
    }
};

class clsB : public clsA
{
public:

    void Fun4()
    {
        clsA::Fun2() ;
    }
};

int main()
{
    clsA A;
    A.Fun3();

    clsB B;
    B.Fun4();

    system("pause>0");
    return 0;
}
