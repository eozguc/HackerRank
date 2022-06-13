
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace DiagonalDifference;


public class Program
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

public class DayOfTheProgrammer
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

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


    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        string s = year.ToString();
        if (year == 1918)
        {
            return "26.09." + s;
            
        }
        else if (year<=1917)
        {
            if (year % 4 == 0)
            {
                return "12.09." + s;
                
            }
            else
            {
                return "13.09." + s;
            }
                
        }
        else
        {
            if (year % 400 == 0 || (year % 4 == 0) && year % 100 != 0)
            {
                return "12.09." + s;
            }
            else
            {
                return "13.09." + s;
            }
        }
        
       
    }
    

}

