using System.Reflection;

namespace cs_console_game.Helpers;

public class StringHelper
{
    public static string ProcessText(string text, int code)
    {
        switch (code)
        {
            case 1: return ShowWordsWithMostDigits(text);
            case 2: return FindLongestWord(text);
            case 3: return ReplaceDigitsWithWords(text);
            case 4: return ShowFirstQuestionsThenExclamations(text);
            case 5: return ShowStatementsWithoutCommas(text);
            case 6: return ShowWordsWithSameFirstLastLetters(text);
        }
        
        return text;
    }
    private static string ShowWordsWithMostDigits(string text)
    {
        return text;
    }
    private static string FindLongestWord(string text)
    {
        return text;
    }
    private static string ReplaceDigitsWithWords(string text)
    {
        return text;
    }
    private static string ShowFirstQuestionsThenExclamations(string text)
    {
        return text;
    }
    private static string ShowStatementsWithoutCommas(string text)
    {
        return text;
    }
    private static string ShowWordsWithSameFirstLastLetters(string text)
    {
        return text;
    }
}