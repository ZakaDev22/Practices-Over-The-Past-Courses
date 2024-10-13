
#include <queue>
#include <iostream>

using namespace std;


int main()
{
	// Queue container declaration
	queue <int> MyQueue;

	// pushing elements into first stack
	MyQueue.push(10);
	MyQueue.push(20);
	MyQueue.push(30);
	MyQueue.push(40);

	cout << "\n Queue Size  = " << MyQueue.size() << endl;
	cout << "\n Queue Front = " << MyQueue.front() << endl;
	cout << "\n Queue Back  = " << MyQueue.back() << endl;

	cout << "\n Queue Elements  = ";
	while (!MyQueue.empty())
	{
		cout << MyQueue.front() << " ";

		MyQueue.pop();
	}

	system("pause>0");
	return 0;
}
