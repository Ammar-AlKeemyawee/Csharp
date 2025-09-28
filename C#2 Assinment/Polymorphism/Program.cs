using System; // Importing System namespace for console operations

// Define a custom interface named IResignable
// It contains one method: Resign, which has no return value
public interface IResignable
{
    void Resign(); // Interface method signature
}

// Create the Employee class, which will implement IResignable
public class Employee : IResignable
{
    // Property to store the employee's given name
    public string GivenName { get; set; }

    // Property to store the employee's family name
    public string FamilyName { get; set; }

    // Implement the Resign() method defined in IResignable
    public void Resign()
    {
        // Output a unique resignation message
        Console.WriteLine($"Notice: {GivenName} {FamilyName} has officially submitted their resignation.");
    }
}

// The main program class that contains the application entry point
class Program
{
    static void Main(string[] args)
    {
        // Instantiate a new Employee object and set property values
        Employee teamMember = new Employee
        {
            GivenName = "Ammar",
            FamilyName = "AlKeemyawee"
        };

        // Use polymorphism: treat the Employee object as an IResignable
        IResignable resigningEmployee = teamMember;

        // Call the Resign() method through the interface type
        // This demonstrates polymorphism in action
        resigningEmployee.Resign();

        // Keep the console open until a key is pressed
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
