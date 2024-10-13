using System;
using System.Collections;

namespace Working_with_Hashtable_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable MyHashTable = new Hashtable();

            MyHashTable.Clear();

            MyHashTable.Add(1, "C#");

            MyHashTable.Add(2, "Java");

            MyHashTable.Add(3, "Python");

            MyHashTable.Add(4, "JavaScript");

            MyHashTable.Add(5, "C++");

            MyHashTable.Add(6, "C");

            MyHashTable.Add(7, "PHP");

            MyHashTable.Add(8, "Ruby");


            Console.WriteLine($"\nPrinting First Item In HashTable : {MyHashTable[1]}");

            MyHashTable.Remove(3);

            Console.WriteLine($"\nis Python in HashTable : {MyHashTable.ContainsKey(3)}");

            Console.WriteLine($"\nCount of HashTable : {MyHashTable.Count}");

            foreach (DictionaryEntry item in MyHashTable)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
