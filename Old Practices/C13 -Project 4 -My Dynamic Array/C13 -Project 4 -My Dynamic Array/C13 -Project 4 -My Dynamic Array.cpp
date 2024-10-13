
#include <iostream>
#include "clsDynamicArray.h"

using namespace std;

int main()
{
	clsDynamicArray <int> MyDynamicArr(5);


	MyDynamicArr.SetItem(0, 10);
	MyDynamicArr.SetItem(1, 20);
	MyDynamicArr.SetItem(2, 30);
	MyDynamicArr.SetItem(3, 40);
	MyDynamicArr.SetItem(4, 50);

	cout << "\n Is Empty ? " << MyDynamicArr.IsEmpty() << endl;
	cout << "\n Arr Size : " << MyDynamicArr.Size() << endl;

	cout << "\n Arr Elements : ";
	MyDynamicArr.PrintList();


	MyDynamicArr.InsertAtBeginning(400);
	cout << "\n\n Arr Elements After Inserting 400 At Beginning : \n";
	cout << " Arr Size : " << MyDynamicArr.Size() << endl;
	MyDynamicArr.PrintList();

	MyDynamicArr.InsertAtEnd(800);
	cout << "\n\n Arr Elements After Inserting 800 At End : \n";
	cout << " Arr Size : " << MyDynamicArr.Size() << endl;
	MyDynamicArr.PrintList();

	MyDynamicArr.InsertBefore(2,500);
	cout << "\n\n Arr Elements After Inserting 500 Before Index 2 : \n";
	cout << " Arr Size : " << MyDynamicArr.Size() << endl;
	MyDynamicArr.PrintList();

	MyDynamicArr.InsertAfter(2, 600);
	cout << "\n\n Arr Elements After Inserting 600 After Index 2 : \n";
	cout << " Arr Size : " << MyDynamicArr.Size() << endl;
	MyDynamicArr.PrintList();

	

	system("pause>0");
}

