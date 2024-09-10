using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиет кол-во эл");
            int elementmasiv = int.Parse(Console.ReadLine());

            int[,] Array = new int[elementmasiv, elementmasiv];
            Console.WriteLine("заполните массив:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Элемент " + i + ":\t");
                Array[i,i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Вывод массива:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("\t" + Array[i, i]);
            }
        }
    }
}
