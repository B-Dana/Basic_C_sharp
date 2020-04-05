using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things=new List<string>() { "Adam", "Sandler", "Software Engineer"};
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 41, 2, 50, 1000 };
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
