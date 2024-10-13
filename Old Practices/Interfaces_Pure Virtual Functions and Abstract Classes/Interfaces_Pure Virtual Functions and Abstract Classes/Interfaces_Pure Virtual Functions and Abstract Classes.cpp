
#include <iostream>
using namespace std;


//Abstract Class / Interface / Contract.
class clsMobile
{
    virtual void Dial(string PhoneNumber) = 0;
    virtual void SendSMS(string PhoneNumber, string Text) = 0;
    virtual void TakePicture() = 0;

};

class clsIPhone : public clsMobile
{

    //This class signed a contract with clsMobile abstract class   therefore it should implement everything in the abstract class

public:

    void Dial(string PhoneNumber)
    {
        cout << "\n Your Phone Number Is : ";
        cout << PhoneNumber << endl;
    };

    void SendSMS(string PhoneNumber, string Text)
    {
        cout << "\n The Following Text [ " << Text << " ] Send Successfully to Phone : ";
        cout << PhoneNumber << endl;
    };

    void TakePicture()
    {
        cout << "\n Take Picture Done Successfully. \n";
    };

    void MyOwnMethod()
    {
        cout << "\n Hi Im Iphone This is My Own Method. \n";
    }

};


class clsSamsungNote10 : public clsMobile
{
    //This class signed a contract with clsMobile abstract class   therefore it should implement everything in the abstract class

public:
    void Dial(string PhoneNumber)
    {
        cout << "\n Your Phone Number Is : ";
        cout << PhoneNumber << endl;
    };

    void SendSMS(string PhoneNumber, string Text)
    {
        cout << "\n The Following Text [ " << Text << " ] Send Successfully to Phone : ";
        cout << PhoneNumber << endl;
    };

    void TakePicture()
    {
        cout << "\n Take Picture Done Successfully. \n";
    };

    void MyOwnMethod()
    {
        cout << "\n Hi Im Samsung This is My Own Method. \n";
    }

};


int main()

{
    clsIPhone iPhone1;
    clsSamsungNote10 Note10;

    iPhone1.Dial("0763728182");
    iPhone1.SendSMS("0763728182", " \"Hi My Name Is Zakaria\" ");
    iPhone1.TakePicture();
    iPhone1.MyOwnMethod();

    cout << "\n\n======================================================\n\n";

    Note10.Dial("060033882");
    Note10.SendSMS("060033882", " \'Hi My Name Is King\' ");
    Note10.TakePicture();
    Note10.MyOwnMethod();

    system("pause>0");
    return 0;

}