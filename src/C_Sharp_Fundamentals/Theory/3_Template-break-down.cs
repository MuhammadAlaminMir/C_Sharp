// This is a single-line comment. It is used to explain the code and is ignored by the compiler.

using System;
// The 'using' directive allows us to include namespaces. 
// 'System' is a namespace that contains fundamental classes like Console, which we use for input/output.

namespace C_Sharp_Fundamentals
// A namespace is a container for classes and other namespaces. 
// the goal of namespaces is to provide a way to group related classes that are meant for specific purposes.
// It helps organize code and avoid name conflicts.

// dot is also known as the member access operator. It is used to access members of a namespace, class, or structure. 
//its specifics that right side is a member of the left side one.
// like C_Sharp_Fundamentals.Program
// for example, C_Sharp_Fundamentals is a namespace and Program is a class inside that

{
    //template break down
    class Program // class is a type of data structure that contains data and methods.
    // A class is a blueprint / model for creating objects.
    // A object is a small unit (entity) in the program that represents a real-world person or thing.
    // 'Program' is the name of the class, and it contains the code to be executed.

    {
        static void Main(string[] args)
        // The 'Main' method is the entry point of a C# program. 
        // method is a collection of statements that perform a specific task.
        // 'static' means it belongs to the class and not an instance of the class.
        // 'void' means it does not return any value.
        // 'string[] args' is an array of strings that can hold command-line arguments.

        {
            Console.WriteLine("Hello, World!");
            // 'Console.WriteLine' is used to print text to the console.
            // 'Hello, World!' is the text being printed.
        }
    }
}