using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Person
    {
        public string firstName;
        public static int Id;
        public int age;
        public Person(string firstName,int age)
        {
            this.firstName = firstName;
            this.age = age;
            Id++;
        } 

    }
}
