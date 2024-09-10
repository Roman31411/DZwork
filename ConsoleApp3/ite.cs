using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 }; // Массив с 5 элементами
            int[] array2 = { 10, 20, 30 };     // Массив с 3 элементами

            // Перебираем оба массива
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Итерация " + i);
                for (int j = 0; j < array2.Length; j++)
                {
                    // Пример обработки элементов: выводим их сумму
                    Console.WriteLine("\tИтерация " + j);

                }
            }
            Console.ReadLine();
            }
    }
}
