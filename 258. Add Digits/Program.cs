/*
Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.
Example 2:

Input: num = 0
Output: 0
 

Constraints:

0 <= num <= 231 - 1
*/

Console.WriteLine(AddDigits(0));

int AddDigits(int num)
{

    List<int> digits = new List<int>();
    while (num >= 10)
    {
        while (num > 0)
        {
            digits.Add(num % 10);
            num /= 10;
        }
        foreach (int digit in digits) num += digit;
        digits.Clear();
    }
    return num;
}