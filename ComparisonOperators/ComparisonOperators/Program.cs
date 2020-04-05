using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string weekHours = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string rate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();

            Console.WriteLine("Weekly salary of Person 1:");
            int total = Int32.Parse(rate) * Int32.Parse(weekHours);
            Console.WriteLine(total);
            Console.WriteLine("Weekly salary of Person 2:");
            int total2 = Int32.Parse(rate2) * Int32.Parse(weekHours2);
            Console.WriteLine(total2);

            Console.WriteLine("Does Person 1 make more money than Person 2 ?");
            bool compare = total > total2;
            Console.WriteLine(compare);
            Console.Read();






        }
    }
}
