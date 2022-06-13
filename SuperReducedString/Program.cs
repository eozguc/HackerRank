
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

namespace SuperReducedString;


class Result
{

    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0 && s[i] == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        if (stack.Count == 0)
        {
            return "Empty String";
        }
        else
        {
            var str = "";
            while (stack.Count > 0 )
            {
                str = stack.Pop() + str;
            }

            return str;
        }
        
        
        
        
        
        Stack<char> resStr = new Stack<char>();
        foreach (var item in s)
        {
            if (resStr.Count > 0)
            {
                if (item == resStr.Peek())
                {
                    resStr.Pop();
                }
                else
                {
                    resStr.Push(item);
                }
            }
            else resStr.Push(item);

        }
        string result = null;
        if (resStr.Count == 0)
        {
            result = "Empty String";
        }
        else
        {
            while(resStr.Count>0)
            {
                result = resStr.Pop() + result;
            }
        }
        return result;
    
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}