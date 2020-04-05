using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            Console.WriteLine("Enter a number");
            int Hour = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = dateTime.AddHours(Hour);
            Console.WriteLine(newTime);

            Console.ReadLine();
        }
    }
}