using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    internal class LongestSubstring
    {
        //abcdab
        public static int Length(string s)
        {
            Hashtable subStrTable = new Hashtable();            
            string longestString = "";
            for (int index = 0; index < s.Length;index++)
            {
                subStrTable.Clear();
                for (int subIndex = index, lenght = 1; subIndex < s.Length; subIndex++, lenght++)
                {                    
                    if (!subStrTable.ContainsKey(s[subIndex]))
                    {
                        var subString = s.Substring(index, lenght);
                        subStrTable.Add(s[subIndex], null);
                        if (longestString.Length < subString.Length)
                            longestString = subString;
                    }
                    else
                    {
                                                
                        break;
                    }
                }
            }
            return longestString.Length;
        }
    }
}
