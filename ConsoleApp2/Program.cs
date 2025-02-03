using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 123456123.50009278;
            long wins = (long)(d * 100.0);
            string strWins = $"{wins}";
            string decimals = strWins.Substring(strWins.Length - 2, 2);
            string intPart = strWins.Substring(0, strWins.Length - 2);
            int intVal = int.Parse(intPart);
            string s = $"{intVal:N0}.{decimals}";
            Console.WriteLine(s);

            //int numarCurse = 790;
            //double profitDorit = 10.0; // 10% profit dorit
            //Random random = new Random();

            //// Inițializare număr de victorii pentru fiecare câine
            //int[] numarVictorii = { 141, 125, 130, 128, 129, 137 };

            //for (int cursa = 1; cursa <= 100; cursa++)
            //{
            //    // Simulează câștigătorul curent pentru cursa
            //    int castigatorCursa = random.Next(1, 7); // Generare aleatoare între 1 și 6
            //    numarVictorii[castigatorCursa - 1]--; // Actualizează numărul de victorii pentru câinele câștigător

            //    double[] probabilitati = new double[6];
            //    double[] cote = new double[6];
            //    double[] coteAjustate = new double[6];

            //    int curseRamase = numarCurse - cursa + 1;
            //    // Calculează probabilitățile
            //    for (int i = 0; i < 6; i++)
            //    {
            //        probabilitati[i] = (double)numarVictorii[i] / cursa;
            //    }

            //    // Calculează cotele inițiale
            //    for (int i = 0; i < 6; i++)
            //    {
            //        cote[i] = 1.0 / probabilitati[i];
            //    }

            //    // Ajustează cotele pentru a obține un profit dorit
            //    for (int i = 0; i < 6; i++)
            //    {
            //        coteAjustate[i] = cote[i] / (1 + profitDorit / 100);
            //    }

            //    // Normalizează cotele ajustate pentru a asigura un spațiu pentru profitul casei
            //    double sumaCotelorAjustate = 0;
            //    for (int i = 0; i < 6; i++)
            //    {
            //        sumaCotelorAjustate += coteAjustate[i];
            //    }

            //    // Afișează câinele câștigător și cotele ajustate pentru cursa curentă
            //    Console.WriteLine($"Cursa {cursa}: Cainele câștigător: {castigatorCursa}");
            //    Console.WriteLine($"Cotele ajustate pentru Cursa {cursa}:");
            //    for (int i = 0; i < 6; i++)
            //    {
            //        double cotaFinala = coteAjustate[i] / sumaCotelorAjustate;
            //        Console.WriteLine($"Cainele {i + 1}: {1.0/cotaFinala:F4}");
            //    }

            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
