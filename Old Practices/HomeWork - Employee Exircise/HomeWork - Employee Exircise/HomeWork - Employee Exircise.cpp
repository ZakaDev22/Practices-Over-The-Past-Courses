

#include <iostream>
#include "clsPerson.h";
#include "clsEmployee.h";

using namespace std;



int main()

{
    clsPerson Person1(21, "the King", "Of Caty Heart", "A@z.com", "20021999");

    Person1.Print();

    clsEmployee Employee1(10, "Mohammed", "Abu-Hadhoud", "A@a.com", "8298982", "CEO", "ProgrammingAdvices", 5000);

    Employee1.Print();

    system("pause>0");
    return 0;
}