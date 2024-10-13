#pragma once

#include <iostream>
#include <string>
#include <vector>

using namespace std;

namespace mylib
{
	// reset the screen functon
	void resetScreen()
	{
		system("cls");
		system("color 0F");
	}

	// Split String
	vector <string> SplitString(string s1, string delim)
	{
		vector <string> vWords;

		short pos = 0;

		string sWord;

		while ((pos = s1.find(delim)) != std::string::npos)
		{
			sWord = s1.substr(0, pos);

			if (sWord != "")
			{
				vWords.push_back(sWord);

			}
			s1.erase(0, pos + delim.length());
		}

		if (sWord != "")
		{
			vWords.push_back(s1);
		}

		return vWords;
	}


	// Join String Using vector
	string JoinString(vector <string> vwords, string delim)
	{
		string s1;

		for (string& words : vwords)
		{
			s1 += words + delim;
		}

		return s1.substr(0, s1.length() - delim.length());
	}


	// is Punctution 
	bool IsPunctution(char char1)
	{
		return ispunct(char1);
	}

	// Is Vowel
	bool IsVowel(char char1)
	{
		char1 = tolower(char1);

		return (('a' == char1) || ('i' == char1) || ('o' == char1) || ('e' == char1) || ('u' == char1));
	}

	// reading character 
	char readChar()
	{
		char s;

		cout << " please enter a character you want to invert! " << endl;
		cin >> s;
		return s;
	}

	// use this function if you want to invert letters.
	char invertCharacters(char letter)
	{
		return isupper(letter) ? tolower(letter) : toupper(letter);
	}

	// reading string from user.
	string readstring()
	{
		string s1 = "";

		cout << "\n please enter the string you want! : ";
		getline(cin, s1);

		return s1;
	}

	// to upper all the string.
	string ToUpperallTheString(string s1)
	{

		for (int i = 0; i < s1.length(); i++)
		{
			s1[i] = toupper(s1[i]);
		}
		return s1;
	}
	
	// to lower all the string.
	string TolowerallTheString(string s1)
	{

		for (int i = 0; i < s1.length(); i++)
		{
			s1[i] = tolower(s1[i]);
		}
		return s1;
	}
}