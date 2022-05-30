
using System;
using static System.Console;
namespace DiagonalDifference;

public class DiagonalDifference
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
       // var sumPrimaryDiagonal = 0;
      //  var sumSecondaryDiagonal = 0;
      //  var n = int.Parse(ReadLine());
       // for (int i = 0, j = n - 1; i < n; i++, j--)
     //   {
     //       var a_temp = ReadLine().Split(' ');
      //      var newRow = Array.ConvertAll(a_temp, int.Parse);
      //      sumPrimaryDiagonal += newRow[i];
      //      sumSecondaryDiagonal += newRow[j];
      //  }
        
      //  WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
      
      var right = 0;
      var left = 0;
      var result = 0;
      var rowCount = arr.Count - 1;
      var listCount = arr[0].Count;

      for (var j = 0; j < listCount; j++)
      {
          right += arr[j][j];
          left += arr[rowCount - j][j];
      }
      result = Math.Abs(right - left);

      return result;
    }

}
