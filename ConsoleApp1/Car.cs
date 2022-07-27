using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    public class Car
    {
        private Guid id;
        public Guid Id { get => id; }
        

        public string make;
        public string model;
        public int year;
        private bool available;
        public bool Available { get => available; set => available = value; }
        public int price;

        public Car(string make, string model, int year, int price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.available = true;
            id = Guid.NewGuid();
        }



        
    }
}
