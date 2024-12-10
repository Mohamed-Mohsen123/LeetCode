// Write a function to find the longest common prefix string amongst an array of strings.

// If there is no common prefix, return an empty string "".


// Example 1:

// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.


// Constraints:

// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lowercase English letters.

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine(LongestCommonPrefix(["dog", "racecar", "car"]));



string LongestCommonPrefix(string[] strs)
{
    var sortedStrs = strs.OrderBy(element => element.Length);
    string[] sortedStrsArr = sortedStrs.ToArray();
    string first = sortedStrsArr[0];
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < first.Length; i++)
    {
        foreach (string item in sortedStrsArr)
        {
            if (item[i] != first[i])
                return result.ToString();
        }
        result.Append(first[i]);
    }
    return result.ToString();
}
//better sol 

/*
public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            String s1 = strs[0];
            String s2 = strs[strs.Length - 1];
            int idx = 0;
            while (idx < s1.Length && idx < s2.Length)
            {
                if (s1[idx] == s2[idx])
                {
                    idx++;
                }
                else
                {
                    break;
                }
            }
            return s1.Substring(0, idx);

        }
    
    
}
*/