using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Car
    {
        public string make;
        public string model;
        public int year;
        public static bool available=true;
        public int price;
        public Car(string make, string model, int year, int price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        //this function checks in the payment class if a payment was done then sets the availability of the car to false 
        public static void isAvailable()
        {
            if (Payment.payment == true)
            {
                available = false;
                Console.WriteLine("Car is already booked");
            }

        }


    }
}
