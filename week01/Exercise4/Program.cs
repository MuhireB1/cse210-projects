using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Initiate a list//
        List<int> numbersList = new List<int>();
        
        int entry = -1;
        int count = 0;
        while (entry != 0)
        {
            Console.Write("Enter a list of numbers (type 0 when finnishes). ");
            string response = Console.ReadLine();
            entry = int.Parse(response);

            // Conditions not to add 0 to the list//
            if (entry != 0 )
            {
                numbersList.Add(entry);
                // count entry times//
                count++;
            }
            
        }
        
        // Calculate sum//
        int total = numbersList.Sum();
        Console.WriteLine($"The sum is {total}");
        //compute Average//
        double average = total / count;
        Console.WriteLine($"The average is: {average}");
        // Find the max and min//
        int max = numbersList.Max();
        Console.WriteLine($"The largest number is {max}");
        // Find the smallest positive number close to 0//
        int min = numbersList.Where(x => x > 0).Min();
        Console.WriteLine($"The smallest positive number is {min}");
        // Sort the list in ascending order//
        numbersList.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }

        } 

       
    }