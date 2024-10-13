
#include<iostream>
using namespace std;

class clsA
{
private:

    int _Var1;
    string _FirstName = "Zakaria";

protected:

    int _Var3;
    string _LastName = "The King";

public:

    int Var2;

    clsA()
    {
        _Var1 = 10;
        Var2 = 20;
        _Var3 = 30;

    }

    //this will grant access for everything to class B 

    friend class clsB;    //friend class 

    friend int MySum(clsA A1);  //friend Function 

    friend string Function2(clsA A1);  //friend Function 

};

class clsB
{
public:

    void display(clsA A1)
    {
        cout << endl << "The value of Var1=" << A1._Var1;
        cout << endl << "The value of Var2=" << A1.Var2;
        cout << endl << "The value of Var3=" << A1._Var3;
    }
};

int MySum(clsA A1)
{
    return A1._Var1 + A1.Var2 + A1._Var3;
}

string Function2(clsA A1)
{
    return A1._FirstName + " " + A1._LastName;
}

int main()
{
    clsA A1;
    clsB B1;

    B1.display(A1);

    cout << "\n\n";

    cout << "\n My Friend Function 1  = " << MySum(A1) << endl;

    cout << "\n My Friend Function 2  = " << Function2(A1) << endl;

    system("pause>0");

    return 0;
};