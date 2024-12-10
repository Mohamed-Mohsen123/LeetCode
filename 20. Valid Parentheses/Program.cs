// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.


// Example 1:

// Input: s = "()"
// Output: true
// Example 2:

// Input: s = "()[]{}"
// Output: true
// Example 3:

// Input: s = "(]"
// Output: false


// Constraints:

// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.

//({]


Console.WriteLine(IsValid("[]}"));

bool IsValid(string s)
{
    Stack<char> brackets = new Stack<char>();
    Dictionary<char, char> opening = new Dictionary<char, char>{
        {')','('},
        {']','['},
        {'}','{'}
    };
    foreach (char item in s)
    {
        if (item == '(' || item == '[' || item == '{')
        {
            brackets.Push(item);
            continue;
        }
        //can pop? chek opening of bracket : (false of false = true) 
        //true with || = true then do the condition which is return false
        if (!brackets.TryPop(out char poppedValue) || opening[item] != poppedValue)
            return false;
    }
    return brackets.Count == 0;
}