using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int firstListPoint = 0;
        int secondListPoint = 0;

        for (int i = 0; i < b.Count; i++)
        {
            if (a[i] > b[i])
            {
                firstListPoint++;
            }
            else if (a[i] < b[i])
            {
                secondListPoint++;
            }
        }

        List<int> points = new List<int> { firstListPoint, secondListPoint };


        return points;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
