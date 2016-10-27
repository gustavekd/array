using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning1
            /* string[] namn = new string[10];

            for (int i = 0; i < 10 ; i++)
            {
                   Console.Write("Mata in ett namn:");
                    namn[i] = Console.ReadLine();
                }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(namn[i]);
            } */
            //övning2 
            /*
            int[] tal = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("mata in ett tal:" + " ");
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(tal[i]);
            } */

            //övning3

            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };

            for (int a = 0; a < numbArray.Length; a++)
            {
                for (int b = a; b < numbArray.Length; b++)
                {
                    if (numbArray[a] < numbArray[b])
                    numbArray[b] = numbArray[a]
                ; }
                    }
            for (int a = 0; a < numbArray.Length; a++)
            {
                Console.WriteLine(numbArray[a]);
            }

        }
    }
    }

