namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Introduce()
        {
            Console.WriteLine($"Ahoj, jmenuji se {Name} a je mi {Age} let.");
        }
    }
}
