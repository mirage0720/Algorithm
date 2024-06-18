using System;

public class Example
{
    public static void Main()
    {
        // Read the input string
        string str = Console.ReadLine();

        // Check if the input is within the specified range
        if (str.Length >= 1 && str.Length <= 20)
        {
            // Initialize a character array to store the result
            char[] result = new char[str.Length];

            // Iterate over each character in the input string
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                // Check if the character is a lowercase letter
                if (char.IsLower(c))
                {
                    // Convert to uppercase
                    result[i] = char.ToUpper(c);
                }
                // Check if the character is an uppercase letter
                else if (char.IsUpper(c))
                {
                    // Convert to lowercase
                    result[i] = char.ToLower(c);
                }
                else
                {
                    // Copy the character as is (shouldn't be needed since input is alphabet only)
                    result[i] = c;
                }
            }

            // Convert the character array back to a string and print it
            Console.WriteLine(new string(result));
        }
        else
        {
            Console.WriteLine("The input string length is out of the specified range.");
        }

    }
}