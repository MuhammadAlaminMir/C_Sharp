
/*
 * C# Naming Conventions
 * ----------------------
 * Naming conventions in C# are guidelines that help developers write consistent, readable, and maintainable code. 
 * These conventions ensure that code is easily understandable by others and aligns with industry standards.
 *  naming conventions in C#:
 * 
 * 1. **PascalCase**:
 *    - Definition: Each word in the identifier starts with an uppercase letter.
 *    - Use Case: Used for public members, properties, methods, and class names.
 * 
 * 2. **camelCase**:
 *    - Definition: The first word starts with a lowercase letter, and subsequent words start with an uppercase letter.
 *    - Use Case: Used for private fields, local variables, and method parameters.
 * 
 * 3. **ALL_CAPS_WITH_UNDERSCORES**:
 *    - Definition: All letters are uppercase, and words are separated by underscores.
 *    - Use Case: Used for constants.
 * 
 * 4. **_camelCase**:
 *    - Definition: Similar to camelCase but prefixed with an underscore.
 *    - Use Case: Used for private fields when using backing fields for properties.
 * 
 * 5. **I-prefix**:
 *    - Definition: Interface names start with the letter "I" followed by a PascalCase name.
 *    - Use Case: Used for interface names to distinguish them from classes.
 * 
 * 6. **T-prefix**:
 *    - Definition: Generic type parameters start with the letter "T" followed by a descriptive name.
 *    - Use Case: Used for generic type parameters in classes, methods, and interfaces.
 * 
 * 7. **VerbNoun**:
 *    - Definition: Method names are written in PascalCase and describe an action using a verb followed by a noun.
 *    - Use Case: Used for method names to indicate actions.
 * 
 * 8. **Namespace Naming**:
 *    - Definition: Namespaces are written in PascalCase and align with the project structure.
 *    - Use Case: Used to organize code and avoid naming conflicts.
 * 
 * 9. **Avoid Hungarian Notation**:
 *    - Definition: Do not prefix variable names with type information (e.g., `strName` or `intCount`).
 *    - Use Case: Modern IDEs and tools provide type information, so this is unnecessary and discouraged.
 * 
 * 10. **File Naming**:
 *    - Definition: File names should match the class name and be written in PascalCase.
 *    - Use Case: Ensures consistency and makes it easier to locate files in the project.
 */

// 1. **PascalCase**: Used for public members, properties, methods, and class names.
public class NamingConventionsExample
{
    public string FirstName { get; set; } // Property in PascalCase
    public void DisplayMessage() // Method in PascalCase
    {
        Console.WriteLine("Hello, World!");
    }
}

// 2. **camelCase**: Used for private fields, local variables, and method parameters.
public class Example
{
    private int age; // Private field in camelCase

    public void SetAge(int userAge) // Parameter in camelCase
    {
        age = userAge; // Local variable in camelCase
    }
}

// 3. **ALL_CAPS_WITH_UNDERSCORES**: Used for constants.
public class ConstantsExample
{
    public const double PI_Value = 3.14159; // Constant in ALL_CAPS_WITH_UNDERSCORES
}

// 4. **_camelCase**: Used for private fields when using backing fields for properties.
public class BackingFieldExample
{
    private string _name; // Backing field with _camelCase

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

// 5. **I-prefix**: Used for interface names.
public interface IExampleInterface
{
    void DoSomething();
}

// 6. **T-prefix**: Used for generic type parameters.
public class GenericExample<T>
{
    public T Value { get; set; }
}

// 7. **VerbNoun**: Used for method names to indicate actions.
public class ActionExample
{
    public void SaveData() // VerbNoun format
    {
        Console.WriteLine("Data saved.");
    }
}

// 8. **Namespace Naming**: Use PascalCase and align with the project structure.
namespace MyProject.Utilities
{
    public class UtilityClass
    {
        public void PerformTask()
        {
            Console.WriteLine("Task performed.");
        }
    }
}

// 9. **Avoid Hungarian Notation**: Do not prefix variable names with type information (e.g., `strName` or `intCount`).

// 10. **File Naming**: Match the file name with the class name in PascalCase.