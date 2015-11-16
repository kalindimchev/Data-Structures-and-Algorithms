using System;
using System.Collections.Generic;

public static class SubSetSums
{
    private const int SumToAchieve = 26;

    private static readonly int[] Number = { 5, 5, 15, 20, 1 };

    private static readonly bool[,] Sums = new bool[Number.Length, SumToAchieve + 1];

    private static readonly bool[,] IsCalculated = new bool[Number.Length, SumToAchieve + 1];

    public static void Main()
    {
        var isSumPossible = CalcF(Number.Length - 1, SumToAchieve);
        if (isSumPossible)
        {
            PrintSubset(Number.Length - 1, SumToAchieve);
        }
        else
        {
            Console.WriteLine("Not possible!");
        }
    }

    private static bool CalcF(int i, int currentSum)
    {
        if (currentSum < 0 || i < 0)
        {
            return false;
        }

        if (!IsCalculated[i, currentSum])
        {
            Sums[i, currentSum] = (Number[i] == currentSum) || CalcF(i - 1, currentSum) || CalcF(i - 1, currentSum - Number[i]);
            IsCalculated[i, currentSum] = true;
        }

        return Sums[i, currentSum];
    }

    private static void PrintSubset(int i, int sum)
    {
        Console.Write(sum + " = ");
        var nums = new List<int>();
        while (true)
        {
            if (Number[i] == sum)
            {
                nums.Add(Number[i]);
                break;
            }
            else if (CalcF(i - 1, sum - Number[i]))
            {
                // Take arr[k]
                nums.Add(Number[i]);
                sum = sum - Number[i];
                i = i - 1;
            }
            else if (CalcF(i - 1, sum))
            {
                // Skip arr[k]
                i = i - 1;
            }
        }

        Console.WriteLine(string.Join(" + ", nums));
    }
}
