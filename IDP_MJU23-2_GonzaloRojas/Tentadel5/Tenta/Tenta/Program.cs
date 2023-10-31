namespace Tenta
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ange första tal: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Ange andra tal: ");
            int n = int.Parse(Console.ReadLine());

            double resultat = summa(m, n);

            Console.WriteLine($"Summan från {m} till {n} är: {resultat}");

        }

        static double summa(int m, int n)
        {
            double summan = 0;

            for (int i = m; i <= n; i++)
            {
                summan += 1.0 / i;
            }

            return summan;
        }
    }
}