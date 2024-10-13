
#include <iostream>
#include "clsPerson.h"

int main()
{
    
    clsPerson Person1("Zaka", "Wolf", "z.s@.Com", "0200219990");

    Person1.SendEmail("hi", "By");

    Person1.SendFax("z", "s");

    Person1.SendSMS("You Will", "Cry Soon :-)");

    system("pause>0");
    return 0;
}
