
// Tokens are the smallest elements of a program that are meaningful to the compiler. 
// They serve as the building blocks of a C# program. Each token has a specific purpose 
// and plays a role in defining the structure and behavior of the code.
// 
// The main types of tokens in C# are:
// 
// 1. Keywords
//    - Reserved words that have special meaning in C#.
//    - Purpose: Used to define the structure and behavior of the program.
//    - Example: 
//  abstract, as, base, bool, break, byte, case, catch, char, checked, class, const, continue, decimal, default, delegate, do, double, else, 
//enum, event, explicit, extern, false, finally, fixed, float, for, foreach, goto, if, implicit, in, int, interface, internal, is, lock, long,
// namespace, new, null, object, operator, out,
//  override, params, private, protected, public, readonly, ref, return, sbyte, sealed, short, sizeof, stackalloc, static, string, struct, switch, this, throw, true, try, typeof, 
// uint, ulong, unchecked, unsafe, ushort, using, virtual, void, volatile, while

// 2. Identifiers
//    - Names used to identify variables, methods, classes, etc.
//    - Purpose: Provide unique names for program elements.
//    - Example: number, myName, Tokens.
// 
// 3. Literals
//    - Fixed values assigned to variables.
//    - Purpose: Represent constant values in the code.
//    - Example: 10, "John", 3.14.
//    - Types of literals include: integer literals (e.g., 10), floating-point literals (e.g., 3.14), 
    // string literals (e.g., "Hello"), and boolean literals (e.g., true, false). character literals (e.g., 'A').
// 
// 4. Operators
//    - Symbols that perform operations on variables and values.
//    - Purpose: Enable computations and logical operations.
//    - Example: +, -, *, /, =, ==, <, >.
// 
// Additionally, there are other elements like punctuators (e.g., ;, {}) 
// and comments (e.g., //, /* */) that help structure and document the code.


using System;

namespace C_Sharp_Fundamentals
{
    class Tokens
    {
        static void Main(string[] args)
        {
            // 1. Keywords: Reserved words with special meaning in C#
            int number = 10; // 'int' is a keyword

            // 2. Identifiers: Names used to identify variables, methods, classes, etc.
            string myName = "John"; // 'myName' is an identifier

            // 3. Literals: Fixed values assigned to variables
            double pi = 3.14; // '3.14' is a literal

            // 4. Operators: Symbols that perform operations on variables and values
            int sum = number + 5; // '+' is an operator

            // 5. Punctuators: Symbols used for structuring code
            Console.WriteLine("Hello, World!"); // ';' and '{}' are punctuators

            // 6. Comments: Non-executable text for documentation
            // This is a single-line comment
            /* This is a multi-line comment */

            // Example Output
            Console.WriteLine($"Number: {number}, Name: {myName}, Pi: {pi}, Sum: {sum}");
        }
    }
}