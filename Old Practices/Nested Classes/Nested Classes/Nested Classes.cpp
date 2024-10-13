//ProgrammingAdivces.com
//Mohammed Abu-Hadhoud

#include<iostream>
using namespace std;

class clsPerson {

    string _FirstName;
    string _LastName;

    class clsAddress
    {
    private:
        string _AddressLine1;
        string _AddressLine2;
        string _City;
        string _Country;

    public:

       /* clsAddress(string AddressLine1, string AddressLine2, string City, string Country)
        {
            _AddressLine1 = AddressLine1;
            _AddressLine2 = AddressLine2;
            _City = City;
            _Country = Country;
        }*/
        
        // property Set
        void SetAddressLine1(string AddressLine1)
        {
            _AddressLine1 = AddressLine1;
        }
        
        // property Get
        string GetAddressLine1()
        {
            return _AddressLine1;
        }

        __declspec(property(get = GetAddressLine1, put = SetAddressLine1)) string AddressLine1;

        // property Set
        void SetAddressLine2(string AddressLine2)
        {
            _AddressLine2 = AddressLine2;
        }

        // property Get
        string GetAddressLine2()
        {
            return _AddressLine2;
        }

        __declspec(property(get = GetAddressLine2, put = SetAddressLine2)) string AddressLine2;
        
        // property Set
        void SetCity(string City)
        {
            _City = City;
        }

        // property Get
        string GetCity()
        {
            return _City;
        }

        __declspec(property(get = GetCity, put = SetCity)) string City;

        // property Set
        void SetCountry(string Country)
        {
            _Country = Country;
        }

        // property Get
        string GetCountry()
        {
            return _Country;
        }

        __declspec(property(get = GetCountry, put = SetCountry)) string Country;


        void Print()
        {
            cout << "\nAddress:\n\n";
            cout << "Address Line 1 : " << AddressLine1 << endl;
            cout << "Address Line 2 : " << AddressLine2 << endl;
            cout << "My City        : " << City << endl;
            cout << "My Country     : " << Country << endl;
        }
    };

public:
   
    clsAddress Address1;

    clsPerson(string FirstName,string LastName,string AddressLine1, string AddressLine2, string City, string Country)
    {
        _FirstName = FirstName;
        _LastName = LastName;
        Address1.AddressLine1 = AddressLine1;
        Address1.AddressLine2 = AddressLine2;
        Address1.City = City;
        Address1.Country = Country;
    }

    // property Set
    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }

    // property Get
    string GetFirstName()
    {
        return _FirstName;
    }
    __declspec(property(get = GetFirstName, put = SetFirstName)) string FirstName;

    // property Set
    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }

    // property Get
    string GetLastName()
    {
        return _LastName;
    }
    __declspec(property(get = GetLastName, put = SetLastName)) string LastName;

    string FullName()
    {
        return FirstName + " " + LastName;
    }

    void Print()
    {
        cout << "\n\n";
        cout << "\n My First Name is : " << FirstName << endl;
        cout << "\n My Last Name is  : " << LastName << endl;
        cout << "\n My Full Name is  : " << FullName() << endl;
    }
};

int main()

{
    
    clsPerson Person1("The King" ,"Of wolfs" ,"Building 21", "The wolf street 1", "sz", "My Caty Heart");

    Person1.Address1.Print();
    
    Person1.Print();
    
   

    system("pause>0");
    return 0;
}