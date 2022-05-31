namespace BetweenTwoSets;

public class BetweenTwoSets
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        var totalXs = 0;
        var maximumA = a.Max(); //Time-complexity O(n)
        var minimumB = b.Min(); //Time-complexity O(m)
        var counter = 1;
        var multipleOfMaxA = maximumA;

        while (multipleOfMaxA <= minimumB)
        {
            var factorOfAll = true;

            foreach (var item in a) //Time complexity O(n)
            {
                if (multipleOfMaxA % item != 0)
                {
                    factorOfAll = false;
                    break;
                }
            }

            if (factorOfAll)
            {
                foreach (var item in b) //Time complexity O(m)
                {
                    if (item % multipleOfMaxA != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }
            }

            if (factorOfAll)
                totalXs++;

            counter++;
            multipleOfMaxA =
                maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
        }

        return totalXs;
    }

}