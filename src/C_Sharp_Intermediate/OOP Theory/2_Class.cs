using System;


partial class Program
{
    // the partial keyword allows you to split the definition of a class, struct, or interface into multiple files.
    // This is useful for organizing large classes or when multiple developers are working on the same class.
    static void Main(string[] args)
    {
        // A class is a blueprint for creating objects in object-oriented programming (OOP).
        // It defines the properties (attributes) and methods (functions) that the objects created from the class will have.
        // Classes are used to model real-world entities and their behaviors in a structured way.

        /**** Class members ****/

        // In C#, a class is defined using the `class` keyword followed by the class name.
        // The class can contain thing like:
        // 1) properties (attributes) that define the state of the object, it help to store data.
        // 2) methods (functions) that define the behavior of the object, it help to perform actions.
        // 3) constructors (special methods) that are used to initialize the object when it is created.
        // 4) fields (variables) that are used to store data.
        // 5) destructors (special methods) that are used to clean up resources when the object is destroyed.
        // 6) events (notifications) that are used to notify other objects when something happens.
        // 7) indexers (special properties) that allow you to access the elements of a class using an index.



        // we use the `new` keyword to create an instance (object) of the class.
        // It is the convention to use PascalCase for class names in C#.

        // The class can also have access modifiers (like public, private, protected) to control the visibility of its members.

        /******* Access Modifiers ******/


        // A class has two types of access modifiers: 1) internal and 2) public.
        // An internal class is accessible only within the same assembly, while a public class can be accessed from any assembly.
        // the default access modifier for a class is internal. which means that if you don't specify an access modifier, the class will be internal by default.

        // A assembly can be called as a project or a library.
        // A solution is a container for one or more projects, and it can contain multiple assemblies.
        // A namespace is a way to organize classes and other types in C#. It helps to avoid naming conflicts and makes the code more readable.

        /******* Modifiers ******/

        /*after the accessModifier we have also some modifiers like abstract, sealed, static, and partial.
        A modifier is a keyword that changes the behavior of a class or its members.
        For example, an abstract class is a class that cannot be instantiated directly and is meant to be inherited by other classes.
        A sealed class is a class that cannot be inherited from and is used to prevent further inheritance.
        A static class is a class that cannot be instantiated and can only contain static members. It is used to group related methods and properties together.
        A partial class is a class that can be split into multiple files, allowing for better organization and collaboration in large projects.
        there is no default modifiers for a class. all modifiers are optional.
        */

        // Example: Modeling a Car using a class

        // The Car class represents a blueprint for creating car objects.

        // Creating an object of the Car class
        Car myCar = new Car("Toyota", "Corolla", 2020, "Blue");

        // Accessing properties
        Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model} in {myCar.Color} color.");

        // Calling methods
        myCar.Drive();
        myCar.Stop();
    }

}


// Real-life usage example
// In the Main method, we can create objects of the Car class and use them.
public class Car
{
    // Properties (attributes) of the Car class
    public string Make { get; set; } // The manufacturer of the car (e.g., Toyota, Ford)
    public string Model { get; set; } // The model of the car (e.g., Corolla, Mustang)
    public int Year { get; set; } // The year the car was manufactured
    public string Color { get; set; } // The color of the car

    // Constructor: A special method used to initialize objects of the class
    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    // Method: A function that defines the behavior of the car
    public void Drive()
    {
        Console.WriteLine($"{Make} {Model} is driving.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} has stopped.");
    }
}

