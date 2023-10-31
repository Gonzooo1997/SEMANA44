using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Uppgift2
{
    internal class Program
    {

        //uppgift 2

        public static void InvSqr()
        {
            Console.WriteLine("Skriv ditt tal: ");
            string X_string = Console.ReadLine();
            double X = double.Parse(X_string);


            double i = 1 / (X * X);
            Console.WriteLine(i);
            return;
        }


        static void Main(string[] args)
        {

            // uppgift 2

            InvSqr();

        }
    }
}