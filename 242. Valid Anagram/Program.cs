/*
Given two strings s and t, return true if t is an 
anagram
 of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
*/

Console.WriteLine(IsAnagram("cat","cat"));

bool IsAnagram(string s, string t)
{
    char[] sChars = s.ToArray();
    char[] tChars = t.ToArray();
    Array.Sort(sChars);
    Array.Sort(tChars);
    return  sChars.SequenceEqual(tChars);
}