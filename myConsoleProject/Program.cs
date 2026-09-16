// Defines an interface named IQuittable.
// An interface specifies a method that a class must implement.
public interface IQuittable
{
    // Declares a void method named Quit().
    // Any class implementing IQuittable must provide the code for this method.
    void Quit();
}

// Defines the Employee class.
// Employee inherits from the IQuittable interface.
public class Employee : IQuittable
{
    // Stores the employee's first name.
    public string FirstName { get; set; }

    // Stores the employee's last name.
    public string LastName { get; set; }

    // Implements the Quit() method required by the IQuittable interface.
    public void Quit()
    {
        // Displays a message when the employee quits.
        Console.WriteLine("The employee has quit the company.");
    }
}

// Defines the main Program class.
class Program
{
    // The Main() method is where the console application begins execution.
    static void Main(string[] args)
    {
        // Creates a new Employee object and assigns first and last names.
        Employee employee = new Employee();
        employee.FirstName = "John";
        employee.LastName = "Smith";

        // Creates an IQuittable interface-type variable.
        // The Employee object is assigned to it because Employee implements IQuittable.
        // This is an example of polymorphism.
        IQuittable quittableEmployee = employee;

        // Calls the Quit() method through the IQuittable interface.
        // C# executes the Employee class's implementation of Quit().
        quittableEmployee.Quit();

        // Keeps the console window open so the user can see the output.
        Console.ReadLine();
    }
}