#pragma once

#include <iostream>
#include "clsDynamicArray.h"


using namespace std;
template <class T>

class clsMyQueueArr
{

protected:
	clsDynamicArray <T> MyArray;

public:

	void push(T Item)
	{
		MyArray.InsertAtEnd(Item);
	}


	void pop()
	{
		MyArray.DeleteFirstItem();
	}

	void Print()
	{
		MyArray.PrintList();
	}

	int Size()
	{
		return MyArray.Size();
	}

	bool IsEmpty()
	{
		return MyArray.IsEmpty();
	}

	T front()
	{
		return MyArray.GetItem(0);
	}

	T back()
	{
		return MyArray.GetItem(Size() - 1);
	}

	T GetItem(int Index)
	{
		return MyArray.GetItem(Index);

	}

	void Reverse()
	{

		MyArray.Reverse();

	}

	void UpdateItem(int Index, T NewValue)
	{
		MyArray.SetItem(Index, NewValue);

	}

	void InsertAfter(int Index, T NewValue)
	{
		MyArray.InsertAfter(Index, NewValue);
	}


	void InsertAtFront(T Value)
	{
		MyArray.InsertAtBeginning(Value);

	}

	void InsertAtBack(T Value)
	{
		MyArray.InsertAtEnd(Value);


	}


	void Clear()
	{
		MyArray.Clear();
	}



};


