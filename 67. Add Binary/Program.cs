/*
Given two binary strings a and b, return their sum as a binary string.

 

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
*/

using System.ComponentModel;
using System.Text;
using System.Linq;

Console.WriteLine(AddBinary("1111", "0010"));

string AddBinary(string a, string b)
{
    StringBuilder result = new StringBuilder();
    int aIndex = a.Length - 1;
    int bIndex = b.Length - 1;
    int carry = 0;
    while (aIndex >= 0 || bIndex >= 0)
    {
        int sum = carry;
        if (aIndex >= 0)
            sum += a[aIndex--] - '0';
        if (bIndex >= 0)
            sum += b[bIndex--] - '0';
        result.Append(sum % 2); // if 2 returns 0 if 1 returns 1
        carry = sum / 2; // if sum==2 => carry = 1          if sum==1 => carry = 0
    }
    if (carry != 0)
        result.Append(carry);
    return new string(result.ToString().Reverse().ToArray());
}


