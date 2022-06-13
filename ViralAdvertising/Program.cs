
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
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

namespace ViralAdvertising;

class Result
{

    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {
        var people = 2;
        var likeCount = 2;

        for (int i = 2; i <= n; i++)
        {
            people = (people * 3) / 2;
            likeCount += people;
        }

        return likeCount;



        int likedCount = 0;
        int sumLikedCount = 0;
        int sharedCount = 5;
        
        for (int i = 0; i < n; i++)
        {
            likedCount = (sharedCount / 2);
            sharedCount = likedCount * 3;
            sumLikedCount += likedCount;
        }

        return sumLikedCount;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}