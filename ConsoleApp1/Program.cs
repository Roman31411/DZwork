using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
int sum = 1;
int count = 0;
Console.WriteLine("Введиет кол-во эл");
int elementmasiv = int.Parse(Console.ReadLine());

int[] Array = new int [elementmasiv];
Console.WriteLine ("заполните массив:");
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("Элемент " + i+":\t");
    Array[i] = int.Parse(Console.ReadLine());
}
Console.Write ("Вывод массива:");
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("\t"+Array[i]);
    j = 2;
    sum = 1;

    for (j = 2; j < Array[i]/2+1; j++) 
    {
        if (Array[i]%j==0 && Array[i]!=j)
        {
            sum = sum+j;

        }
        if (sum == Array[i])
        {
            count++;
        }
    }
}
Console.WriteLine("\nкол-во совершеных чисел:\t" + count);

Console.ReadLine();
        }
    }
}


