using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Main class that has name properties
    public class Person
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        // Method that prints person's name
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
