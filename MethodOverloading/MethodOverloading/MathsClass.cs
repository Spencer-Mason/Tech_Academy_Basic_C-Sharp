using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class MathsClass
    {
        // Math method with an integer parameter
        public static int Math(int number)
        {
            int mathedNumber = number * 5;
            return mathedNumber;
        }

        // Math method with a double parameter, for taking and giving decimals
        public static double Math(double number)
        {
            double mathedNumber = number / 2.5;
            return mathedNumber;
        }

        // Math method with a string parameter, converting it to an integer to perform
        // math operations, and returning it back as a string
        public static string Math(string number)
        {
            int converted = Convert.ToInt32(number);
            string mathedNumber = Convert.ToString(converted + 10);
            return mathedNumber;
        }
    }
}
