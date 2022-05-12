using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main()
        {

            //for(int i = 1; i <=5; i++)
            //{
            //    Console.Write("*");


            //}
            //for(int i = 1; i < 4; i++)

            //{
            //    Console.WriteLine("*");
            //}

            //for(int i = 1; i <=5; i++)
            //{
            //    for(var j = 1; j <=4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (var j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int i=1;
            //while (i<=4)
            //{
               

            //    i++;

            //    int j=1;
            //    while(j<i)
            //    {
            //        j++;
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            for(int i = 1; i <= 4; i++)
            {
               


                for(int j = 4; j >=i; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }







            Console.ReadKey();
        }
    }
}
