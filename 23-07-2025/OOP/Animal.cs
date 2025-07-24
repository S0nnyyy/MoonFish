namespace OOP
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} Dělá zvuk");
        }
    }

    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} šteká!");
        }
    }
}
