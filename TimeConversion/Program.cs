
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

namespace TimeConversion;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
       
        
        
        
        //easiest way

        var dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);

        return $"{dt:HH:mm:ss}";
        //manual parsing
        // var tType = sTime.Substring(sTime.Length-2).ToUpper();
        // var timeValue = sTime.Substring(0, sTime.Length - 2);

        // var seperate = timeValue.Split(':');
        // var hour = Convert.ToInt32(seperate[0]);
        // var min = Convert.ToInt32(seperate[1]);
        // var sec = Convert.ToInt32(seperate[2]);
        // if (tType=="AM" && hour>=12)
        // {
        //     hour -= 12;

        // }
        // else if (tType == "PM" && hour < 12)
        // {
        // hour += 12;

        // }
        // var sHour = (hour < 10) ? 0 + hour.ToString() : hour.ToString();
        // var sMinute = (min < 10) ? 0 + min.ToString() : min.ToString();
        // var sSecond = (sec < 10) ? 0 + sec.ToString() : sec.ToString();

        // var result = $"{sHour}:{sMinute}:{sSecond}";

        // return result;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
    
}