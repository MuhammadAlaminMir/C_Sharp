using System;

namespace C_Sharp_Fundamentals.Basic
{
    class JumpingControlStatements
    {
        static void Main(string[] args)
        {
            // Jumping Control Statements in C#
            // Jumping control statements are used to alter the flow of control in a program.
            // They allow you to jump to a specific part of the code, skip iterations, or exit loops.


            // 1. break Statement
            // The `break` statement is used to exit a loop or switch statement prematurely.
            // which means it will stop the execution of the loop or switch statement and transfer control to the next statement after the loop or switch.
            // It is useful when you want to terminate a loop based on a specific condition.
            Console.WriteLine("Example of break:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break; // Exit the loop when i equals 3
                }
                Console.WriteLine($"i = {i}");
            }

            // 2. continue Statement
            // The `continue` statement skips the current iteration of a loop and moves to the next iteration.
            // It is useful when you want to skip certain iterations based on a condition.
            Console.WriteLine("\nExample of continue:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue; // Skip the iteration when i equals 3
                }
                Console.WriteLine($"i = {i}");
            }


            // 3. goto Statement
            // The `goto` statement transfers control to a labeled statement.
            // It is used to jump to a specific part of the code, which can be useful in certain scenarios.
            // to use this at first we need to define a label using the colon (:) syntax.
            // then when we use the `goto` statement, it will jump to the label defined in the code. and continue executing from there.
            //if you level something at the top of the code and then after some line use the `goto` statement to jump to that label, it will act like a infinite loop.
            // The `goto` statement can make code harder to read and maintain, as it can create "spaghetti code" where the flow of control jumps around unpredictably.
            // It is generally discouraged in modern programming due to its potential to create unmanageable code flow.

            Console.WriteLine("\nExample of goto:");
            int number = 1;
        Start:
            Console.WriteLine($"Number = {number}");
            number++;
            if (number <= 3)
            {
                goto Start; // Jump back to the Start label
            }
        }

    }
}