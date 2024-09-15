using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int count = 0;

            Console.WriteLine("Введиет кол-во эл");
            int elementmasiv = int.Parse(Console.ReadLine());

            string[] Array = new string[elementmasiv];

            Console.WriteLine("заполните массив:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Элемент " + i + ":\t");
                Array[i] = Console.ReadLine();
            }
            Console.Write("Вывод массива:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("\t" + Array[i]);
            }


            for (int i = 0; i < Array.Length; i++)
            {
                string x = new string(Array[i].Reverse().ToArray());

                if (x == Array[i])
                {
                    count++;

                }

            }
            Console.WriteLine("\nкол-во чисел паллидромов:\t" + count);

            Console.ReadLine();
        }
          
            
        
    }
}
