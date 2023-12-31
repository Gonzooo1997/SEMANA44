﻿namespace mju23h_dtp_d1_ovn1_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] svenska = new string[10];
            string[] latin = new string[10];
            int nästa_insättning = 0;
            svenska[nästa_insättning] = "år"; latin[nästa_insättning] = "annum";
            nästa_insättning++;
            svenska[nästa_insättning] = "träd"; latin[nästa_insättning] = "arbor";
            nästa_insättning++;

            Console.WriteLine("Hej och välkommen till latinsk ordlista!");
            Console.WriteLine("Skriv 'hjälp' för att få hjälp!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            bool ready = false;
            while (!ready)
            {
                Console.Write("> ");
                string kommando = Console.ReadLine();
                if (kommando == "sluta")
                {
                    Console.WriteLine("Hej då!");
                    ready = true;
                }
                else if (kommando == "hjälp")
                {
                    hjälp();
                }

                else if (kommando == "visa")
                {
                    for (int i = 0; i < nästa_insättning; i++)
                    {
                        Console.WriteLine($"{i}: {svenska[i]} - {latin[i]}");
                        // TODO: snyggare formatering!!
                    }
                }
                else if (kommando == "ny")
                {
                    Console.Write("Ange svenskt ord: ");
                    string svenskt_ord = Console.ReadLine();
                    Console.Write("Ange latinsk översättning: ");
                    string latin_ord = Console.ReadLine();
                    svenska[nästa_insättning] = svenskt_ord; latin[nästa_insättning] = latin_ord;
                    nästa_insättning++;
                }
                else if (kommando == "latin")
                {
                    Console.Write("Ange svenskt ord: ");
                    string svenskt_ord = Console.ReadLine();
                    int kolla_här;
                    for (kolla_här = 0; kolla_här < nästa_insättning; kolla_här++)
                    {
                        if (svenska[kolla_här] == svenskt_ord)
                        {
                            Console.WriteLine($"Latinsk översättning: {latin[kolla_här]}");
                        }
                    }
                    // TODO: kolla om det inte fanns, i så fall skriv FANNS INTE!
                }
                else if (kommando == "svenska")
                {
                    Console.Write("Ange latinskt ord: ");
                    string latinskt_ord = Console.ReadLine();
                    int kolla_här;
                    for (kolla_här = 0; kolla_här < nästa_insättning; kolla_här++)
                    {
                        if (latin[kolla_här] == latinskt_ord)
                        {
                            Console.WriteLine($"Svensk översättning: {svenska[kolla_här]}");
                        }
                    }
                    // TODO: kolla om det inte fanns, i så fall skriv FANNS INTE!
                }
                else if (kommando == "ta bort")
                {
                    Console.Write("Ange index där du vill ta bort: ");
                    int ta_bort = int.Parse(Console.ReadLine());
                    // TODO felhantering om det inte är ett heltal inom in tabellens index
                    Console.WriteLine($"Tar bort element {ta_bort}: {svenska[ta_bort]} - {latin[ta_bort]}");
                    for (int i = ta_bort; i < nästa_insättning; i++) // TODO: det kanske ska va i < nästa_insättning - 1
                    {
                        svenska[i] = svenska[i + 1];
                        latin[i] = latin[i + 1];
                    }
                    nästa_insättning--;
                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {kommando}");
                }
            }

        }
        //make an input metod
        //make hjälp metod
        static void hjälp()
        {
                Console.WriteLine("hjälp     visa en lista på alla kommandon och en förklaring");
                Console.WriteLine("latin     slå upp ett svenskt ord och få den latinska översättningen");
                Console.WriteLine("ny        programmet frågar efter latin sedan svenska, uppslaget läggs in i ordlistan");
                Console.WriteLine("sluta     programmet avslutas");
                Console.WriteLine("svenska   slå upp ett latinskt ord och få den svenska översättningen");
                Console.WriteLine("ta bort   vi tar bort ett uppslag ur ordlistan");
                Console.WriteLine("visa      alla uppslag i ordlistan visas");

                return;
        }

    }
}