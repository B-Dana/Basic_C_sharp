using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee {FirstName="Ken", LastName="Biden", ID=1 }, 
            new Employee {FirstName="Paul", LastName="Johnson", ID=2 },
            new Employee {FirstName="Bill", LastName="Adams", ID=3 },
            new Employee {FirstName="Joe", LastName="Smith", ID=4 },
            new Employee {FirstName="Kim", LastName="Johnson", ID=5 },
            new Employee {FirstName="Samantha",LastName="Jones", ID=6 },
            new Employee {FirstName="Joe", LastName="Sandler", ID=7 },
            new Employee {FirstName="Kate", LastName="White", ID=8 },
            new Employee {FirstName="Matt", LastName="Daimon", ID=9 },
            new Employee {FirstName="Ben", LastName="Afflek", ID=10 }
            };

            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName=="Joe")
                {
                    newList.Add(employee);
                }
            }

            foreach (Employee employee in newList)
            {
                Console.WriteLine("Name: {0} {1}, ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            Console.ReadLine();

            List<Employee> newList2 = employees.FindAll(x => x.FirstName=="Joe").ToList();
            List<Employee> newList3 = employees.FindAll(x => x.ID>5).ToList();
            { }

            foreach (Employee e in newList2)
            {
                Console.WriteLine("Name: {0} {1}, ID: {2}", e.FirstName, e.LastName, e.ID);
            }
            Console.ReadLine();

            foreach (Employee e in newList3)
            {
                Console.WriteLine("Name: {0} {1}, ID: {2}", e.FirstName, e.LastName, e.ID);
            }
            Console.ReadLine();
        }
    }
}
