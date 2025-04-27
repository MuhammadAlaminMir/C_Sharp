// File: 3_Operators.cs

using System;

namespace C_Sharp_Fundamentals.Basic
{
    class Operators
    {
        static void Main(string[] args)
        {

            // Operator Precedence 
            // Operator precedence determines the order in which operations execute frist.
            // For example, in the expression 2 + 3 * 4, multiplication has a higher precedence than addition,
            // the precedence:
            // 1.  parentheses and postfix (), [], {}, ++ (increment), -- (decrement)
            // 2.  unary +, - (unary plus and minus), ! (logical NOT), ~ (bitwise NOT) 
            // 3.  multiplicative *, /, % (multiplication, division, modulus)
            // 4.  additive +, - (addition and subtraction)
            // 5.  shift <<, >> (left and right shift)
            // 6.  relational <, >, <=, >= (less than, greater than, less than or equal to, greater than or equal to)
            // 7.  equality ==, != (equality and inequality)
            // 8.  logical and &&
            // 9.  logical or || (logical OR)
            // 10. conditional ? : (ternary operator)
            // 11. assignment =, +=, -=, *=, /=, %= (assignment operators)

            // Operators are used to perform operations on variables and values.
           

            // Arithmetic Operators
            int a = 10, b = 5;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {a} + {b} = {a + b}"); // Adds two numbers
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}"); // Subtracts second number from the first
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}"); // Multiplies two numbers
            Console.WriteLine($"Division: {a} / {b} = {a / b}"); // Divides first number by the second
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}"); // Remainder of division

            // Assignment Operators
            Console.WriteLine("\nAssignment Operators:");
            int e = 10;
            Console.WriteLine($"e = {e}"); // Assigns value to e
            e += 5; // Adds 5 to e

            Console.WriteLine($"e += 5: {e}");
            e -= 3; // Subtracts 3 from e

            Console.WriteLine($"e -= 3: {e}");
            e *= 2; // Multiplies e by 2

            Console.WriteLine($"e *= 2: {e}");
            e /= 4; // Divides e by 4
            Console.WriteLine($"e /= 4: {e}");

            e %= 3; // Modulus operation on e
            Console.WriteLine($"e %= 3: {e}");

            // Relational (Comparison) Operators
            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine($"{a} > {b} = {a > b}"); // Checks if a is greater than b
            Console.WriteLine($"{a} < {b} = {a < b}"); // Checks if a is less than b
            Console.WriteLine($"{a} >= {b} = {a >= b}"); // Checks if a is greater than or equal to b
            Console.WriteLine($"{a} <= {b} = {a <= b}"); // Checks if a is less than or equal to b
            Console.WriteLine($"{a} == {b} = {a == b}"); // Checks if a is equal to b
            Console.WriteLine($"{a} != {b} = {a != b}"); // Checks if a is not equal to b


            // Logical Operators
            bool x = true, y = false;
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"AND: {x} && {y} = {x && y}"); // Logical AND
            Console.WriteLine($"OR: {x} || {y} = {x || y}"); // Logical OR
            Console.WriteLine($"NOT: !{x} = {!x}"); // Logical NOT

            // Bitwise Operators
            int c = 6, d = 3; // Binary: c = 110, d = 011
            Console.WriteLine("\nBitwise Operators:");
            Console.WriteLine($"AND: {c} & {d} = {c & d}"); // Bitwise AND
            Console.WriteLine($"OR: {c} | {d} = {c | d}"); // Bitwise OR
            Console.WriteLine($"XOR: {c} ^ {d} = {c ^ d}"); // Bitwise XOR
            Console.WriteLine($"Left Shift: {c} << 1 = {c << 1}"); // Left shift
            Console.WriteLine($"Right Shift: {c} >> 1 = {c >> 1}"); // Right shift


            // Concatenation Operator
            Console.WriteLine("\nConcatenation Operator:");
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // Combines two strings
            Console.WriteLine($"Full Name: {fullName}");

            // Increment and Decrement Operators or  Unary Operators
            Console.WriteLine("\nIncrement and Decrement Operators:");
            int num = 10;
            Console.WriteLine($"Initial value of num: {num}");

            // Post-increment
            Console.WriteLine($"Post-increment: num++ = {num++} (num becomes {num})");

            // Pre-increment
            Console.WriteLine($"Pre-increment: ++num = {++num}");

            // Post-decrement
            Console.WriteLine($"Post-decrement: num-- = {num--} (num becomes {num})");

            // Pre-decrement
            Console.WriteLine($"Pre-decrement: --num = {--num}");


            // Ternary Operator
            Console.WriteLine("\nTernary Operator:");
            int g = 10, h = 20;
            string result = g > h ? "g is greater" : "h is greater"; // Conditional operator
            Console.WriteLine($"Ternary Result: {result}");

            // Null-Coalescing Operator
            // ?? : Returns the left-hand operand if it is not null; otherwise, it returns the right operand.
            Console.WriteLine("\nNull-Coalescing Operator:");
            string str = null;
            string defaultStr = "Default Value";
            Console.WriteLine($"str ?? defaultStr = {str ?? defaultStr}"); // Returns defaultStr if str is null

            // Null-Coalescing Assignment Operator
            // ??= : Assigns the right-hand operand to the left-hand operand if the left is null.
            Console.WriteLine("\nNull-Coalescing Assignment Operator:");
            string nullableStr = null;
            nullableStr ??= "Assigned Value"; // Assigns value if null
            Console.WriteLine($"nullableStr ??= 'Assigned Value': {nullableStr}");

            // Type Testing and Casting Operators
            // is: Checks if an object is of a specific type
            // as: Casts an object to a specific type, returns null if the cast fails.
            Console.WriteLine("\nType Testing and Casting Operators:");
            object obj = "Hello, World!";
            if (!(obj is string)) // Checks if obj is of type string
            {
                string castedStr = obj as string; // Casts obj to string
                Console.WriteLine($"Casted String: {castedStr}");
            }
        }
    }
}
