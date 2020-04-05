using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
        string[] array = { "My", "first", "array", "in", "C#." };
        Console.WriteLine("Please, enter the index of an array beetween 0 and 4");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index < 5)
        {
            Console.WriteLine(array[index]);
        }
        else
        {
            bool notInRange = index >= 5;
            while (notInRange == true)
            {
                Console.WriteLine("Your index is out of range");
                Console.WriteLine("Please, enter the index of an array beetween 0 and 4");
                index = Convert.ToInt32(Console.ReadLine());
                if (index < 5)
                {
                    Console.WriteLine(array[index]);
                    break;
                }
            }
        }
               

        int[] array2 = {2, 45, 100, 6, 55, 7, 90, 15, 30 };
        Console.WriteLine("Please, enter the index of an array beetween 0 and 8");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 < 9)
        {
            Console.WriteLine(array2[index2]);
        }
        else
        {
            bool notInRange = index2 >= 9;
            while (notInRange == true)
            {
                Console.WriteLine("Your index is out of range");
                Console.WriteLine("Please, enter the index of an array beetween 0 and 8");
                index2 = Convert.ToInt32(Console.ReadLine());
                if (index2 < 5)
                {
                    Console.WriteLine(array2[index2]);
                    break;
                }
            }
        }

        List<string> myList = new List<string>();
        myList.Add("My");
        myList.Add("first");
        myList.Add("list");
        myList.Add("in");
        myList.Add("C#.");
        Console.WriteLine("Please, enter the index of an array beetween 0 and 4");
        int index3 = Convert.ToInt32(Console.ReadLine());
        if (index3 < 5)
        {
            Console.WriteLine(myList[index3]);
        }
        else
        {
            bool notInRange = index3 >= 5;
            while (notInRange == true)
            {
                Console.WriteLine("Your index is out of range");
                Console.WriteLine("Please, enter the index of an array beetween 0 and 4");
                index3 = Convert.ToInt32(Console.ReadLine());
                if (index3 < 5)
                {
                    Console.WriteLine(myList[index3]);
                    break;
                }
            }
        }
        Console.ReadLine();

        }
    }

