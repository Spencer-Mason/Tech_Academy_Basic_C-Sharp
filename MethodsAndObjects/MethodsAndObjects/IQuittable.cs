using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Define interface with a Quit method
    // This ensures that any class inheriting from IQuittable must define the Quit() method
    interface IQuittable
    {
        void Quit();
    }
}
