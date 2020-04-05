using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int price = width * height * length * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + String.Format("{0:C2}", price));
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
