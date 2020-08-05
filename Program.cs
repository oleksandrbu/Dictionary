using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Split the original string into the string after the delimiter and the remainder of the original string after the delimiter";
            String[] wordList = str.Split(' ', StringSplitOptions.None);
            Dictionary<string, uint> mainDictionary = GetWordCount(wordList);

            Dictionary<string, uint>.KeyCollection strList = mainDictionary.Keys;
            Console.WriteLine("{0} {1}", "Key", "Values");
            foreach(string strEl in strList)
            {
                Console.WriteLine("{0} {1}", strEl, mainDictionary[strEl]);
            }
        }

        static public Dictionary<string, uint> GetWordCount(string[] wordList){
            Dictionary<string, uint> curDictionary = new Dictionary<string, uint>();
            foreach(string str in wordList)
            {
                if (curDictionary.ContainsKey(str)){
                    curDictionary[str] ++;
                } else {
                    curDictionary.Add(str, 1);
                }
            }

            return curDictionary;
        }
    }
}
