using System;



namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        var stringcount = Stringlength.Go(word);
        var reverseString = Stringlength.Reverse(stringcount);

        if (stringcount == reverseString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}