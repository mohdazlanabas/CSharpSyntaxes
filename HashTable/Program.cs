using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(6, "Six");

            Hashtable myHashtable = new Hashtable(myDictionary);
            string valueOfOne = (string)myHashtable[1];
            string valueOfSix = (string)myHashtable[6];
            Console.WriteLine($"Value Of One = {valueOfOne}");
            Console.WriteLine($"Value Of Six = {valueOfSix}");

            foreach (DictionaryEntry value in myHashtable)
            {
                Console.WriteLine($"Key: {value.Key}; Value: {value.Value}");
            }

            
        }
    }
}