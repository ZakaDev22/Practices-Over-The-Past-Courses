
#include <iostream>
#include "clsString.h"

using namespace std;


int main()

{
    clsString String1;
    clsString String2("Mohammed",'a','z',1,"1/3/2021","za","zi");

    String1.Value = "Mohammed wolf Of Programming";

    String1.stringtoReplece = "wolf";
    String1.replaceTo = "king";
    cout << String1.Value << endl;

    String1.ReplaceStringWords(String1.Value,"wolf","king");
    cout << String1.Value << endl;


   /* cout << String1.ToUpperAllTheString() << endl;
    cout << clsString::ToUpperAllTheString("zaka the king") << endl;

    cout << String1.ToLowerAllTheString() << endl;
    cout << clsString::ToLowerAllTheString("ZAKA THE KING") << endl;*/
    
    //string s1 = clsString::readString();

   /* String1.letter = 'i';
    cout << clsString::invertCharacters('z') << endl;

    String1.letter = 'a';
    cout << String1.invertCharacters() << endl;*/

    /* String1.Char = ';';
    cout << String1.IsPunctuation() << endl;


    String1.Char = 's';
    cout << String1.IsVowel() << endl;*/

    /* vector <string> vwords;

     vwords = clsString::SplitString("Mohammed zaka Abu Hadhoud"," ");*/


   /* cout << "String1 = " << String1.Value << endl;
    cout << "String2 = " << String2.Value << endl;


    cout << "Number of words: " << String1.CountWords() << endl;

    cout << "Number of words: " << String1.CountWords("Fadi ahmed rateb omer") << endl;

    cout << "Number of words: " <<
        clsString::CountWords("Mohammed Saqer Abu-Hadhoud");*/


    system("pause>0");
    return 0;
};

