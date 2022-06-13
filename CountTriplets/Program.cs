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

namespace CountTriplets;



public class Program
{
    static long countTriplets(List<long> arr, long r)
    {

        long count = 0;
        var frequencies = new Dictionary<long,long>();
        var leftFrequencies = new Dictionary<long, long>();

        foreach (var curr in arr)
        {
            if (frequencies.ContainsKey(curr))
            {
                frequencies[curr]++;
            }
            else
            {
                frequencies.Add(curr,1);
            }
            
        }

        foreach (var curr in arr)
        {
            long leftCount = 0;
            long rightCount = 0;
            long leftCanddate = 0;
            long rightCandidate = curr * r;

            if (curr % r == 0)
            {
                leftCanddate = curr / r;
            }

            frequencies[curr]--;

            if (frequencies.ContainsKey(rightCandidate))
            {
                rightCount = frequencies[rightCandidate];
                
            }

            if (leftFrequencies.ContainsKey(leftCanddate))
            {
                leftCount = leftFrequencies[leftCanddate];
            }

            count += rightCount * leftCount;

            if (leftFrequencies.ContainsKey(curr))
            {
                leftFrequencies[curr]++;
            }
            else
            {
                leftFrequencies.Add(curr,1);
            }


        }

        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        textWriter.WriteLine(ans);

        textWriter.Flush();
        textWriter.Close();
    }
}