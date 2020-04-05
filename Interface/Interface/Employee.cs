using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", this.firstName, this.lastName);
        }
        void IQuittable.Quit()
        {
            Console.WriteLine("The employee quit");
        }
    }
}
