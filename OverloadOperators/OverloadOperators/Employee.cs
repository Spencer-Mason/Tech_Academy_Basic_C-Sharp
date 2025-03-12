using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee
    {
        // Define employee properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overriding the '==' operator
        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;
            if (emp1 is null || emp2 is null)
                return false;
            return emp1.Id == emp2.Id;
        }
        // Overriding '!=' operator; they must be done in pairs
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Overriding Equals and GetHashCode is good practice when overloading the '==' operator
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return this.Id == other.Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
