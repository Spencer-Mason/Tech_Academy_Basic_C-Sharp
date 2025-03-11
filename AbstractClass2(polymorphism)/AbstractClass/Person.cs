using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Abstract class, will never get instantiated; only for inheriting
    public abstract class Person
    {
        // Define properties that every person will have i.e. first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method; will be implemented after inherited
        public abstract void SayName();
    }
}
