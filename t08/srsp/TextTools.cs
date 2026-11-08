using System;
using System.Text;

public static class TextTools
{
    // 1. Подсчет слов
    public static int CountWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // 2. Проверка на палиндром (без учета регистра и пробелов)
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        // Оставляем только буквы/цифры или просто удаляем пробелы и приводим к нижнему регистру
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if (!char.IsWhiteSpace(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        string clean = sb.ToString();
        int len = clean.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (clean[i] != clean[len - 1 - i])
                return false;
        }
        return true;
    }

    // 3. Получение инициалов ("Ахметов Ерлан Серікұлы" -> "А. Е. С.")
    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            return string.Empty;

        string[] parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();

        foreach (var part in parts)
        {
            if (part.Length > 0)
            {
                sb.Append(char.ToUpper(part[0])).Append(". ");
            }
        }

        // Убираем последний лишний пробел, если он есть
        if (sb.Length > 0)
            sb.Length--;

        return sb.ToString();
    }

    // 4. Повторение строки через StringBuilder
    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0)
            return string.Empty;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }
}
