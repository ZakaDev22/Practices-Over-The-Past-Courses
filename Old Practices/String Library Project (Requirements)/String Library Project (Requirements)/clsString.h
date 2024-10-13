
#pragma once

#include <iostream>
#include <string>
#include <vector>

using namespace std;

class clsString
{

private:
    string _Value;
    char   _char;
    char   _letter;
    short _OrderDay;
    string _DateString;
    string _stringtoReplece;
    string _replaceTo;

    struct stDate
    {
        short year = 0;
        short month = 0;
        short day = 0;
    };

public :

    clsString()
    {

        _Value = "";
        _char = ' ';
        _letter = ' ';
        _OrderDay = 0;
        _DateString = "";
        _stringtoReplece = "";
        _replaceTo = "";
    }

    clsString(string Value,char Char , char letter,short DayOrder,string DateString,string stringtoReplece,string replaceTo)
    {

        _Value = Value;
        _char = Char;
        _letter = letter;
        _OrderDay = DayOrder;
        _DateString = DateString;
        _stringtoReplece = stringtoReplece;
        _replaceTo = replaceTo;
    }

    // property set
    void SeTreplaceTo(string replaceTo) {
        _replaceTo = replaceTo;
    }

    // property Get
    string GetreplaceTo() {
        return _replaceTo;
    }

    __declspec(property(get = GetreplaceTo, put = SeTreplaceTo)) string replaceTo;

    // property set
    void SeTstringtoReplece(string stringtoReplece) {
        _stringtoReplece = stringtoReplece;
    }

    // property Get
    string GetstringtoReplece() {
        return _stringtoReplece;
    }

    __declspec(property(get = GetstringtoReplece, put = SeTstringtoReplece)) string stringtoReplece;

    // property set
    void SeDateStringt(string DateString) {
        _DateString = DateString;
    }

    // property Get
    string GetDateString() {
        return _DateString;
    }

    __declspec(property(get = GetDateString, put = SeDateStringt)) string DateString;


    // property set
    void SetValue(string Value) {
        _Value = Value;
    }

    // property Get
    string GetValue() {
        return _Value;
    }

    __declspec(property(get = GetValue, put = SetValue)) string Value;

    // property set
    void SetChar(char Char) {
        _char = Char;
    }

    // property Get
    char GetChar() {
        return _char;
    }

    __declspec(property(get = GetChar, put = SetChar)) char Char;

    // property set
    void SetLetter(char letter) {
        _letter = letter;
    }

    // property Get
    char Getletter() {
        return _letter;
    }

    __declspec(property(get = Getletter, put = SetLetter)) char letter;

    // property set
    void SetDayOrder(short OrderDay) {
        _OrderDay = OrderDay;
    }

    // property Get
    short GetDayOrder() {
        return _OrderDay;
    }

    __declspec(property(get = GetDayOrder, put = SetDayOrder)) short OrderDay;

    // Replace String Words
    static string ReplaceStringWords(string s1, string stringtoReplece, string replaceTo)
    {

        short pos = s1.find(stringtoReplece);

        while (pos != string::npos)
        {
            s1.replace(pos, stringtoReplece.length(), replaceTo);

            pos = s1.find(stringtoReplece);
        }


        return s1;
    }

    string ReplaceStringWords()
    {
        return ReplaceStringWords(_Value, _stringtoReplece, _replaceTo);
    }

    // count String Words
    static short CountWords(string S1)
    {

        string delim = " "; // delimiter  
        short Counter = 0;
        short pos = 0;
        string sWord; // define a string variable  

        // use find() function to get the position of the delimiters  
        while ((pos = S1.find(delim)) != std::string::npos)
        {
            sWord = S1.substr(0, pos); // store the word   
            if (sWord != "")
            {
                Counter++;
            }

            //erase() until positon and move to next word.
            S1.erase(0, pos + delim.length());
        }

        if (S1 != "")
        {
            Counter++; // it counts the last word of the string.
        }

        return Counter;

    }

    short CountWords()
    {
        return CountWords(_Value);
    };

    // reset the screen functon
    static void resetScreen()
    {
        system("cls");
        system("color 0F");
    }

    // static Split String
    static vector <string> SplitString(string s1, string delim)
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

    vector <string> SplitString()
    {
        return  SplitString(_Value, " ");
    }

    // reading character 
    static char readChar()
    {
        char s;

        cout << " please enter a character you want to invert! " << endl;
        cin >> s;
        return s;
    }

    // is Punctution 
    static bool IsPunctuation(char char1)
    {
        return ispunct(char1);
    }

    bool IsPunctuation()
    {
        return IsPunctuation(_char);
    }

    // Is Vowel
    static bool IsVowel(char char1)
    {
        char1 = tolower(char1);

        return (('a' == char1) || ('i' == char1) || ('o' == char1) || ('e' == char1) || ('u' == char1));
    }

    bool IsVowel()
    {
        return  IsVowel(_char);
    }


    // use this function if you want to invert letters.
    static char invertCharacters(char letter)
    {
        return isupper(letter) ? tolower(letter) : toupper(letter);
    }

    char invertCharacters()
    {
        return invertCharacters(_letter);
    }

    // reading string from user.
    static string readString()
    {
        string s1 = "";

        cout << "\n please enter the string you want! : ";
        getline(cin, s1);

        return s1;
    }

    // to upper all the string.
    static string ToUpperAllTheString(string s1)
    {

        for (int i = 0; i < s1.length(); i++)
        {
            s1[i] = toupper(s1[i]);
        }
        return s1;
    }

    string ToUpperAllTheString()
    {
        return ToUpperAllTheString(_Value);
    }

    // to lower all the string.
    static string ToLowerAllTheString(string s1)
    {

        for (int i = 0; i < s1.length(); i++)
        {
            s1[i] = tolower(s1[i]);
        }
        return s1;
    }

    string ToLowerAllTheString()
    {
        return  ToLowerAllTheString(_Value);
    }

    //Name of the Day Order
    static string NameOfOrderDay(short OrderDay)
    {

        string arrDays[7] = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        return arrDays[OrderDay];
    }

    string NameOfOrderDay()
    {
        return NameOfOrderDay(_OrderDay);
    }

    // String To Date
   static stDate StringToDate(string s1)
    {
        stDate date;

        vector <string> vDateInfo = SplitString(s1, "/");

        date.day = stoi(vDateInfo[0]);
        date.month = stoi(vDateInfo[1]);
        date.year = stoi(vDateInfo[2]);

        return date;
    }

   stDate StringToDate()
   {
       return  StringToDate(_DateString);
   }

   // Date To String
   static string DateToString(stDate date, string seperator = "/")
   {
       return  to_string(date.day) + seperator + to_string(date.month) + seperator + to_string(date.year);
   }

  
};

