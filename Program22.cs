﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
       public static void Main(string[] args)
{
    int count1 = 0;
    for (int i = 59049; i <= 531440; i++)
    {
        string number = Convert(i);
        if (number.Length == 6)
        {
            int s = int.Parse(number.Substring(0, 1));
            int w = int.Parse(number.Substring(number.Length - 1, 1));
            int count = CountDigit(number, '1');

            if (s % 2 == 0 && w != 2 && w != 3 && count >= 2)
            {
                count1++;
            }
        }
    }
    Console.WriteLine(count1);
    Console.ReadLine();
}

static string Convert(int decimalNumber)
{
    string s9Number = "";
   

    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 9;
      
        decimalNumber /= 9;
        
       s9Number = remainder.ToString() + s9Number;
    }

    return s9Number;
}

static int CountDigit(string number, char digit)
{
    return number.Count(c => c == digit);
}


    }
}
