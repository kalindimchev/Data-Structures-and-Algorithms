using System;
using System.Collections.Generic;
using System.Linq;

public static class SubsetSumsBetter
{
    public static void Main()
    {
        var numbers = new[] { 2, 5, 10 };
        var targetSum = 50;

        var possibleSums = CalcPossibleSums(numbers, targetSum);

        // Print subset
        if (possibleSums[targetSum])
        {
            PrintSubset(numbers, targetSum, possibleSums);
        }
        else
        {
            Console.WriteLine("Not possible");
        }

        Console.WriteLine(
            "Possible sums: {0}",
            string.Join(", ", possibleSums.Select((v, i) => new { val = v, ind = i }).Where(x => x.val).Select(x => x.ind)));
    }

    private static bool[] CalcPossibleSums(int[] numbers, int targetSum)
    {
        var possible = new bool[targetSum + 1];
        possible[0] = true;
        for (var sum = 0; sum < possible.Length; sum++)
        {
            if (possible[sum])
            {
                foreach (var number in numbers)
                {
                    var newSum = sum + number;
                    if (newSum <= targetSum)
                    {
                        possible[newSum] = true;
                    }
                }
            }
        }

        return possible;
    }

    private static void PrintSubset(int[] numbers, int targetSum, bool[] possible)
    {
        Console.Write(targetSum + " = ");
        var nums = new List<int>();
        while (targetSum > 0)
        {
            foreach (var number in numbers)
            {
                var newSum = targetSum - number;
                if (newSum >= 0 && possible[newSum])
                {
                    targetSum = newSum;
                    nums.Add(number);
                }
            }
        }

        Console.WriteLine(string.Join(" + ", nums));
    }
}
