using System;
using System.Collections.Generic;

public static class LongestIncreasingSubsequence
{
    private const int NoPrevious = -1;

    public static void Main()
    {
        var sequence = new[] { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };
        var lis = new int[sequence.Length];
        var back = new int[sequence.Length];

        for (var i = 0; i < sequence.Length; i++)
        {
            back[i] = NoPrevious;
        }

        var bestIndex = CalculateLongestIncreasingSubsequence(sequence, lis, back);

        Console.WriteLine("sequence = " + string.Join(", ", sequence));
        Console.WriteLine("lis = " + string.Join(", ", lis));
        Console.WriteLine("back = " + string.Join(", ", back));

        PrintLongestIncreasingSubsequence(sequence, back, bestIndex);
    }

    private static int CalculateLongestIncreasingSubsequence(int[] sequence, int[] lis, int[] back)
    {
        var bestF = 0;
        var bestIndex = 0;
        for (var i = 0; i < sequence.Length; i++)
        {
            lis[i] = 1;
            for (var k = 0; k <= i - 1; k++)
            {
                if (sequence[k] < sequence[i])
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

    private static void PrintLongestIncreasingSubsequence(int[] sequence, int[] back, int bestIndex)
    {
        var lis = new List<int>();
        while (bestIndex != NoPrevious)
        {
            lis.Add(sequence[bestIndex]);
            bestIndex = back[bestIndex];
        }

        lis.Reverse();
        Console.WriteLine("subsequence = " + string.Join(" ", lis));
    }
}
