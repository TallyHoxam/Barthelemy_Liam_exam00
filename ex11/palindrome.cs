using System.Collections.Generic;
using System.Linq;

public static bool IsPalindrome(string str)
{
    string final = ""
    List<char> listeLettres = str.ToList();
    int dernier_index = listeLettres.Count;
    for (i = dernier_index; i>=0; i-= 1)
    {
        final += listeLettres[i];
    }
    if(str == final)
    {
        Output: true
    }
    else
    {
        Output: false
    }
}