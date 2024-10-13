#pragma once

#include <iostream>
#include <string>

#include "clsDate.h";

using namespace std;

class clsUtil
{

public:

	static int ReadPositiveNumber(string message)
	{
		int number = 0;

		do
		{
			cout << message << endl;
			cin >> number;

		} while (number < 0);

		return number;

	}

	static void Srand()
	{
		srand((unsigned)time(NULL));
	}

	static int  ReadRandNumber(int from, int to)
	{
		//  function to generate random number

		int reandnum = rand() % (to - from + 1) + from;

		return  reandnum;
	}

	enum enprimnotprim { prim = 1, notprim = 2 };

	static enprimnotprim CheckPrimeNumber(int number)
	{
		int num = round(number / 2);

		for (int i = 2; i <= num; i++)
		{
			if (number % i == 0)
				return enprimnotprim::notprim;

		}

		return enprimnotprim::prim;

	}

	static int FrequinceOfNumber(int digittocheck, int number)
	{
		int remainder = 0;

		int frequince = 0;

		while (number > 0)
		{

			remainder = number % 10;
			number = number / 10;


			if (remainder == digittocheck)
			{
				frequince++;
			}

		}

		return frequince;
	}

	static void PrintReversedNumber(int number)
	{
		int remainder = 0;
		int sum = 0;

		do
		{
			remainder = number % 10;
			number = number / 10;
			sum = remainder;

			cout << sum;

		} while (number > 0);
	}

	static void PrintSumOfDigits(int number)
	{
		int remainder = 0;

		int sum = 0;

		do
		{
			remainder = number % 10;
			number = number / 10;

			sum += remainder;

		} while (number > 0);


		cout << " \n \n the sum of digits number = " << sum << endl;

	}

	static bool IsPerfectNumber(int number)
	{
		int sum = 0;

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
				sum += i;
		}

		return number == sum;
	}

	static string encryption(string text, short PasswordKey)
	{

		for (int i = 0; i <= text.length(); i++)
		{
			text[i] = char((int)text[i] + PasswordKey);
		}

		return text;
	}

	static string decryption(string text, short PasswordKey)
	{

		for (int i = 0; i <= text.length(); i++)
		{
			text[i] = char((int)text[i] - PasswordKey);
		}

		return text;

	}

	enum eRandomChar { smallletters = 1, capitalllitters = 2, spacialcharacters = 3, digits = 4 };


	static char GetRandomCharacters(eRandomChar characterstype)
	{
		switch (characterstype)
		{
		case eRandomChar::smallletters:
			return char(ReadRandNumber(97, 122));
			break;

		case eRandomChar::capitalllitters:
			return char(ReadRandNumber(65, 90));
			break;

		case eRandomChar::digits:
			return char(ReadRandNumber(48, 57));
			break;

		case eRandomChar::spacialcharacters:
			return char(ReadRandNumber(33, 47));
			break;
		}
		return characterstype;
	}

	static void read_array(int arr[100], int& arrlength)
	{
		cout << "\n enter how meny ilements do you want : \n";
		cin >> arrlength;

		cout << "\n enter array ilements \n" << endl;
		for (int i = 0; i < arrlength; i++)
		{
			cout << " enter eliments [" << i + 1 << "] : ";
			cin >> arr[i];
		}
		cout << endl;
	}

	static void print_array(int arr[100], int arrlength)
	{
		for (int i = 0; i < arrlength; i++)
		{
			cout << arr[i] << " ";
		}
		cout << endl;
	}

	static int ArrMaxNumber(int arr[100], int arrlength)
	{
		int max = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (arr[i] > max)
			{
				max = arr[i];
			}
		}
		return max;
	}

	static int ArrMinNumber(int arr[100], int arrlength)
	{
		int min = 0;
		min = arr[0];

		for (int i = 0; i < arrlength; i++)
		{
			if (arr[i] < min)
			{
				min = arr[i];
			}
		}

		return min;
	}


	static int SumOfRandomArrays(int arr[100], int arrlength)
	{
		int sum = 0;

		for (int i = 0; i < arrlength; i++)
		{
			sum += arr[i];
		}

		return sum;
	}

	static void CopyArray(int arraysource[100], int arraydistination[100], int arrlength)
	{

		for (int i = 0; i < arrlength; i++)
		{
			arraydistination[i] = arraysource[i];
		}

		cout << endl;
	}

	static void CopyOnlyPrimNumber(int arr[100], int arrlength, int arr2[100], int& arrlength2)
	{
		int count = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (CheckPrimeNumber(arr[i]) == enprimnotprim::prim)
			{
				arr2[count] = arr[i];
				count++;
			}
		}
		arrlength2 = --count;

	}

	static void SumOf2ArraysInThirdArray(int arr[100], int arrlength, int arr2[100], int arrlength2, int arr3[100])
	{

		for (int i = 0; i < arrlength; i++)
		{
			arr3[i] = arr[i] + arr2[i];
		}
		cout << endl;
	}

	static void SwapNumbers(int& A, int& B)
	{
		int temp = A;
		A = B;
		B = temp;
	}

	static void ShuffleArrayIlements(int arr[100], int arrlength)
	{
		for (int i = 0; i < arrlength; i++)
		{
			SwapNumbers(arr[ReadRandNumber(1, arrlength) - 1], arr[ReadRandNumber(1, arrlength) - 1]);
		}
		cout << endl;
	}

	static void CopyArray1InReversedOrder(int arr[100], int arr2[100], int arrlength)
	{
		int count = arrlength;

		for (int i = 0; i < arrlength; i++)
		{
			count--;
			arr2[i] = arr[count];

		}
		cout << endl;

	}

	static string Get4letters(eRandomChar characterstype, short length)
	{
		string word;

		for (int i = 1; i <= length; i++)
		{
			word = word + GetRandomCharacters(characterstype);
		}

		return word;
	}

	static string GetFullKey()
	{
		string key = "";

		key = Get4letters(eRandomChar::capitalllitters, 4) + "-";
		key += Get4letters(eRandomChar::capitalllitters, 4) + "-";
		key += Get4letters(eRandomChar::capitalllitters, 4) + "-";
		key += Get4letters(eRandomChar::capitalllitters, 4);

		return key;
	}


	static short FindNumberPosition(int arr[100], int arrlength, int numbertocheck)
	{
		for (int i = 0; i < arrlength; i++)
		{
			if (arr[i] == numbertocheck)
				return i;
		}

		return -1;
	}

	static bool IsFoundNumber(int arr[100], int arrlength, int numbertocheck)
	{
		return FindNumberPosition(arr, arrlength, numbertocheck) != -1;
	}

	static bool IsPalandromeArray(int arr[100], int arrlength)
	{
		for (int i = 0; i < arrlength; i++)
		{
			if (arr[i] != arr[arrlength - i - 1])
				return false;
		}

		return true;
	}

	static short CountHowManyOddNumbers(int arrsours[100], int arrlength)
	{
		short SumOfOddNumbers = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (arrsours[i] % 2 != 0)
			{
				SumOfOddNumbers++;
			}
		}

		return SumOfOddNumbers;
	}

	static short CountHowManyEvenNumbers(int arrsours[100], int arrlength)
	{
		short SumOfEvenNumbers = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (arrsours[i] % 2 == 0)
			{
				SumOfEvenNumbers++;
			}
		}

		return SumOfEvenNumbers;
	}

	static short CountHowManyPositiveNumbers(int arrsours[100], int arrlength)
	{
		short SumOfEvenNumbers = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (arrsours[i] >= 0)
			{
				SumOfEvenNumbers++;
			}
		}

		return SumOfEvenNumbers;
	}

	static short CountHowManyNegativeNumbers(int arrsours[100], int arrlength)
	{
		short SumOfNegativeNumbers = 0;

		for (int i = 0; i < arrlength; i++)
		{
			if (arrsours[i] < 0)
			{
				SumOfNegativeNumbers++;
			}
		}

		return SumOfNegativeNumbers;
	}

};

