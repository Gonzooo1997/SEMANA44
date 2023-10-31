using System.Runtime.CompilerServices;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Semana44
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Press Enter: ");

            while (true)
              {
                string command = Console.ReadLine();

                Console.WriteLine("Welcome to the Menu! \n Type 'Help' if you want to know the Menu");
                if(command.ToLower() == "Help".ToLower())
                {
                    Helpm();

                }
                else if(command.ToLower() == "Load".ToLower())
                {
                    string path = @"C:\Users\gonza\OneDrive\Escritorio\Test2\semana44\semana44\bin\Debug\net7.0\semana.txt";
                    using (FileStream fs = File.OpenRead(path));
                    string str = File.ReadAllText(path);
                    string[] text = File.ReadAllLines(path);

                    foreach (string s in text)
                    {

                    }

                }
                else if (command.ToLower() == "Print".ToLower())
                {
                }
              }



        }

        public class Person
        {
            public string name;
            public string password;

            public Person(string name, string password)
            {
                this.name = name;
                this.password = password;


            }

        }
        static void Helpm()
        {
            Console.WriteLine("Load");
            Console.WriteLine("Write");
            Console.WriteLine("Read");
            Console.WriteLine("Save");
            Console.WriteLine("Delete");
            Console.WriteLine("Exit");
        }


    }
}