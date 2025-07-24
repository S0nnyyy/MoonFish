namespace OOP
{

        public class Car2 : IDriveable
        {
            public void drive()
            {
                Console.WriteLine("Auto jede");
            }

        }

        public class Truck : IDriveable
        {

            public void drive()
            {
                Console.WriteLine("Truck jede");
            }
        }

        public class Bike : IDriveable
        {
            public void drive()
            {
                Console.WriteLine("Motorka jede");
            }
    }

}
