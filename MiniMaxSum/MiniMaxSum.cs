using System;
using static System.Console;
using System.Linq;

namespace MiniMaxSum;

public class MiniMaxSum
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        long min = long.MaxValue;
        long max = long.MinValue;

        for (var i = 0; i < 5; i++)
        {
            sum += arr[i];
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }
        WriteLine($"{sum - max} {sum - min}");
    }

}

