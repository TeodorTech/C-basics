using Programe.Exceptions;
using System.Diagnostics;

namespace Programe
{
    public class Programe
    {

        static void Main(string[] args)
        {


            User userTeodor = new User("", "Nicolau", 23);
            User userAlex = new User("Alex", "Dinca", -5);
            try
            {
                userAlex.CheckAge();

            }
            catch (ExceptionAge ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception er)
            {
                Debug.WriteLine(er.Message);
                Console.WriteLine(er.Message);
            }

#if DEBUG
            finally
            {
                Debug.WriteLine("We are in Debug");
                Console.WriteLine("The programe was executed in DEBUG");
            }
#endif



            Payment payHonda = new Payment(100, true);
            Payment payToyota = new Payment(150, false);


            Car carHonda = new Car("Honda", "Civic", 2020, 25000);
            Car carToyota = new Car("Toyota", "Supra", 2021, 50500);

            Booking bookHonda = new Booking(payHonda.Total(0), payHonda.isPaid, carHonda=null, userTeodor);
            bookHonda.BookCar();


            Booking bookToyota = new Booking(payToyota.Total(10), payToyota.isPaid, carToyota, userAlex);
            bookToyota.BookCar();




















        }



    }
}