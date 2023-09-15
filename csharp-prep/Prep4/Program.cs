using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
           
        List<int> numbers = new List<int>();

        // Note we can use While loop here also

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        int userNumber = - 1;

        
        do
        {
            Console.Write("Enter a number:");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // add the number to the list if it is not 0
            if (userNumber != 0)
             {
                numbers.Add(userNumber);
            }


        } while (userNumber != 0);

         int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        
         float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Part 3: Finding the max
        //  sorting the list

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
               


    }
}