using System.Security.Cryptography.X509Certificates;

namespace OOP
{


    internal partial class Program
    {

        static void Main(string[] args)
        {

            // Car
            var Car1 = new Car("Skoda", "Octavia", 2008);
            Car1.startEngine();
            var ElectricCar1 = new ElectricCar("Tesla", "Model S", 2021, 100);
            ElectricCar1.startEngine();
            ElectricCar1.DisplayBatteryInfo();
            ElectricCar1.drive();
            var DieselCar1 = new DieselCar("Ford", "F-150", 2019, 80);
            DieselCar1.startEngine();
            DieselCar1.DisplayFuelInfo();
            DieselCar1.drive();

            // Person
            var Person1 = new Person("Jan", 30);
            Person1.Introduce();

            // Animal
            var Dog1 = new Dog("Rex", 5, "Labrador");
            Dog1.Speak();
            Animal Animal1 = new Animal("Koza", 3);
            Animal1.Speak();

            //Interface TODO

            Truck Truck1 = new Truck();
            Truck1.drive();

            //Ishape
            IShape shape = ShapeFactory.CreateShape("Circle");
            IShape shape2 = ShapeFactory.CreateShape("Rectangle");

            shape.draw();
            shape2.draw();

        }
    }
}
