/*

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
*/

using System.Text;

Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

bool IsPalindrome(string s)
{
    s = s.Trim();
    s = s.ToLower();

    StringBuilder charOnly = new StringBuilder();

    foreach (char item in s)
    {
        if (char.IsLetterOrDigit(item))
            charOnly.Append(item);
    }

    s = charOnly.ToString();

    if (s.Equals(string.Empty) || s.Equals(new string(s.Reverse().ToArray())))
        return true;
        
    return false;
}

//1 2 3 4 5 6 7
//    