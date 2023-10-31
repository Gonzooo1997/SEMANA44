using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tenta
{
    internal class Program
    {


        static void Main(string[] args)
        {
             double km_s = 299792.458;
             double avstand = 149598023.0;
             double en_minut = 60.0;

             double km_min = km_s * en_minut;
             double result = avstand / km_min;

             Console.WriteLine($"Det kommer ta {result} min för att vi ska märka det.");

             // resultatet är: 8,31675486423789 min


        }
    }
}