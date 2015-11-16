using System;
using System.Collections.Generic;

public static class LongestIncreasingSubsequenceRecursive
{
    private const int NoPrevious = -1;

    private static int[] arr = { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };

    private static int[] lis = new int[arr.Length];

    private static int[] back = new int[arr.Length];

    public static void Main()
    {
        for (var i = 0; i < arr.Length; i++)
        {
            back[i] = NoPrevious;
        }

        for (var i = 0; i < arr.Length; i++)
        {
            CalcLongestIncreasingSubsequence(i);
        }

        Console.WriteLine("arr = " + string.Join(", ", arr));
        Console.WriteLine("lis = " + string.Join(", ", lis));
        Console.WriteLine("back = " + string.Join(", ", back));

        var maxElementIndex = FindMaxElementIndex(arr);

        PrintLongestIncreasingSubsequence(arr, back, maxElementIndex);
    }

    private static void CalcLongestIncreasingSubsequence(int k)
    {
        if (lis[k] > 0)
        {
            // memoization
            return;
        }

        lis[k] = 1;
        for (var i = 0; i <= k - 1; i++)
        {
            if (arr[i] < arr[k])
            {
                CalcLongestIncreasingSubsequence(i);
                if (lis[i] + 1 > lis[k])
                {
                    lis[k] = lis[i] + 1;
                    back[k] = i;
                }
            }
        }
    }

    private static int FindMaxElementIndex(int[] arr)
    {
        var maxElement = arr[0];
        var maxElementIndex = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
                maxElementIndex = i;
            }
        }

        return maxElementIndex;
    }

    private static void PrintLongestIncreasingSubsequence(int[] arr, int[] back, int index)
    {
        var lis = new List<int>();
        while (index != NoPrevious)
        {
            lis.Add(arr[index]);
            index = back[index];
        }

        lis.Reverse();
        Console.WriteLine("subsequence = " + string.Join(" ", lis));
    }
}
