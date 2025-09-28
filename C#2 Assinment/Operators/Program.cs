using System; // Import the System namespace for console I/O and basic operations

// Define the StaffMember class with properties and operator overloads
public class StaffMember
{
    // Property for staff ID (used for comparison)
    public int StaffId { get; set; }

    // Property for staff member's first name
    public string GivenName { get; set; }

    // Property for staff member's last name
    public string Surname { get; set; }

    // Overload "==" operator to compare two StaffMember objects by StaffId
    public static bool operator ==(StaffMember a, StaffMember b)
    {
        // If both references are the same or both are null, return true
        if (ReferenceEquals(a, b))
            return true;

        // If one is null and the other isn't, return false
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        // Compare using StaffId
        return a.StaffId == b.StaffId;
    }

    // Overload "!=" operator (must be defined with "==")
    public static bool operator !=(StaffMember a, StaffMember b)
    {
        return !(a == b);
    }

    // Override Equals() for consistency with "=="
    public override bool Equals(object obj)
    {
        // Safely cast and compare
        var other = obj as StaffMember;
        if (other == null)
            return false;

        return this.StaffId == other.StaffId;
    }

    // Override GetHashCode() to match the logic used in Equals()
    public override int GetHashCode()
    {
        return StaffId.GetHashCode();
    }
}

// Program class containing the Main method (entry point)
class Program
{
    static void Main(string[] args)
    {
        // Instantiate the first staff member and assign values
        StaffMember staffA = new StaffMember
        {
            StaffId = 2001,
            GivenName = "Ammar",
            Surname = "AlKeemyawee"
        };

        // Instantiate the second staff member and assign different values
        StaffMember staffB = new StaffMember
        {
            StaffId = 2002, // Try 2001 to test equality
            GivenName = "Mike",
            Surname = "Miller"
        };

        // Compare the two staff members using overloaded "=="
        Console.WriteLine("Comparing staff members by their ID...\n");

        if (staffA == staffB)
        {
            Console.WriteLine("Match found: Both staff members have the same ID.");
        }
        else
        {
            Console.WriteLine("No match: Staff members have different IDs.");
        }

        // Show confirmation using the "!=" operator
        Console.WriteLine();
        Console.WriteLine("Secondary check using '!=' operator:");

        if (staffA != staffB)
        {
            Console.WriteLine("Confirmed: These are different staff members.");
        }
        else
        {
            Console.WriteLine("Confirmed: These staff records represent the same person.");
        }

        // Pause before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
