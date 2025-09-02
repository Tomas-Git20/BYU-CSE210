using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage;

        // Validate input
        if (!int.TryParse(input, out percentage))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        string letter;

        // Determine letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Output the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Determine pass/fail
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying and you'll do better next time.");
        }
    }
}
