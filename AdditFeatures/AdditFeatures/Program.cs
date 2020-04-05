using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Name = "Dana";

            var LastName = "Badmaeva";

            Employee employee = new Employee(Name);
            Console.WriteLine("Name: "+ employee.Name+" "+LastName);
            Console.WriteLine("ID: "+ employee.ID);
            Console.ReadLine();

        }
    }
}
