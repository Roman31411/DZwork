using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            Random rnd = new Random();
            
            //инициализация массивов
            float[] array = new float[12];
            float[] array2 = new float[12];
            //Заполние массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next();
            }
            //Вывод массива
            Console.WriteLine("Вывод array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  "+array[i]);
            }
            Console.WriteLine("\nВывод array2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("  "+array2[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {

                        array[i] = 0;
                    }
                }
            }
            //Вывод массива после проверки
            Console.WriteLine("\nВывод array(изм):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  " + array[i]);
            }
            Console.WriteLine("\nВывод array2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("  " + array2[i]);
            }


            Console.ReadLine();
        }
            
    }
}
