namespace DivisibleSumPairs;

public class DivisibleSumPairs
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int count = 0;
        //for(int i=0; i<ar.length; i++){
        // for(int j=i+1; j<ar.length; j++){
        //    if(((ar[i]+ar[j])%k)==0){
        //      if(i < j)
        //     count++;
        //  }
        //  }
        //  }
        // return count;


        // for (int i = 0 ;i<n;i++) {
        //     for (int j=i;j<n;j++) {
        //        if (ar[i]+ar[j] % k == 0)
        //       count ++;
        //  }
        // }
        //     return count;


        //  int count = 0;
        //  for (int i = 0 ;i<ar.length[n];i++) 
        //  {
        //      for (int j=i+1;j<ar.length[n];j++) 
        //      {
        //        if (ar[i]+ar[j] % k == 0)
        //           count ++;
        //     }
        //  }
        //  return count;


        for (int i = 0; i < ar.Count; i++)
        {
            for (int j = 0; j < ar.Count; j++)
            {
                if (i < j)
                {
                    //Console.Write("array instance: " + i + ", array instance: " + j + " = ");
                    //Console.WriteLine(ar[i] + ar[j]);
                    int result = ar[i] + ar[j];
                    if (result % k == 0)
                    {
                        count++;
                        //Console.WriteLine("\n\nTHIS INSTANCE IS DIVISIBLE BY " + k + "\n\n");
                    }
                }

            }
        }


        return count;

    }
}

