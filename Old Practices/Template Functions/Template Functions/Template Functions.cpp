
#include <iostream>
using namespace std;

template <typename T> T MyMax(T Number1, T Number2)
{
	return (Number1 > Number2) ? Number1 : Number2;
}

int main()
{
	cout << MyMax<int>(21, 24) << endl;
	cout << MyMax<double>(21.2, 24.3) << endl;
	cout << MyMax<char>('a', 'Z') << endl;

	return 0;
}

