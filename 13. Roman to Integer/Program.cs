using System.Collections.Generic;
/*

MCMXCIV
M=>1000 
(C before M && C<M then C becomes negative) C=>-100 
M=>1000  
X=>-10(before C) 
C=>100 I=>-1(before V) 
V=>5 
sum=1000+(-100)+1000+(-10)+100+(-1)+5=1994
*/


Dictionary<char, int> SymbolToInt = new Dictionary<char, int>(7);
SymbolToInt.Add('I', 1);
SymbolToInt.Add('V', 5);
SymbolToInt.Add('X', 10);
SymbolToInt.Add('L', 50);
SymbolToInt.Add('C', 100);
SymbolToInt.Add('D', 500);
SymbolToInt.Add('M', 1000);


Console.WriteLine(RomanToInt("MCMXCIV"));

int RomanToInt(string s)
{
    int sum = 0;
    for (int i = 0; i < s.Length - 1; i++)
    {
        if (SymbolToInt[s[i]] < SymbolToInt[s[i + 1]])
            sum -= SymbolToInt[s[i]];
        else
            sum += SymbolToInt[s[i]];        
    }
    sum += SymbolToInt[s[s.Length - 1]];
    return sum;
}

