
#include <iostream>
#include "clsMyString.h"
using namespace std;




int main()
{
	clsMyString s1;

	cout << "\n\n\t\t\t\t\t Redo/Undo Project \n\n";

	cout << "\n S1 Value = " << s1.Value << endl;

	s1.Value = "Zakaria";
	cout << "\n S1 Value = " << s1.Value << endl;

	s1.Value = "Zakaria2";
	cout << "\n S1 Value = " << s1.Value << endl;

	s1.Value = "Zakaria3";
	cout << "\n S1 Value = " << s1.Value << endl;

	//==============================================================
	cout << "\n\t\t Undo Method : \n\n";

	s1.Undo();
	cout << "\n S1 Value After Undo = " << s1.Value << endl;

	s1.Undo();
	cout << "\n S1 Value After Undo = " << s1.Value << endl;

	s1.Undo();
	cout << "\n S1 Value After Undo = " << s1.Value << endl;

	//======================================================================
	cout << "\n\t\t Redo Method : \n\n";

	s1.Redo();
	cout << "\n S1 Value After Redo = " << s1.Value << endl;

	s1.Redo();
	cout << "\n S1 Value After Redo = " << s1.Value << endl;

	s1.Redo();
	cout << "\n S1 Value After Redo = " << s1.Value << endl;

	system("pause>0");
}
