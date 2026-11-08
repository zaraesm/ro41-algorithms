using System;

class Program
{
    static void Main()
    {
        string[] testStrings = { "", " ", " a b", "А роза упала на лапу Азора", "Ахметов Ерлан" };

        Console.WriteLine("=== ТЕСТИРОВАНИЕ TextTools ===");

        foreach (var test in testStrings)
        {
            Console.WriteLine($"Вход: \"{test}\"");
            
            // Тест CountWords
            int words = TextTools.CountWords(test);
            Console.WriteLine($"  CountWords -> Фактически: {words}");

            // Тест IsPalindrome
            bool isPal = TextTools.IsPalindrome(test);
            Console.WriteLine($"  IsPalindrome -> Фактически: {isPal}");

            // Тест Initials
            string initials = TextTools.Initials(test);
            Console.WriteLine($"  Initials -> Фактически: \"{initials}\"");

            // Тест Repeat (повторим строку 2 раза для примера)
            string repeated = TextTools.Repeat(test, 2);
            Console.WriteLine($"  Repeat(2) -> Фактически: \"{repeated}\"");
            
            Console.WriteLine(new string('-', 30));
        }
    }
}
