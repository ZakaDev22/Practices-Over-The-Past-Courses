
#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

class clsAdress
{

private : 
   
    string _AdressLine1;
    string _AdressLine2;
    string _PoBox;
    string _ZipCode;

public :

    //This is Instructor will be called when object is built.
    clsAdress(string adrissline1, string adressline2, string poBox, string ZipCode)
    {
        _AdressLine1 = adrissline1;
        _AdressLine2 = adressline2;
        _PoBox = poBox;
        _ZipCode = ZipCode;
    }

    // overloading constracture
    clsAdress(clsAdress & old_obj)
    {
        _AdressLine1 = old_obj.AdressLine1;
        _AdressLine2 = old_obj.AdressLine2;
        _PoBox = old_obj.PoBox;
        _ZipCode = old_obj.ZipCode;
    }

    //This is destructor will be called when object is destroyed.
    ~clsAdress()
    {
        cout << "\n Hi Im The Destracture ;) \n";
    }

    void SetAdressLine1(string adrissline1)
    {
        _AdressLine1 = adrissline1;
    }

    string GetAdressLine1()
    {
        return _AdressLine1;
    }

    __declspec(property(get = GetAdressLine1, put = SetAdressLine1)) string AdressLine1;

    //----------------------------------------

    void SetAdressLine2(string adrissline2)
    {
        _AdressLine2 = adrissline2;
    }

    string GetAdressLine2()
    {
        return _AdressLine2;
    }

    __declspec(property(get = GetAdressLine2, put = SetAdressLine2)) string AdressLine2;

   //----------------------------------------------

    void SetPoBox(string poBox)
    {
        _PoBox = poBox;
    }

    string GetPoBox()
    {
        return _PoBox;
    }

    __declspec(property(get = GetPoBox, put = SetPoBox)) string PoBox;

    //--------------------------------------------

    void SetZipCode(string zipcode)
    {
        _ZipCode = zipcode;
    }

    string GetZipCode()
    {
        return _ZipCode;
    }

    __declspec(property(get = GetZipCode, put = SetZipCode)) string ZipCode;

    //---------------------------------
     
    void PrintResult()
    {
        cout << "\n\t | Adress Details \n";
        cout << "\n====================================================\n";
        cout << "====================================================\n";
        cout << setw(15) << "| Adress Line 1 : " << _AdressLine1 << endl;
        cout << setw(15) << "| Adress Line 2 : " << _AdressLine2 << endl;
        cout << setw(15) << "| PoBox         : " << _PoBox << endl;
        cout << setw(15) << "| Zip Code      : " << _ZipCode << endl;
        cout << "====================================================\n";
        cout << "====================================================\n\n";
    }
};


int main()
{
    clsAdress Adress1(" konoha ", " amazon lily", " 2222", " 3333");
     
    Adress1.PrintResult();

    Adress1.AdressLine1 = " imlil";
    Adress1.AdressLine2 = " tobkal";
    Adress1.PoBox = " 2345";
    Adress1.ZipCode = " 123";

    Adress1.PrintResult();

    clsAdress Adress2 = Adress1;
    Adress2.PrintResult();
    

   

   
    system("pause>0");
    return 0;
}
