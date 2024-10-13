
#include <iostream>
#include "clsQueueLine.h"
using namespace std;

int main()
{
	clsQueueLine PayBillsQueue("A0", 10);
	clsQueueLine SubscriptionsQueue("B0", 5);

	clsQueueLine VIP_QueueLine("V0", 1);

	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket(); 
	PayBillsQueue.IssueTicket(); 
	PayBillsQueue.IssueTicket();

	cout << "\n Pay Bills Queue Info : \n";
	PayBillsQueue.PrintInfo();

	PayBillsQueue.PrintTicketsLineRTL();
	PayBillsQueue.PrintTicketsLineLTR();

	cout << "\n Print All Queue Tickets : \n";
	PayBillsQueue.PrintAllTickets();


	PayBillsQueue.ServeNextClient();
	cout << "\n Pay Bills Queue Info After Serving One Client : \n";
	PayBillsQueue.PrintInfo();

	//==================================================

	SubscriptionsQueue.IssueTicket();
	SubscriptionsQueue.IssueTicket();
	SubscriptionsQueue.IssueTicket();

	cout << "\n Subscriptions Queue Info : \n";
	SubscriptionsQueue.PrintInfo();

	SubscriptionsQueue.PrintTicketsLineRTL();
	SubscriptionsQueue.PrintTicketsLineLTR();

	cout << "\n Print All Queue Tickets : \n";
	SubscriptionsQueue.PrintAllTickets();


	SubscriptionsQueue.ServeNextClient();
	cout << "\n Subscriptions Queue Info After Serving One Client : \n";
	SubscriptionsQueue.PrintInfo();

	system("pause>0");

}