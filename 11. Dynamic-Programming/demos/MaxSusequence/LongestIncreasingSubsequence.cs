using System;
using System.Collections.Generic;

public static class LongestIncreasingSubsequence
{
    private const int NoPrevious = -1;

    public static void Main()
    {
        var arr = new[] { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };
        var lis = new int[arr.Length];
        var back = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            back[i] = NoPrevious;
        }

        int bestIndex = CalculateLongestIncreasingSubsequence(arr, lis, back);

        Console.WriteLine("arr = " + string.Join(", ", arr));
        Console.WriteLine("lis = " + string.Join(", ", lis));
        Console.WriteLine("back = " + string.Join(", ", back));

        PrintLongestIncreasingSubsequence(arr, back, bestIndex);
    }

    private static int CalculateLongestIncreasingSubsequence(int[] arr, int[] lis, int[] back)
    {
        int bestF = 0;
        int bestIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            lis[i] = 1;
            for (int k = 0; k <= i - 1; k++)
            {
                if (arr[k] < arr[i])
                {
                    if (lis[k] + 1 > lis[i])
                    {
                        lis[i] = lis[k] + 1;
                        back[i] = k;
                        if (lis[i] > bestF)
                        {
                            bestF = lis[i];
                            bestIndex = i;
                        }
                    }
                }
            }
        }

        return bestIndex;
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
