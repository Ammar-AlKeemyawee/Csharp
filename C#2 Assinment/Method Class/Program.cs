using System; // Provides core functionalities like input/output operations

// Define a class that will contain our number-processing logic
public class NumberHandler
{
    // This method takes two integers, performs a math operation on the first,
    // and prints both results to the console
    public void ProcessNumbers(int inputOne, int inputTwo)
    {
        // Add 10 to the first input number
        int modifiedValue = inputOne + 10;

        // Show the result of the operation
        Console.WriteLine($"After adding 10, the first number becomes: {modifiedValue}");

        // Display a message involving the second number
        Console.WriteLine($"FYI, the second number you passed in was: {inputTwo}");
    }
}

// This is the main entry point of the application
class Program
{
    static void Main(string[] args)
    {
        // Create an object from the NumberHandler class so we can call its method
        NumberHandler handler = new NumberHandler();

        // Call the method using standard positional arguments
        handler.ProcessNumbers(7, 15);

        // Call the method again using named arguments (order doesn't matter here)
        handler.ProcessNumbers(inputTwo: 25, inputOne: 12);

        // Keep the console open so the user can see the output
        Console.WriteLine("Press any key to close the program.");
        Console.ReadKey();
    }
}
