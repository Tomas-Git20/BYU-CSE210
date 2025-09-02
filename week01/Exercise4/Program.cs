using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ask the user for a series of numbers, and append each one to a list.
        // Stop when they enter 0. Do NOT add 0 to the list.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number); // Only add non-zero numbers
            }
        }

        // Step 1: Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Step 2: Compute the average
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Step 3: Find the max
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}
