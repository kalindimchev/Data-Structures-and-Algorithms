using System;
using System.Collections.Generic;

public static class LongestCommonSubsequence
{
    private const int NotCalculated = -1;

    private static string firstStr = "xabcxxxx";

    private static string secondStr = "abcxxyxabcx";

    private static int[,] lcs = new int[firstStr.Length, secondStr.Length];

    public static void Main()
    {
        InitializeArray();

        CalcLCS(firstStr.Length - 1, secondStr.Length - 1);

        PrintLCS(firstStr.Length - 1, secondStr.Length - 1);
    }

    private static void InitializeArray()
    {
        for (var x = 0; x < firstStr.Length; x++)
        {
            for (var y = 0; y < secondStr.Length; y++)
            {
                lcs[x, y] = NotCalculated;
            }
        }
    }

    private static int CalcLCS(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            return 0;
        }

        if (lcs[x, y] == NotCalculated)
        {
            var lcsFirstMinusOne = CalcLCS(x - 1, y);
            var lcsSecondMinusOne = CalcLCS(x, y - 1);
            lcs[x, y] = Math.Max(lcsFirstMinusOne, lcsSecondMinusOne);
            if (firstStr[x] == secondStr[y])
            {
                var lcsBothMinusOne = 1 + CalcLCS(x - 1, y - 1);
                lcs[x, y] = Math.Max(lcs[x, y], lcsBothMinusOne);
            }
        }

        return lcs[x, y];
    }

    private static void PrintLCS(int x, int y)
    {
        Console.WriteLine("LCS = " + CalcLCS(x, y));

        var lcsLetters = new List<char>();
        while (x >= 0 && y >= 0)
        {
            if ((firstStr[x] == secondStr[y]) && (CalcLCS(x - 1, y - 1) + 1 == lcs[x, y]))
            {
                lcsLetters.Add(firstStr[x]);
                x--;
                y--;
            }
            else if (CalcLCS(x - 1, y) == lcs[x, y])
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
