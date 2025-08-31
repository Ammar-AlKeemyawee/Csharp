using System;

class Program
{
    static void Main()
    {
        // Initial welcome banner
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Request and capture package weight from user input
        Console.Write("Package weight (in lbs): ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Enforce weight limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit early due to excessive weight
        }

        // Gather dimensions from user
        Console.Write("Package width (in inches): ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Package height (in inches): ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Package length (in inches): ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Total dimension check
        decimal sizeSum = width + height + length;
        if (sizeSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exceeds size limit
        }

        // Shipping quote formula applied here
        decimal quote = (width * height * length * weight) / 100;

        // Display formatted quote with currency symbol and 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
