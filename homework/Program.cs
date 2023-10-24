using System;
using System.Diagnostics;
using homework;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int target = 12;

        CalculateAndPrintExecutionTime(new DictionaryCollection(), arr, target);
        CalculateAndPrintExecutionTime(new HashСollections(), arr, target);
        CalculateAndPrintExecutionTime(new СycleAlgorithm(), arr, target);
    }

    private static void CalculateAndPrintExecutionTime(Calculation cycles, int[] arr, int target)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        List<List<int>> result = cycles.FindThreeNumbers(arr, target);
        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine("Execution time: " + elapsedTime.TotalMilliseconds + " milliseconds");

        foreach (List<int> triplet in result)
        {
            Console.WriteLine(string.Join(", ", triplet));
        }
    }
}