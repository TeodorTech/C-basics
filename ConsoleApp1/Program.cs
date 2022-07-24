namespace Programe
{   
    class Programe
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person("Teodor", 23);
            Console.WriteLine(Person.Id);
            Person person2 = new Person("Alex", 26);
            Console.WriteLine(Person.Id);
            Car.isAvailable();
            Admin admin1 = new Admin("Teodor", 1);
            Console.WriteLine(admin1.Name);
            Payment pay1 = new Payment(100);
            Console.WriteLine(pay1.Total(500));
           
            
           
        }



    }
}