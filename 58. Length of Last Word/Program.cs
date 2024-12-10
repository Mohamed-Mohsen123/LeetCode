// Given a string s consisting of words and spaces, return the length of the last word in the string.

// A word is a maximal 
// substring
//  consisting of non-space characters only.



// Example 1:

// Input: s = "Hello World"
// Output: 5
// Explanation: The last word is "World" with length 5.
// Example 2:

// Input: s = "   fly me   to   the moon  "
// Output: 4
// Explanation: The last word is "moon" with length 4.
// Example 3:

// Input: s = "luffy is still joyboy"
// Output: 6
// Explanation: The last word is "joyboy" with length 6.


// Constraints:

// 1 <= s.length <= 104
// s consists of only English letters and spaces ' '.
// There will be at least one word in s.

Console.WriteLine(LengthOfLastWord("  a c    e "));


int LengthOfLastWord(string s)
{
    s = s.Trim();
    string[] wordsArray = s.Split(' ');
    return wordsArray[wordsArray.Length - 1].Length;
}


//potatoe code
// int LengthOfLastWord(string s)
// {
//     // int startIndex = 0;
//     // while (s[startIndex] == ' ')
//     // {   
//     //     startIndex++;
//     //     continue;
//     // }
//     if (s == string.Empty)
//         return 0;
//     int endIndex = s.Length - 1;
//     while (endIndex >= 0 && s[endIndex] == ' ')
//     {
//         endIndex--;
//     }
//     int startIndex = 0;
//     while (startIndex < s.Length && s[startIndex] == ' ')
//     {
//         startIndex++;
//     }
//     int index = endIndex;
//     int counter = 0;
//     while (index >= startIndex && s[index] != ' ')
//     {
//         counter++;
//         index--;
//     }
//     return counter;
// }

