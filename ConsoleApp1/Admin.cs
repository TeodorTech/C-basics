using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Admin
    {
        private string name;
        public int Id;
        public Admin(string name, int id)
        {
            this.Name = name;
            Id = id;
        }
        //Here i set the code to print "You are not the admin" if the user inputs something else instead of admin
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "Admin")
                {
                    name = value;
                }
                else
                {
                    Console.Write("You are not the admin");
                }

            }

        }
    }
}
