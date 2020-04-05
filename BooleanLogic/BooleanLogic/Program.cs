using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool dui1 = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticket1 = Convert.ToInt32(ticket);
            Console.WriteLine("Qualified?");
            bool result = age1 > 15 && dui1 == false && ticket1 <= 3;
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
