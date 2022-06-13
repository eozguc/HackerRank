
using System;

namespace BalancedBrackets;


class Result
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        var myStack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                myStack.Push(s[i]);
            }
            else
            {
                if (myStack.Count == 0)
                {
                    return "NO";
                }
                else
                {
                    var topStack = myStack.Pop();

                    if (s[i] == ')' && topStack != '(')
                    {
                        return "NO";
                    }
                    else if (s[i] == '}' && topStack != '{')
                    {
                        return "NO";
                    }
                    else if (s[i] == ']' && topStack != '[')
                    {
                        return "NO";
                    }
                }
            }
           
        }

        if (myStack.Count == 0 )
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

}


public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}