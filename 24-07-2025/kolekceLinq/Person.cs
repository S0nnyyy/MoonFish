namespace kolekceLinq
{
    public class Person
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public void SayHello()
        {
            Console.WriteLine($"Ahoj já jsem {Jmeno} a je mi {Vek}");
        }
    }
}
