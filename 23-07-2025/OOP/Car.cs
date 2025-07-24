namespace OOP
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;

        }

        public virtual void startEngine()
        {
            Console.WriteLine("Auto nastartovalo");
        }
    }

    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            BatteryCapacity = batteryCapacity;
        }
        public void DisplayBatteryInfo()
        {
            Console.WriteLine($"Kapacita baterky: {BatteryCapacity} kWh");
        }

        public override void startEngine()
        {
            Console.WriteLine("Elektrické auto nastartovalo");
        }

        public void drive()
        {
            Console.WriteLine("Elektrické auto potichu jede");
        }
    }

    public class DieselCar : Car
    {
        public int FuelTankCapacity { get; set; } 
        public DieselCar(string make, string model, int year, int fuelTankCapacity)
            : base(make, model, year)
        {
            FuelTankCapacity = fuelTankCapacity;
        }

        public override void startEngine()
        {
            Console.WriteLine("Dieselové auto nastartovalo");
        }
        public void DisplayFuelInfo()
        {
            Console.WriteLine($"Nádrž má: {FuelTankCapacity} litrů");
        }

        public void drive()
        {
            Console.WriteLine("Diselové auto jede");
        }

    }
}
