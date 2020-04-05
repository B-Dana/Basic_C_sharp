using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { ID = 24 };
            Employee employee2 = new Employee() { ID = 25 };
            bool isEqual = employee1.ID == employee2.ID;

            Console.WriteLine(isEqual);
            Console.ReadLine();

        }
    }
}
