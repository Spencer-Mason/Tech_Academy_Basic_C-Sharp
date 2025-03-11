using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Class that inherits from person class, and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Adds an ID property
        public int Id { get; set; }

        // Implement the Quit method
        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit.", FirstName, LastName);
        }
    }
}
