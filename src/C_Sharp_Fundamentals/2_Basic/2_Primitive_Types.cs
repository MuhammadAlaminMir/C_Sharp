
using System;

namespace C_Sharp_Fundamentals.Basic
{
    class PrimitiveTypes
    {
        static void Main(string[] args)
        {

            // Primitive types are the most basic data types provided by a programming language.
            // They represent simple values such as numbers, characters, and booleans.
            // In C#, primitive types are value types and are stored directly in memory.
            // Examples include int, float, char, and bool.
            // primitive types strictly stores single value. 

            // Why do we need primitive types?
            // 1. Efficiency: Primitive types are lightweight and efficient for computation.
            // 2. Simplicity: They provide a straightforward way to represent basic data.
            // 3. Foundation: They serve as the building blocks for more complex data structures.

            //  if we try to same  large number in a small data type, it will overflow.
            //which means it will not give the correct value.
            // for example, if we try to assign a value greater than 255 to a byte variable, it will overflow and give an incorrect value.

            // Explanation of each data type:

            // 1. byte: 8-bit unsigned integer (0 to 255)
            // Used for small positive numbers. Commonly used in file I/O or binary data.
            byte byteValue = 255;
            Console.WriteLine($"byte: {byteValue}");

            // 2. sbyte: 8-bit signed integer (-128 to 127)
            // Similar to byte but allows negative values. Rarely used in modern applications.
            sbyte sbyteValue = -128;
            Console.WriteLine($"sbyte: {sbyteValue}");

            // 3. short: 16-bit signed integer (-32,768 to 32,767)
            // Suitable for small integer values. Often used in embedded systems.
            short shortValue = -32768;
            Console.WriteLine($"short: {shortValue}");

            // 4. ushort: 16-bit unsigned integer (0 to 65,535)
            // Used for non-negative small integers. Common in graphics programming.
            ushort ushortValue = 65535;
            Console.WriteLine($"ushort: {ushortValue}");

            // 5. int: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
            // Most commonly used integer type for general-purpose programming.
            int intValue = 2147483647;
            Console.WriteLine($"int: {intValue}");

            // 6. uint: 32-bit unsigned integer (0 to 4,294,967,295)
            // Used when negative values are not needed. Common in bitwise operations.
            uint uintValue = 4294967295;
            Console.WriteLine($"uint: {uintValue}");

            // 7. long: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
            // Used for large integer values. Suitable for scenarios like timestamps.
            long longValue = 9223372036854775807;
            Console.WriteLine($"long: {longValue}");

            // 8. ulong: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)
            // Used for very large positive numbers. Common in cryptography or file sizes.
            ulong ulongValue = 18446744073709551615;
            Console.WriteLine($"ulong: {ulongValue}");

            // 9. float: 32-bit single-precision floating point
            // Used for fractional numbers with less precision. Suitable for graphics or games.
            // Note: Use 'F' suffix to indicate a float literal.
            // float is less precise than double and should be used when memory is a concern.
            // float precision is 7 digits.
            float floatValue = 3.40282347E+38F;
            Console.WriteLine($"float: {floatValue}");

            // 10. double: 64-bit double-precision floating point
            // Used for fractional numbers with higher precision. Common in scientific calculations.
            // double precision is 15-16 digits.
            // use 'D' suffix to indicate a double literal. this is optional.
            double doubleValue = 1.7976931348623157E+308;
            Console.WriteLine($"double: {doubleValue}");

            // 11. decimal: 128-bit high-precision decimal (28-29 significant digits)
            // Used for financial and monetary calculations where precision is critical.
            // decimal precision is 28-29 digits.
            // use 'M' suffix to indicate a decimal literal.
            decimal decimalValue = 79228162514264337593543950335M;
            Console.WriteLine($"decimal: {decimalValue}");

            // 12. char: 16-bit Unicode character
            // Represents a single character. Useful for text processing.
            char charValue = 'A';
            Console.WriteLine($"char: {charValue}");

            // 13. bool: Boolean value (true or false)
            // Used for logical operations and decision-making.
            bool boolValue = true;
            Console.WriteLine($"bool: {boolValue}");

            // 14. string: Sequence of characters
            // Represents text. Immutable and widely used for storing and manipulating text.
            // for every character in string, 2 bytes are used.
            string stringValue = "Hello, World!";
            Console.WriteLine($"string: {stringValue}");

            // 15. object: Base type of all types in C#
            // Can hold any data type. Useful for generic programming but less efficient.
            object objectValue = "This is an object";
            Console.WriteLine($"object: {objectValue}");

            // Nullable types (e.g., int?)
            // Allows value types to represent null. Useful for optional values.
            int? nullableInt = null;
            Console.WriteLine($"Nullable int: {nullableInt}");

            // to know the default value of a variable, do like this:
            // console.WriteLine(default(int)); // 0
            // console.WriteLine(default(double)); // 0.0
        }
    }
}
