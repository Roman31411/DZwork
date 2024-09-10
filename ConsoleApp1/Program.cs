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
            int[] Array = new int [5];
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
            }
            Console.WriteLine("\n");

            
            for (int i = 0; i < Array.Length; i++)
            {
                double j = Math.Pow(Array[i], 2);
                Console.WriteLine("Квадрат Элемента "+ i + ":\t" + j +"\n");
                double l = Math.Sqrt(Array[i]);
                Console.WriteLine("Корень эллемента " + i + ":\t" + l +"\n");

            }


            Console.ReadLine();
        }
    }
}


