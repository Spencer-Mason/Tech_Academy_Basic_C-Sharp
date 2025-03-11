using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Employee class inhetits from abstract class Person and implements interface IQuittable
    class Employee : Person, IQuittable
    {
        // Override method to alter it and print name to console
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        // Implement interface method to print quit message to console
        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit.", FirstName, LastName);
        }
    }
}
