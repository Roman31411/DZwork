using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void SummelementcolsPoboch()
        {
            Console.WriteLine("\n 16 ");
            int[,] array = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-8,8);
                }
            }
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }


            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i + j == array.GetLength(0) - 1)
                    {
                        summ += array[i, j];
                    }
                    
                }
               
            }
            Console.WriteLine("\nSumm element pobocj diagonal: " + summ);

        }
        static void Summelementcols()
        {
            Console.WriteLine("\n 15 ");
            int[,] array = new int[2, 2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

            
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int summ = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summ += array[i, j];
                }
                Console.WriteLine("\n" +i+" cols, Summ element: " + summ);
            }
            
        }
        static void CountMAXELMatrix()
        {
            Console.WriteLine("\n 14 ");
            int[,] array = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-67, 23);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

            int index = 0;
            int index2 = 0;
            int maxel = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {

                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[i, j] > maxel)
                    {
                        maxel = array[i, j];
                        index = i; index2 = j;
                    }
                }

            }
            Console.WriteLine("\nNomer max el " +"["+index+","+ index2+"]");
        }
        static void FormingMatrix01()
        {
            Console.WriteLine("\n 13 ");
            Console.WriteLine("\nMatrix tipa: ");
            int[,] array = new int[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;
                    if (i+j==4-1)
                    {
                        array[i, j] = 1;
                    }
                }

            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

        }
        static void FormingMatrix1234()
        {
            Console.WriteLine("\n 12 ");
            Console.WriteLine("\nMatrix tipa: ");
            int[,] array = new int[4, 4];
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int count = 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = count;
                    count++;
                }
                
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

        }
        static void CountEvenCowsMatrixVvodkl()
        {
            Console.WriteLine("\n 11 ");
            int[,] array = new int[2, 2];
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

            int count = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[i, j] % 2 == 0 && array[i,j]<0)
                    {
                        count++;
                    }
                }
               
            }
            Console.WriteLine("\nEven negativ element: " + count);
        }
        static void CountEvenCowsMatrix()
        {
            Console.WriteLine("\n 10 ");
            int[,] array = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-98, 54);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }

            
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i,j]%2==0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("\ncows "+j+ " Count evem element: "+count);
            }
        }
        static void razdelenie()
        {
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------");
        }
        static void CountOddNubers(int[,] array)
        {
            Console.WriteLine("\n 9 ");
            int maxcount = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
               
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > maxcount && array[i,j]%2!=0)
                    {
                        maxcount=array[i,j];
                    }
                }
               
            }
            Console.WriteLine("\nMax odd num: "+maxcount);
        }
        static void FormingMatrix()
        {
            Console.WriteLine("\n 8 ");
            Console.WriteLine("\nMatrix tipa: ");
            int[,] array = new int[4, 3];
            int count = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = count;
                }
                count++;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("\t\t" + array[i, j]);
                }
            }
          
        }
        static void Cows(int[,] array)
        {
            Console.WriteLine("\n 7 ");

            int temp = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int k = i + 1; k < array.GetLength(0); k++)
                    {
                        if (array[i, j] > array[k, j])
                        {
                            temp = array[i, j];
                            array[i, j] = array[k, j];
                            array[k, j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("\nSortmassiv: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\t" + array[i, j]);
                }
            }
        }      
        static int MaxcountEl(int[,] array)
        {
            int Maxcount = 0;
            int index = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] < 0)
                    {
                        count++;
                    }
                }
                if (count > Maxcount)
                {
                    Maxcount = count;
                    index = j;
                }
            }
            if (Maxcount == 0) return -1;
            return index;
        }

        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   
                    Console.Write("\t\t" + array[i, j]);
                }
            }

            razdelenie();

            Console.WriteLine("\n6. \nCols number: " + MaxcountEl(array));

            razdelenie();

            Cows(array);

            razdelenie();

            FormingMatrix();

            razdelenie();

            CountOddNubers(array);

            razdelenie();

            CountEvenCowsMatrix();

            razdelenie();

            CountEvenCowsMatrixVvodkl();

            razdelenie();

            FormingMatrix1234();

            razdelenie();

            FormingMatrix01();

            razdelenie();

            CountMAXELMatrix();

            razdelenie();

            Summelementcols();

            razdelenie();

            SummelementcolsPoboch();

            razdelenie();







            Console.ReadLine();

        }
    }
}
