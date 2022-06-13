
using System;
namespace BitManipulationLonelyInteger;

public class Program
{
    // Complete the findLonely function below.
    static int findLonely(List<int> arr)
    {

        var result = 0;
        foreach (var item in arr)
        {
            result = result ^ item;
        }

        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int res = findLonely(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}