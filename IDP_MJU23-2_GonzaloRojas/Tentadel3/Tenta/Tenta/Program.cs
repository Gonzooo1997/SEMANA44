using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tenta
{
    internal class Program
    {
        // uppgift3

        static int summanTal(int start, int slut)
        {
            int summa = 0;

            if (start % 2 != 0)
            {
                start++;
            }

            for (int i = start; i <= slut; i += 2)
            {
                summa += i;
            }

            return summa;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ange två tal för att beräkna summan av jämna tal mellan dem.");

            Console.Write("Ange ditt första tal: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Ange ditt andra tal: ");
            int number2 = int.Parse(Console.ReadLine());

            int summa = summanTal(number1, number2);

            Console.WriteLine($"Summan av jämna tal mellan {number1} och {number2} är: {summa}");

            Console.ReadLine();

        }
    }
}