using System;
using System.Collections.Generic;

public static class LongestIncreasingSubsequenceRecursive
{
    private const int NoPrevious = -1;

    private static readonly int[] Sequence = { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };

    private static int[] lis = new int[Sequence.Length];

    private static int[] back = new int[Sequence.Length];

    public static void Main()
    {
        for (var i = 0; i < Sequence.Length; i++)
        {
            back[i] = NoPrevious;
        }

        for (var i = 0; i < Sequence.Length; i++)
        {
            CalcLongestIncreasingSubsequence(i);
        }

        Console.WriteLine("Sequence = " + string.Join(", ", Sequence));
        Console.WriteLine("lis = " + string.Join(", ", lis));
        Console.WriteLine("back = " + string.Join(", ", back));

        var maxElementIndex = FindMaxElementIndex(Sequence);

        PrintLongestIncreasingSubsequence(Sequence, back, maxElementIndex);
    }

    private static void CalcLongestIncreasingSubsequence(int k)
    {
        if (lis[k] > 0)
        {
            // Memoization (https://en.wikipedia.org/wiki/Memoization)
            return;
        }

        lis[k] = 1;
        for (var i = 0; i <= k - 1; i++)
        {
            if (Sequence[i] < Sequence[k])
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

    private static int FindMaxElementIndex(int[] sequence)
    {
        var maxElement = sequence[0];
        var maxElementIndex = 0;
        for (var i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > maxElement)
            {
                maxElement = sequence[i];
                maxElementIndex = i;
            }
        }

        return maxElementIndex;
    }

    private static void PrintLongestIncreasingSubsequence(int[] sequence, int[] back, int maxElementIndex)
    {
        var lis = new List<int>();
        while (maxElementIndex != NoPrevious)
        {
            lis.Add(sequence[maxElementIndex]);
            maxElementIndex = back[maxElementIndex];
        }

        lis.Reverse();
        Console.WriteLine("subsequence = " + string.Join(" ", lis));
    }
}
