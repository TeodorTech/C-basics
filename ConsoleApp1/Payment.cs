using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Payment
    {
        public static int Id;
        public int ammount;
        public static bool payment=true;
        public double numberDaysRented;
        public Payment(int ammount)
        {
            Id++;
            this.ammount = ammount;
    
            /*this.numberDaysRented = numberDaysRented;*/
        }
        //Here i have overloaded the method
       public int Total (int numberDaysRented) {  return ammount* numberDaysRented; }
       public double Total(double numberDaysRented) {  return  ammount * numberDaysRented; }
       public float Total(float numberDaysRented) { return ammount * numberDaysRented; }
    }
}
