using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int strCount = Convert.ToInt32(Console.ReadLine().Trim());
        string[] givenStrings = new string[strCount];
        List<Char> evenIndChar = new List<Char>();
        List<Char> oddIndChar = new List<Char>();

        for (int i = 0; i < strCount; i++)
        {
            givenStrings[i] = Console.ReadLine().Trim();
        }
        foreach (string str in givenStrings)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenIndChar.Add(str[j]);
                }
                else if (j % 2 == 1)
                {
                    oddIndChar.Add(str[j]);
                }
            }
            Console.Write(String.Join("", evenIndChar));
            Console.Write(" ");
            Console.Write(String.Join("", oddIndChar));
            Console.WriteLine();
            evenIndChar.Clear();
            oddIndChar.Clear();
        }


    }
}