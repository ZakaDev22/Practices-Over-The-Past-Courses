
#include <iostream>
#include "clsMyQueue.h"

using namespace std;

int main()
{
    clsMyQueue <int> MyQueue;

    MyQueue.push(10);
    MyQueue.push(20);
    MyQueue.push(30);
    MyQueue.push(40);
    MyQueue.push(50);

    cout << "\n Queue : ";
    MyQueue.Print();

    cout << "\n Queue Size  : " << MyQueue.Size() << endl;
    cout << "\n Queue Front : " << MyQueue.front() << endl;
    cout << "\n Queue Back  : " << MyQueue.back() << endl;

    MyQueue.pop();

    cout << "\n Queue After Pop Method : ";
    MyQueue.Print();

    cout << "\n\n Get Item (2) : " << MyQueue.GetItem(2) << endl;
   
    MyQueue.Reverse();
    cout << "\n\n Queue After Reverse : ";
    MyQueue.Print();

    MyQueue.UpdateItem(2,600);
    cout << "\n\n Queue After Update Item (2) To 600 : ";
    MyQueue.Print();

    MyQueue.InsertAfter(2, 800);
    cout << "\n\n Queue After Insert 800 After Item (2)  : ";
    MyQueue.Print();

    MyQueue.InsertAtFront(1000);
    cout << "\n\n Queue After Insert 2000 At Front  : ";
    MyQueue.Print();

    MyQueue.InsertAtBack(2000);
    cout << "\n\n Queue After Insert 2000 At Back  : ";
    MyQueue.Print();

    MyQueue.Clear();
    cout << "\n\n Queue After Clear()  : ";
    MyQueue.Print();


    system("pause>0");
}
