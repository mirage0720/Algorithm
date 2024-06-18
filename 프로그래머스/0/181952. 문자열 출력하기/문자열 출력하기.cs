using System;

public class Example
{
    public static void Main()
    {
        string str = Console.ReadLine();
        
        if (str.Length >= 1 && str.Length <= 1000000)
        {
            Console.WriteLine(str);
        }
        else
        {
            Console.WriteLine("The input string does not meet the length requirements.");
        }

    }
}