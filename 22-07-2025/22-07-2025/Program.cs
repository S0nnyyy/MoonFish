using System.Net.NetworkInformation;

namespace _22_07_2025
{
    class Person
    {
        public string jmeno { get; set; }
        public int vek { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Možnosti:\n0 - Faktorial \n1 - Fibonacciho posloupnost\n2 - Prvočíslo\n3 - Přetížení metody\n4 - Stopky\n5 - Post");
            Console.WriteLine("Zadej cislo volby");
            int volba = int.Parse(Console.ReadLine());

            switch (volba)
            {

                case 0:
                    Console.WriteLine("Zadejte číslo pro výpočet faktoriálu:");
                    int vstup = int.Parse(Console.ReadLine());
                    Console.WriteLine("Výsledek interativního faktorialu je "+ interativniFaktorial(vstup));
                    Console.WriteLine("Výsledek rekurzivního faktorialu je "+ rekurzivniFaktorial(vstup));
                    break;
                case 1:
                    Console.WriteLine("Zadejte počet prvků Fibonacciho posloupnosti:");
                    int n = int.Parse(Console.ReadLine());
                    fibonaccihoPosloutnost(n);
                    break;
                case 2:
                    Console.WriteLine("Zadejte číslo pro kontrolu, zda je prvočíslo:");
                    int cislo = int.Parse(Console.ReadLine());
                    prvoCislo(cislo);
                    break;
                case 3:
                    Console.WriteLine("Přetížení metody:");
                    var osoba = new Person();
                    osoba.jmeno = "Martin";
                    osoba.vek = 30;
                    printInfo(42);
                    printInfo("Ahoj světe");
                    printInfo(osoba);
                    break;
                case 4:
                    Stopky stopky = new Stopky();
                    while(true)
                    {
                        Console.WriteLine("Zadejte 'stop' pro zastavení nebo 'start' pro spuštění stopky:");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "stop")
                        {
                            stopky.Stop();
                            Console.WriteLine(stopky.ToString());
                            break;
                        }
                        else if (input.ToLower() == "start")
                        {
                            stopky.Start();
                            Console.WriteLine("Stopky spuštěny.");
                        }
                        else
                        {
                            Console.WriteLine("Neplatný příkaz, zkuste znovu.");
                        }
                    }
                    stopky.Start();
                    break;
                case 5:
                    Console.WriteLine("Zadejte název příspěvku:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Zadejte obsah příspěvku:");
                    string content = Console.ReadLine();
                    Console.WriteLine("Zadejte autora příspěvku:");
                    string author = Console.ReadLine();
                    Post post = new Post(title, content, author);
                    post.Output();
                    break;
                default:
                    Console.WriteLine("Takova moznost neexistuje");
                    break;
            }
        }

        public static long interativniFaktorial(int vstup) 
        {
            if (vstup < 0)
            {
                throw new ArgumentException("Faktoriál není definován pro záporná čísla.");
            }
            long vysledek = 1;

            for (int i = 1; i <= vstup; i++)
            {
                vysledek *= i;
            }
            
            return vysledek;
        }

        public static long rekurzivniFaktorial(int vstup)
        {
            if (vstup < 0)
            {
                throw new ArgumentException("Faktoriál není definován pro záporná čísla.");
            }
            if (vstup == 0 || vstup == 1)
            {
                return 1;
            }
            return vstup * rekurzivniFaktorial(vstup - 1);
        }

        static void fibonaccihoPosloutnost(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Fibonacciho posloupnost není definována pro záporná čísla.");
            }
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacciho posloupnost:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        static void prvoCislo(int n)
        {
            if (n  <=  1)
            {
                throw new ArgumentException("Prvo čísla začínají od 2");
            }
            bool jePrvocislo = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    jePrvocislo = false;
                    break;
                }
            }
            if (jePrvocislo)
            {
                Console.WriteLine($"{n} je prvo číslo.");
            }
            else
            {
                Console.WriteLine($"{n} není prvo číslo.");
            }
        }

        static void printInfo(Person person)
        {
            Console.WriteLine($"Jméno: {person.jmeno}, Věk: {person.vek}");
        }

        static void printInfo(int number)
        {
            Console.WriteLine($"Číslo: {number}");
        }

        static void printInfo(string text)
        {
            Console.WriteLine($"Text: {text}");
        }


    }
}
