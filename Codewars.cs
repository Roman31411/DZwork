using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace Codewarstest
{
    public class BitCounting
    {
        public static long digPow(int n, int p)
        {
          

            double Valuequadruple = 0;
            int nn = n;
            char[] mass = n.ToString().ToArray();
        
            for (int i = 0; i < mass.Length; i++)
            {
                double d = double.Parse(mass[i].ToString());
                Valuequadruple += Math.Pow(d, p++);
            }
            if(Valuequadruple==n)
                return 1;
            for (int i = 0;Valuequadruple >= n; i++)
            {
              
                n = nn;
                n = n * i;
                if (n == Valuequadruple)
                return i;
               
            }

            return -1;
        }
        public static void AlphabetPosition()
        {
            string text = Console.ReadLine();
            //char[] chars = "0abcdefghijklmnopqrstuvwxyz".ToCharArray();

            //text= text.ToLower();

            //text = Regex.Replace(text, @"[^a-zA-Z]", "");

            //int textLenght=text.Length;

            //for (int i = 1; i < chars.Length; i++)
            //{
            //text = text.Replace(chars[i].ToString(), i.ToString()+" ");
            //}
            //text = text.Trim();

            //return text;

            string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));

            Console.WriteLine(text);
            Console.ReadKey();
        }
        private static void DoTest(int n)
        {
            n = int.Parse(Console.ReadLine());
            
            //string rem = "";
            //while (n>0)
            //{
            //   rem+=Convert.ToString(n % 2);
            //    n /= 2;
            //}
            //string Crem = new string(rem.Reverse().ToArray());
            //return Crem.Count(c => c == '1');

            n= Convert.ToString(n, 2).Count(x => x == '1');

            Console.WriteLine(n);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           int p = int.Parse(Console.ReadLine());
            Console.WriteLine(digPow(n, p)); 
            Console.ReadKey();  
        }
    }
}
