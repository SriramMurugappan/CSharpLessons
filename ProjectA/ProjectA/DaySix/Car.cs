using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.DaySix
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid,
        Hydrogen
    }
    internal class Car
    {
        public string RegistrationNo { get; set; }
        public string CarModel { get; set; }
        public FuelType CarFuelType { get; set; }
        public Wheel[] Wheels { get; } = new Wheel[4];
        public Engine CarEngine { get; }

        public Car(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            CarModel = model;
            CarFuelType = fuelType;
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
            CarEngine = new Engine();
        }
        public class Wheel
        {
            //Wheel properties
        }
        public class Engine
        {
            //Engine properties
        }

    }
    class TestCar
    {
        public static void TestOne()
        {
            Car myCar = new Car("282", "Pagani Zonda", FuelType.Petrol);

            // Accessing inner classes
            Car.Wheel wheel = new Car.Wheel();
            Car.Engine engine = new Car.Engine();

            // Using properties and methods of the Car class
            Console.WriteLine($"Car Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Car Fuel Type: {myCar.CarFuelType}");
            Console.WriteLine($"Car Model: {myCar.CarModel}");
            Console.WriteLine($"Car Engine Type: 6L V12");

        }
    }
}
