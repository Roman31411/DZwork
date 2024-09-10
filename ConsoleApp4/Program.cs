using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Rnd = rnd.Next(1,30);
            Console.WriteLine(Rnd);
            Console.ReadLine();
        }
    }
}
