namespace kolekceLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Seznam osob
            List<Person> people = new List<Person>
            {
                new Person { Jmeno = "Martin", Prijmeni = "Malá",  Vek = 37 },
                new Person { Jmeno = "Bob", Prijmeni = "Velký", Vek = 25 },
                new Person { Jmeno = "Alice", Prijmeni = "Stará", Vek = 35 },
                new Person { Jmeno = "Tomáš", Prijmeni = "Nový", Vek = 28 },
                new Person { Jmeno = "Eva", Prijmeni = "Černá", Vek = 45 },
                new Person { Jmeno = "Tomáš", Prijmeni = "Bílý", Vek = 32 }
            };

            foreach (var person in people)
            {
                person.SayHello();
            }


            // LINQ dotaz pro získání osob starších než 30 let a seřazením podle jména
            var query = from person in people
                        where person.Vek > 30
                        orderby person.Jmeno
                        select person;
            Console.WriteLine("\nOsoby starší než 30 let:");
            foreach (var person in query)
            {
                Console.WriteLine($"{person.Jmeno}, {person.Vek} let");
            }

            //suda cisla v list<int>
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;
            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"Sudé číslo: {number}");
            }

            //seznam person a najit osoby starší než 30 let
            var olderThan30 = people.Where(p => p.Vek > 30).ToList();
            Console.WriteLine("\nOsoby starší než 30 let (pomocí Where):");
            foreach (var person in olderThan30)
            {
                Console.WriteLine($"{person.Jmeno}, {person.Vek} let");
            }

            //Serad seznam osob podle příjmení
            var sortedByLastName = people.OrderBy(people => people.Prijmeni).ToList();
            Console.WriteLine("\nSeřazeno podle příjmení:");
            foreach (var person in sortedByLastName)
            {
                Console.WriteLine($"{person.Jmeno} {person.Prijmeni}, {person.Vek} let");
            }

            //najít prní osobu s jménem "omáš pokud existuje
            var firstPersonWithName = people.FirstOrDefault(p => p.Jmeno == "Tomáš");
            if (firstPersonWithName != null)
            {
                Console.WriteLine($"\nPrvní osoba s jménem Tomáš: {firstPersonWithName.Jmeno}, {firstPersonWithName.Vek} let");
            }
            else
            {
                Console.WriteLine("\nŽádná osoba s jménem Tomáš nebyla nalezena.");
            }

            //dictionary<string, int> inventar kde vypisujeme vsechny položky
            Dictionary<string, int> inventory = new Dictionary<string, int>
            {
                { "Jabko", 10 },
                { "Banán", 5 },
                { "Hruška", 8 },
                { "Pomeranč", 12 }
            };
            Console.WriteLine("\nInventář:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key}: {item.Value} kusů");
            }
        }
    }
}
