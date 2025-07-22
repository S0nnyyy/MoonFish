using System.Data;
using System.Net.Sockets;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Možnosti:\n0 - Kalkulačka \n1 - Personilizace\n2 - Obvod a Obsah\n3 - Den v tydnu\n4 - Pocet samohlasek ve slovu");
            Console.WriteLine("Zadej cislo volby");
            int volba = int.Parse(Console.ReadLine());

            switch (volba) 
            { 
            
                case 0:
                    Console.WriteLine("Zadej prvni cislo");
                    double cisloA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Zadej druhe cislo");
                    double cisloB = Convert.ToDouble(Console.ReadLine());

                    Scitani(cisloA, cisloB);
                    Odecitani(cisloA, cisloB);
                    Nasobeni(cisloA, cisloB);
                    Deleni(cisloA, cisloB);
                    break;
                case 1:
                    Console.WriteLine("Zadej cele tvoje jmeno");
                    String celeJmeno = Console.ReadLine();

                    Console.WriteLine("Zadej tvuj vek");
                    int vek = int.Parse(Console.ReadLine());

                    personilizace(celeJmeno, vek);
                    break;
                case 2:
                    Console.WriteLine("Zadej vysku");
                    double vyska = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Zadej sirku");
                    double sirka = Convert.ToDouble(Console.ReadLine());

                    obvod(vyska, sirka);
                    obsah(vyska, sirka);
                    break;
                case 3:
                    Console.WriteLine("Zadej cislo dne");
                    int cisloDne = int.Parse(Console.ReadLine());
                    nazevDneTydnu(cisloDne);
                    break;
                case 4:
                    Console.WriteLine("Zadej slovo");
                    string slovo = Console.ReadLine();
                    pocet(slovo);
                    break;
                default:
                    Console.WriteLine("Takova moznost neexistuje");
                    break;
            }
        }

        static void Scitani(double a, double b)
        {
            double vysledek = a + b;
            Console.WriteLine($"Výsledek scitani cisel {a} + {b} = {vysledek}");
        }

        static void Odecitani(double a, double b)
        {
            double vysledek = a - b;
            Console.WriteLine($"Výsledek odecitani cisel {a} - {b} = {vysledek}");
        }
        static void Nasobeni(double a, double b)
        {
            double vysledek = a * b;
            Console.WriteLine($"Výsledek nasobeni cisel {a} * {b} = {vysledek}");
        }
        static void Deleni(double a, double b)
        {
            if ( b == 0 ) {
                Console.WriteLine("Nelze dělit nulou");
            }
            else
            {
                double vysledek = a / b;
                Console.WriteLine($"Výsledek deleni cisel {a} / {b} = {vysledek}");
            }
        }

        static void personilizace(String celeJmeno, int vek)
        {
            String[] casti = celeJmeno.Split(" ");
            String jmeno = casti[0];
            String prijmeni = casti[1];

            Console.WriteLine($"Vítej uživateli {jmeno} {prijmeni}, tvuj věk byl nastaven na {vek} ");
        }
        static void obvod(double vyska, double sirka)
        {
            double obvod = 2 * (vyska + sirka);
            Console.WriteLine($"Obvod je {obvod}");
        }

        static void obsah(double vyska, double sirka)
        {
            double obsah = vyska * sirka;
            Console.WriteLine($"Obsah je {obsah}");
        }

        static void nazevDneTydnu(int cisloDne) 
        {
            switch(cisloDne) {
                case 1:
                    Console.WriteLine("Pondeli");
                    break;
                case 2:
                    Console.WriteLine("Utery");
                    break;
                case 3:
                    Console.WriteLine("Středa");
                    break;
                case 4:
                    Console.WriteLine("Čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Patek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Nedele");
                    break;
                default:
                    Console.WriteLine("Takova moznost neexistuje");
                    break;
            }
        }

        static void pocet(string slovo)
        {
            char[] pismena = { 'a', 'e', 'i', 'o', 'u' };
            int pocetSamohlasek = 0;
            string lower = slovo.ToLower();

            foreach (char c in lower) 
            {
                if (pismena.Contains(c))
                {
                    pocetSamohlasek++;
                }
            }
            Console.WriteLine(pocetSamohlasek);
        }

    }
}

