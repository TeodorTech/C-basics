using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    public class User
    {
        public string firstName;
        public string lastName;
        private  Guid id;
        public int age;
      
        public Guid Id { get => id;}
        public User(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.age = age;
            id = Guid.NewGuid();
            this.lastName = lastName;
        }
        public void  CheckAge()
        {
            try
            {
                if (age > 18 ) { Console.WriteLine("You can drive <3"); }
                else if (age<18 && age>0) { throw new ExceptionAge ("!!!Rent a bike!!!"); }
                else  { throw new Exception("!!!Try again, age was incorect!!!"); }
            }
            catch
            {
                throw;

            }
            }

    }

}
