
using System;
namespace C_Sharp_Fundamentals.Basic
{
    class Variables
    {
        static void Main(string[] args)
        {
            // Variables in C#
            //variable is named storage location in memory (RAM) that can hold a value.
            // Variables are used to store data that can be changed during the execution of a program.
            // In most cases, in c# we need mention the type of variable we are going to use.
            //all variables will be stored in stack memory.
            // variable names must be unique within their scope and should follow certain naming conventions.
            // Variable names should be descriptive and meaningful, indicating the purpose of the variable.
            // variable name should not contain spaces or special characters (except for underscores).
            // variable names couldn't be a keyword or reserved word in C#.

            //to write a variable in c# we need to follow the following syntax:
            // <data_type> <variable_name> = <value>;
            // Example: int age = 25; // Here, 'int' is the data type, 'age' is the variable name, and '25' is the value.


            // 1. Declaring and Initializing Variables
            // Variables must be declared with a type and can be initialized with a value.
            int age = 25; // Integer type
            double pi = 3.14159; // Double type for floating-point numbers
            char grade = 'A'; // Character type for single characters
            string name = "John Doe"; // String type for text
            bool isActive = true; // Boolean type for true/false values

            // 2. Default Values
            // Variables declared without initialization have default values.
            int defaultInt; // Default value is 0
            double defaultDouble; // Default value is 0.0
            bool defaultBool; // Default value is false
            string defaultString; // Default value is null (no value)

            // 3. Implicitly Typed Variables
            // The 'var' keyword allows the compiler to infer the type based on the assigned value.
            var number = 42; // Compiler infers the type as int
            var message = "Hello, World!"; // Compiler infers the type as string

            // 4. Constants
            // Constants are immutable values that cannot be changed after declaration.
            const double Gravity = 9.8; // Value cannot be changed

            // 5. Readonly Variables
            // Readonly variables can only be assigned during declaration or in the constructor.
            // we use readonly for values that should not change after initialization.
            // we can't use readonly in a method.
            // readonly int readOnlyValue = 100;

            // 6. Nullable Variables
            // Nullable types allow variables to hold null values in addition to their normal range of values.
            int? nullableInt = null; // Nullable type can hold null
            nullableInt = 10; // Can also hold a valid integer value

            // 7. Dynamic Variables
            // Dynamic variables allow their type to be determined at runtime.
            dynamic dynamicVariable = 1; // Initially an integer
            dynamicVariable = "Now I'm a string"; // Now a string

            // 8. Object Type
            // The 'object' type is the base type of all types in C# and can hold any data type.
            object obj = 42; // Initially an integer
            obj = "Now I'm a string"; // Now a string

            // 9. Type Conversion
            // Implicit conversion happens automatically when there is no risk of data loss.
            int intValue = 10;
            double doubleValue = intValue; // Implicit conversion from int to double

            // Explicit conversion (casting) is required when there is a risk of data loss.
            int anotherIntValue = (int)doubleValue; // Explicit conversion from double to int

            // 10. Output Variables
            // Output variables are used to return multiple values from a method.
            int result;
            bool success = int.TryParse("123", out result); // 'result' is assigned within the method

            // Printing Variables
            // Displaying the values of variables using Console.WriteLine
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Is Active: {isActive}");
            Console.WriteLine($"Nullable Int: {nullableInt}");
            Console.WriteLine($"Dynamic Variable: {dynamicVariable}");
            Console.WriteLine($"Object Variable: {obj}");
            Console.WriteLine($"Conversion Result: {anotherIntValue}");
            Console.WriteLine($"TryParse Success: {success}, Result: {result}");
        }
    }
}
