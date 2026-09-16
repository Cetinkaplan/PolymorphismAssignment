# C# Interfaces and Polymorphism

## Assignment Overview

This project is a C# console application that demonstrates the use of **interfaces, inheritance, implementation, and polymorphism**.

The assignment creates an `IQuittable` interface with a `Quit()` method. The `Employee` class implements the interface and provides its own implementation of the `Quit()` method. The program then uses polymorphism to create an object of type `IQuittable` and calls the `Quit()` method.

Please review Polymorphism Assignment under myConsoleProject and Program.cs ! 

## Requirements

The application includes the following:

1. An interface called `IQuittable`.
2. A `void Quit()` method defined inside the `IQuittable` interface.
3. An `Employee` class that inherits from and implements `IQuittable`.
4. An implementation of the `Quit()` method inside the `Employee` class.
5. An `IQuittable` object that references an `Employee` object.
6. A call to the `Quit()` method using the `IQuittable` object.
7. Comments throughout the code explaining what each line or block does.

## Technologies Used

* C#
* .NET
* Visual Studio
* Git
* GitHub

## Concepts Demonstrated

### Interface

The `IQuittable` interface defines a contract that requires implementing classes to provide a `Quit()` method.

```csharp
public interface IQuittable
{
    void Quit();
}
```

### Interface Implementation

The `Employee` class implements the `IQuittable` interface:

```csharp
public class Employee : IQuittable
{
    public void Quit()
    {
        Console.WriteLine("The employee has quit the company.");
    }
}
```

### Polymorphism

Polymorphism is demonstrated by assigning an `Employee` object to a variable of type `IQuittable`:



The `Quit()` method can then be called through the interface:


## Expected Output

When the program runs, the console displays:


## How to Run the Program

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Build the solution.
4. Run the console application.
5. The program will display the employee's quit message in the console.

## Purpose of the Assignment

The purpose of this assignment is to practice creating and implementing interfaces in C# and to understand how polymorphism allows an object to be referenced through an interface type.

## Author

Selcuk Kaplan
