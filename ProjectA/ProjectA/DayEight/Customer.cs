using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
/*using System.Threading.Tasks;

namespace ProjectA.DayEight
{
    internal class Customer
    {
        private readonly double Id;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double CreditLimit { get; set; }
        public Customer(double v1) { Id = v1; }
        public double GetID() { return Id; }
        public override string ToString()
        {
            return $"Details: {Id} {FirstName}{MiddleName}{LastName}{CreditLimit}";
        }
        public static void SerializeCustomer()
        {
            Customer obj = new Customer(1001);
            obj.FirstName = "Venkat";
            obj.LastName = "Krishnan";
            obj.MiddleName = "B";
            obj.CreditLimit = 200000;
            Console.WriteLine("Before serialization");
            obj.ToString();
            Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            //Opens a file and serializes the object into it in binary format.
            using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                formatter.Serialize(stream, obj);
            }
            Console.WriteLine("Completed.....");
        }
    }

}*/
