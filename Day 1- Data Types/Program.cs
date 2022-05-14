using System;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        Console.WriteLine(i + Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine(string.Format("{0:0.0}", d + double.Parse(Console.ReadLine())));
        Console.WriteLine(s + Console.ReadLine());



    }
}