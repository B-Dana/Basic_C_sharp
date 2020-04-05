using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload2
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public static bool operator== (Employee employee, Employee employee2)
        {
            bool isEqual = (employee.ID == employee2.ID);
            return isEqual;
        }

        public static bool operator!= (Employee employee, Employee employee2)
        {
            bool notEqual = (employee.ID != employee2.ID);
            return notEqual;
        }
    }
}
