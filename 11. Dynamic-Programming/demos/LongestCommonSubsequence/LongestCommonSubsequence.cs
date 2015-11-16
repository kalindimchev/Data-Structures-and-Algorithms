using System;
using System.Collections.Generic;

public static class LongestCommonSubsequence
{
    private const int NotCalculated = -1;

    private const string FirstString = "xabcdxxxx";

    private const string SecondString = "abczxxyxabcx";

    private static readonly int[,] LcsArray = new int[FirstString.Length, SecondString.Length];

    public static void Main()
    {
        InitializeArray();
        CalculateLongestCommonSubsequence(FirstString.Length - 1, SecondString.Length - 1);
        PrintLongestCommonSubsequence(FirstString.Length - 1, SecondString.Length - 1);
    }

    private static void InitializeArray()
    {
        for (var x = 0; x < FirstString.Length; x++)
        {
            for (var y = 0; y < SecondString.Length; y++)
            {
                LcsArray[x, y] = NotCalculated;
            }
        }
    }

    private static int CalculateLongestCommonSubsequence(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            return 0;
        }

        if (LcsArray[x, y] == NotCalculated)
        {
            var lcsFirstMinusOne = CalculateLongestCommonSubsequence(x - 1, y);
            var lcsSecondMinusOne = CalculateLongestCommonSubsequence(x, y - 1);
            LcsArray[x, y] = Math.Max(lcsFirstMinusOne, lcsSecondMinusOne);
            if (FirstString[x] == SecondString[y])
            {
                var lcsBothMinusOne = 1 + CalculateLongestCommonSubsequence(x - 1, y - 1);
                LcsArray[x, y] = Math.Max(LcsArray[x, y], lcsBothMinusOne);
            }
        }

        return LcsArray[x, y];
    }

    private static void PrintLongestCommonSubsequence(int x, int y)
    {
        Console.WriteLine("LCS = " + CalculateLongestCommonSubsequence(x, y));

        var lcsLetters = new List<char>();
        while (x >= 0 && y >= 0)
        {
            if ((FirstString[x] == SecondString[y]) && (CalculateLongestCommonSubsequence(x - 1, y - 1) + 1 == LcsArray[x, y]))
            {
                lcsLetters.Add(FirstString[x]);
                x--;
                y--;
            }
            else if (CalculateLongestCommonSubsequence(x - 1, y) == LcsArray[x, y])
            {
                x--;
            }
            else
            {
                y--;
            }
        }

        lcsLetters.Reverse();
        var lcsStr = string.Join(string.Empty, lcsLetters);
        Console.WriteLine(lcsStr);
    }
}
