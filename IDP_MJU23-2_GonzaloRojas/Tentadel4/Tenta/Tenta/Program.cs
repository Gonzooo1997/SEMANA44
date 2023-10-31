using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tenta
{
    internal class Program
    {



        static void flytt(int[] array)
        {

            int temp = array[0];


            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = temp;
        }

        static void tal(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Ursprunglig array:");
            tal(array);


            flytt(array);

            Console.WriteLine("Array efter förflyttning:");
            tal(array);

            Console.ReadLine();
        }
    }
}