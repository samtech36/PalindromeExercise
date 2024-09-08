using System;
using System.Linq;


namespace PalindromeExercise;

public class Stringlength
{
    public static string Go(string str)
    {
        return str.ToLower().Replace(" ", "");
    }

    public static string Reverse(string str)
    {
        var reverse = str.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }
}