﻿using System.CodeDom.Compiler;
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
    public static string dayOfProgrammer(int year)
    {
        switch (year)
        {
            case <1918:
                if (year % 4 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }

            case 1918:
                return "26.09." + year;

            case > 1918:
                if (year % 400 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    if (year % 4 == 0 && year % 100 != 0)
                    {
                        return "12.09." + year;
                    }
                    else
                    {
                        return "13.09." + year;
                    }
                }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}