using System;

public class Example
{
    public static void Main()
    {
        // Read the input as a single line
        string input = Console.ReadLine();
        
        // Split the input into two parts
        string[] parts = input.Split(' ');
        
        // Parse the two parts as integers
        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        // Check if the inputs are within the specified range
        if (a >= -100000 && a <= 100000 && b >= -100000 && b <= 100000)
        {
            // Print the output in the specified format
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
        else
        {
            Console.WriteLine("The input values are out of the specified range.");
        }
    }
}