using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        // Method with an output parameter, marked as void because there's no return value
        public void Method1(int param1, out int variable)
        {
            variable =  param1 / 2;
        }

        // Overloaded method to take two variables instead of one
        public void Method1(int param1, int param2, out int variable)
        {
            variable = param1 / param2;
        }
    }

    // A static class
    static class Class2
    {

    }
}
