using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
         
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                DateTime newDate = DateTime.Now;
                DateTime yearBorn = newDate.AddYears(-age);
                Console.WriteLine("You were born in " + yearBorn.Year);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter digits only, no letters.");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                    
                Console.WriteLine("Please enter positive numbers only, and not zero.");
                Console.ReadLine();
            }
                        
        }
    }
}
