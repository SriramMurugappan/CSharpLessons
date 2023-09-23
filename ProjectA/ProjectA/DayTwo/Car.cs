using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.DayTwo
{
    internal class Car
    {
        public string CarMake { get; set; } = string.Empty;
        public string CarModel { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public string Engine { get; set; } = string.Empty;
        public int price { get; set; }

        public override string ToString()
        {
            return $"Car Make: {CarMake}, Car Model: {CarModel}, Version: {Version}, \n " +
                $" Colour: {Colour}, Engine: {Engine}, Price: {price}";
        }

        internal class TestCar 
        {
            public static void TestOne() 
            {
                Car CarOne = new Car();
                CarOne.CarMake = "Honda";
                CarOne.CarModel = "City";
                CarOne.Version = "Vx";
                CarOne.Colour = "Silver";
                CarOne.Engine = "1.5L Vtec";
                CarOne.price = 140000;
                string value = CarOne.ToString();
                Console.WriteLine(value);

            }
            
        }
    }
}
