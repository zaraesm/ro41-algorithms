using System;

public static class ArrayAlgos
{
    // 1. Проверка, отсортирован ли массив по возрастанию
    public static bool IsSorted(int[] a)
    {
        if (a == null || a.Length <= 1)
            return true;

        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] > a[i + 1])
                return false;
        }
        return true;
    }

    // 2. Сортировка пузырьком с флагом раннего выхода, возвращает число сравнений
    public static int BubbleSort(int[] a)
    {
        if (a == null || a.Length <= 1)
            return 0;

        int comparisons = 0;
        int n = a.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                comparisons++;
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }

        return comparisons;
    }

    // Вспомогательный метод: первый индекс элемента >= x (Lower Bound)
    private static int LowerBound(int[] a, int x)
    {
        int lo = 0;
        int hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] >= x)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    // Вспомогательный метод: первый индекс элемента > x (Upper Bound)
    private static int UpperBound(int[] a, int x)
    {
        int lo = 0;
        int hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] > x)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    // 3. Количество вхождений через два бинарных поиска
    public static int CountOccurrences(int[] sortedA, int x)
    {
        if (sortedA == null || sortedA.Length == 0)
            return 0;

        int leftIndex = LowerBound(sortedA, x);
        
        // Если элемент вообще не найден или выходит за рамки
        if (leftIndex == sortedA.Length || sortedA[leftIndex] != x)
            return 0;

        int rightIndex = UpperBound(sortedA, x);

        return rightIndex - leftIndex;
    }
}
