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

class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        int yesOrNo;
        int beingConsidered = 1;
        int totalX = 0;

        while (beingConsidered <= 100)
        {
            yesOrNo = 1;
            foreach (int item in a)
            {
                if (beingConsidered % item != 0)
                {
                    yesOrNo = 0;
                }
            }
            if (yesOrNo == 0)
            {
                beingConsidered++;
                continue;
            }

            foreach (int item in b)
            {
                if (item % beingConsidered != 0)
                {
                    yesOrNo = 0;
                }
            }

            if (yesOrNo == 0)
            {
                beingConsidered++;
                continue;
            }

            beingConsidered++;
            totalX++;
        }

        return totalX;
    }

}

class Solution
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
