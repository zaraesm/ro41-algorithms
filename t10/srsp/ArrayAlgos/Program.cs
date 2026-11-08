using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ BubbleSort и IsSorted ===");
        int[][] testArrays = {
            new int[] { },
            new int[] { 5 },
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 },
            new int[] { 3, 1, 3, 2, 3 }
        };

        foreach (var arr in testArrays)
        {
            // Создаем копию массива для теста, чтобы менять оригинал в BubbleSort
            int[] arrCopy = (int[])arr.Clone();
            
            Console.WriteLine($"До: [{string.Join(", ", arrCopy)}]");
            bool sortedBefore = ArrayAlgos.IsSorted(arrCopy);
            
            int comps = ArrayAlgos.BubbleSort(arrCopy);
            
            bool sortedAfter = ArrayAlgos.IsSorted(arrCopy);
            Console.WriteLine($"После: [{string.Join(", ", arrCopy)}]");
            Console.WriteLine($"IsSorted до: {sortedBefore}, после: {sortedAfter}, Сравнений: {comps}");
            Console.WriteLine(new string('-', 35));
        }

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ CountOccurrences ===");
        int[] sortedArray = { 1, 2, 2, 2, 5, 7 };
        int[] targets = { 2, 1, 7, 3, 9 };

        Console.WriteLine($"Массив: [{string.Join(", ", sortedArray)}]");
        foreach (var x in targets)
        {
            int count = ArrayAlgos.CountOccurrences(sortedArray, x);
            Console.WriteLine($"x = {x} -> Вхождений: {count} (ожидается по условию: см. методичку)");
        }
    }
}
