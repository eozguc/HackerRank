using System;

namespace ArraysLeftRotation;


class Result
{

    /*
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */

    public static List<int> rotLeft(List<int> a, int d)
    {
        if (a != null && a.Count > 1)
        {      
            List<int> b = new List<int>();

            // d = 3  
            // 1,2,3,4,5
            // ^-----^ offset=0+d=0+3=3
            //   ^-----^ offset=1+d=1+3=4
            //     ^---^ offset=2+d=2+3=abs(5-a.Count)=5-5=0
            //           offset=3+d=3+3=abs(6-a.Count)=6-5=1
            for (int i=0; i<a.Count; i++)
            {
                int offset = i+d;
                if (offset >= a.Count)
                {
                    // Wrap.
                    offset = Math.Abs(offset - a.Count);
                }

                b.Add(a[offset]);
            }

            return b;
        }
        else
        {
            return a;
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = Result.rotLeft(a, d);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
    
}