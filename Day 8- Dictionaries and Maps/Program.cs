using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().ToString().Split(' ');
            phoneBook.Add(values[0], values[1]);
        }

        string friendName = string.Empty;

        while ((friendName = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(friendName))
            {
                Console.WriteLine(friendName + "=" + phoneBook[friendName]);
            }
            else
            {

                Console.WriteLine("Not found");
            }
        }
    }
}
