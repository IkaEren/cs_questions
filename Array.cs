using System;
using System.Collections.Generic;

namespace cs_questions
{
    class Array {

        // Solutions to "First Non Repeated Character" problem in C#

        public char FirstNonRepeatingCharacter(string s) {
            Dictionary<char,int> dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++) {
                if (dict.ContainsKey(s[i])) {
                    // Increment dictionary value by 1 if
                    // dictionary key is the same as index of string 
                    dict[s[i]]++;
                }
                else {
                    // Initalize dictionary entry with char, and 
                    // value of 1
                    dict.Add(s[i],1);
                }
            }

            foreach (var item in dict)
            {
                // Because if there's a duplicate, the value will be more than 1
                if (item.Value == 1) {
                    Console.WriteLine(item);
                    return item.Key;
                }
            }

            return '_';
        }
    }
}