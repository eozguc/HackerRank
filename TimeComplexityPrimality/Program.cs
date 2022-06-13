
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

namespace TimeComplexityPrimality;


class Result
{

    /*
     * Complete the 'primality' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string primality(int n)
    {
      
            return IsPrime(n)?"Prime":"Not prime";
        
        
        if (n < 2) return "Not prime";
        else if (n == 2) return "Prime";
        else if (n % 2 == 0) return "Not prime";

        var sqrt = (int)Math.Sqrt(n);

        for (var i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
                return "Not prime";

        }

        return "Prime";
    }

    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        else if (n == 2) return true;
        else if (n % 2 == 0) return false;
        
        var sqrt = (int)Math.Sqrt(n);

        for (var i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
                return false;

        }

        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        for (int pItr = 0; pItr < p; pItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.primality(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}