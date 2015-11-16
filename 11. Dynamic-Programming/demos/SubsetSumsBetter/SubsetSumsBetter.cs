using System;
using System.Collections.Generic;

public static class SubsetSumsBetter
{
    public static void Main()
    {
        int[] arr = { 2, 5, 10 };
        var targetSum = 50;

        var possible = CalcPossibleSums(arr, targetSum);

        // Print subset
        if (possible[targetSum])
        {
            PrintSubset(arr, targetSum, possible);
        }
        else
        {
            Console.WriteLine("Not possible");
        }
    }

    private static bool[] CalcPossibleSums(int[] arr, int targetSum)
    {
        var possible = new bool[targetSum + 1];
        possible[0] = true;
        for (var sum = 0; sum < possible.Length; sum++)
        {
            if (possible[sum])
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    var newSum = sum + arr[i];
                    if (newSum <= targetSum)
                    {
                        possible[newSum] = true;
                    }
                }
            }
        }

        return possible;
    }

    private static void PrintSubset(int[] arr, int targetSum, bool[] possible)
    {
        Console.Write(targetSum + " = ");
        var nums = new List<int>();
        while (targetSum > 0)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var newSum = targetSum - arr[i];
                if (newSum >= 0 && possible[newSum])
                {
                    targetSum = newSum;
                    nums.Add(arr[i]);
                }
            }
        }

        Console.WriteLine(string.Join(" + ", nums));
    }
}
