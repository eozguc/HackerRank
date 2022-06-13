
using System;

namespace AlternatingCharacters;

public class Program
{
    /*
    * Complete the 'alternatingCharacters' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts STRING s as parameter.
    */

    public static int alternatingCharacters(string s)
    {
        var deleteCount=0;
        for(var i=0;i<s.Length-1;i++)
        {
            if(s[i]==s[i+1])
            {
                deleteCount++;
            }
        }
        return deleteCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s); 

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}