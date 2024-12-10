/*

Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnNumber = 1
Output: "A"
Example 2:

Input: columnNumber = 28
Output: "AB"
Example 3:

Input: columnNumber = 701
Output: "ZY"
 

Constraints:

1 <= columnNumber <= 231 - 1
*/

using System.Text;


Console.WriteLine(ConvertToTitle(182777));

string ConvertToTitle(int columnNumber)
{
    int digit = 0;
    StringBuilder title = new StringBuilder();
    while (columnNumber > 0)
    {
        columnNumber--;
        digit = columnNumber % 26;
        title.Append(Convert.ToChar(digit + 'A'));
        columnNumber /= 26;
    }

    return new string(title.ToString().Reverse().ToArray());
}

//zy

