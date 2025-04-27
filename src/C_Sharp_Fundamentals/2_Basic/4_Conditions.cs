
using System;

namespace C_Sharp_Fundamentals.Basic
{
    class Conditions
    {
        static void Main(string[] args)
        {
            // Conditional Statements in C#
            // Conditional statements are used to perform different actions based on different conditions.
            // They allow you to control the flow of your program based on certain conditions.
            // The most common conditional statements in C# are `if`, `else if`, `else`, and `switch`.

            // 1. if Statement
            // The `if` statement executes a block of code if the condition is true.
            // It can be used to check a single condition.

            int number = 10;
            if (number > 5)
            {
                Console.WriteLine("The number is greater than 5.");
            }

            // 2. if-else Statement
            // The `if-else` statement provides an alternative block of code if the condition is false.
            // if the condition is true, the first block executes; otherwise, the second block executes.
            if (number < 5)
            {
                Console.WriteLine("The number is less than 5.");
            }
            else
            {
                Console.WriteLine("The number is not less than 5.");
            }

            // 3. else if 
            // The `else if`  allows multiple conditions to be checked sequentially.
            // at first `if` condition is checked, if it is false, the next `else if` condition is checked.
            // If all conditions are false, the `else` block executes.
            if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else if (number > 0 && number <= 10)
            {
                Console.WriteLine("The number is between 1 and 10.");
            }
            else
            {
                Console.WriteLine("The number is greater than 10.");
            }

            // 4. Nested if
            // we can nest `if` statements inside other `if` statements.
            // This is useful for checking multiple conditions in a hierarchical manner.
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is positive and even.");
                }
                else
                {
                    Console.WriteLine("The number is positive and odd.");
                }
            }

            // 5. switch Statement
            // The `switch` statement is used to execute one block of code from multiple options.
            // It is more readable than multiple `if-else` statements when checking the same variable against different values.
            // it should be start with `case` keyword and end with `break` keyword.
            // if we don't use `break` keyword, the next case will also be executed
            // if no `case` matches, the `default` block executes.
            // The `default` block is optional.
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }

            // 6. Ternary Operator
            // The ternary operator is a shorthand for `if-else`.
            // It takes three operands: a condition, a result if true, and a result if false.
            // It is often used for simple conditions and assignments.
            string result = (number > 5) ? "Greater than 5" : "5 or less";
            Console.WriteLine(result);

            // 7. Logical Operators in Conditions
            // Logical operators like && (AND), || (OR), and ! (NOT) are used to combine or negate conditions.
            // when we want to check multiple conditions at once, we can use logical operators.
            // The `&&` operator returns true if both conditions are true.
            // The `||` operator returns true if at least one condition is true.
            // The `!` operator negates the condition, returning true if the condition is false.
            bool isAdult = true;
            bool hasID = false;
            if (isAdult && hasID)
            {
                Console.WriteLine("Access granted.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }




            // 8. switch Expression (C# 8.0+)
            // A more concise way to write switch statements.
            // unlike the traditional switch statement, the switch expression returns a value.
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Other day"
            };
            Console.WriteLine(dayName);

            // in this example, we are using the switch expression to assign a value to the `dayName` variable based on the value of `day`.
            // The `=>` operator is used to define the result for each case.
            //if the value of `day` is 1, `dayName` will be "Monday", if it's 2, it will be "Tuesday", and so on.
            // The `_` case acts as a default case, similar to the `default` keyword in the traditional switch statement.

        }
    }
}