
#include <iostream>
#include <string>

using namespace std;

void PrintMenueScreen();
void Playcalculater();

enum  eUserChoise
{
    eAdd = 1, Substract=2, Divide=3, Mulltiplay=4, CancelLastOperation=5, clear=6
};

void goBackToMainMenue()
{
    cout << "\n Press anykey to go Back to Main Menue !";
    system("pause>0");
    Playcalculater();
}

float ReadCurentNumber()
{
    float Num = 0;
    
        cout << "\n Enter the Number You Want to Calculate ? ";
        cin >> Num;

        return Num;
}

float ReadUserNumber()
{
    float Num = 0;
    do
    {
        cout << "\n Enter A Number From 1 to 6 ? ";
        cin >> Num;

    } while (Num < 0 || Num>6);
   
    return Num;
}

class clsCalculater
{

private :

    float _Result = 0;
    float _LastNumber = 0;
    string _LastOperation = "Clear";
    float _PreviousResult = 0;

    bool _IzZero(float Number)
    {
        return (Number == 0);
    }

    
public:

    void Add(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Adding";
        _PreviousResult = _Result;
        _Result += Number;
    }

    void Substact(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Substracting";
        _PreviousResult = _Result;
        _Result -= Number;
    }

    void Div(float Number)
    {
        _LastNumber = Number;
         
        if (_IzZero(Number))
        {
            Number = 1;
        }

        _LastOperation = "Dividing";
        _PreviousResult = _Result;
        _Result /= Number;
    }

    void Multiply(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Multiplying";
        _PreviousResult = _Result;
        _Result *= Number;
    }

    void Clear()
    {
        _LastNumber = 0;
        _LastOperation = "clear";
        _PreviousResult = 0;
        _Result = 0;
    }

    void CancelLastOperation()
    {
        _LastNumber = 0;
        _LastOperation = "Cancilling Last Operation";
        _Result = _PreviousResult;
    }

    void PrintResult()
    {
        cout << "\n\nResult "; 
        cout << "After " << _LastOperation << " " << _LastNumber << " is : " << _Result << "\n";
    }

};

void PerformUserChois(eUserChoise Choise)
{
    clsCalculater Calculater1;

    switch (Choise)
    {
    case 1 :
    {
        system("cls");
        Calculater1.Add(ReadCurentNumber());
        Calculater1.PrintResult();
        goBackToMainMenue();
        break;
    }

    case 2:
    {
        system("cls");
        Calculater1.Substact(ReadCurentNumber());
        Calculater1.PrintResult();
        goBackToMainMenue();
        break;
    }

    case 3:
    {
        system("cls");
        Calculater1.Div(ReadCurentNumber());
        Calculater1.PrintResult();
        goBackToMainMenue();
        break;
    }

    case 4:
    {
        system("cls");
        Calculater1.Multiply(ReadCurentNumber());
        Calculater1.PrintResult();
        goBackToMainMenue();
        break;
    }

    case 5:
    {
        system("cls");
        Calculater1.CancelLastOperation();
        goBackToMainMenue();
        break;
    }

    case 6:
    {
        system("cls");
        Calculater1.Clear();
        goBackToMainMenue();
        break;
    }

    }
}

void PrintMenueScreen()
{
    system("cls");

    cout << "\n==================| Calculater Menue Screen |==============|\n";
    cout << "|===========================================================|\n";
    cout << "\n\t [1] Add. \n";
    cout << "\n\t [2] Substract. \n";
    cout << "\n\t [3] Divide. \n";
    cout << "\n\t [4] Mulltiplay. \n";
    cout << "\n\t [5] Cancel Last Operation. \n";
    cout << "\n\t [6] Clear. \n";
    cout << "\n===========================================================|\n";
    PerformUserChois((eUserChoise)ReadUserNumber());
}

void ShowEndScreen()
{
    system("cls");

    cout << "\n|==================| Programm End ;) |==============|\n";
    cout << "|=======================================================|\n";
}

void Playcalculater()
{
    char Answer = 'n';
    
    do
    {
        PrintMenueScreen();

        cout << "\n do You want to Perform Another Result Y/N ? ";
        cin >> Answer;

    } while (toupper(Answer) == 'Y');

    ShowEndScreen(); 
}

int main()
{
    Playcalculater();
    
    system("pause>0");
    return 0;
}

