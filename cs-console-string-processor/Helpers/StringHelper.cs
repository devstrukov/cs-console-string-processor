using System.Reflection;

namespace cs_console_game.Helpers;

public class StringHelper
{
    private static readonly Dictionary<int, string> Numbers = new Dictionary<int, string>
    {
        {0, "ноль"},
        {1, "один"},
        {2, "два"},
        {3, "три"},
        {4, "четыре"},
        {5, "пять"},
        {6, "шесть"},
        {7, "семь"},
        {8, "восемь"},
        {9, "девять"},
    };
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
        text = GetFilteredText(text);
        string[] words = text.Split(" ");
        List<string> specificWords = new List<string>();

        string specificWord = "";
        int specificWordDigits = 0;

        foreach (var word in words)
        {
            int digits = word.Count(c => Char.IsDigit(c));
            
            if (digits > specificWordDigits)
            {
                specificWord = word;
                specificWordDigits = digits;
                specificWords.Clear();
                specificWords.Add(specificWord);
            }
            else if (digits == specificWordDigits)
            {
                specificWords.Add(word);
            }
        }
        
        return string.Join(", ", specificWords);
    }
    private static string FindLongestWord(string text)
    {
        text = GetFilteredText(text);
        string[] words = text.Split(" ");

        string specificWord = "";
        int specificWordCount = 0;

        foreach (var word in words)
        {
            if (word.Length > specificWord.Length)
            {
                specificWord = word;
                specificWordCount = 1;
            } 
            else if (word == specificWord)
            {
                specificWordCount++;
            }
        }
        
        return $"Слово {specificWord} встречается {specificWordCount} раза";
    }
    private static string ReplaceDigitsWithWords(string text)
    {
        foreach (var item in Numbers)
        {
            text = text.Replace(item.Key.ToString(), item.Value);
        }
        
        return text;
    }
    private static string ShowFirstQuestionsThenExclamations(string text)
    {
        return "Метод не реализован";
    }
    private static string ShowStatementsWithoutCommas(string text)
    {
        string[] statements = text.Split(".");
        List<string> specificStatements = new List<string>();

        foreach (var statement in statements)
        {
            if (statement.Contains(",")) continue;
            
            specificStatements.Add(statement);
        }
        
        return string.Join(". ", specificStatements);
    }
    private static string ShowWordsWithSameFirstLastLetters(string text)
    {
        text = GetFilteredText(text);
        string[] words = text.Split(" ");
        List<string> specificWords = new List<string>();

        foreach (string word in words)
        {
            if (word == "") continue;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            
            if (firstLetter == lastLetter)
            {
                specificWords.Add(word);
            }
        }
        
        return string.Join(", ", specificWords);
    }

    private static string GetFilteredText(string text)
    {
        text = text.Replace(",", "");
        text = text.Replace(".", "");
        text = text.Replace("\n", "");
        
        return text;
    }
}