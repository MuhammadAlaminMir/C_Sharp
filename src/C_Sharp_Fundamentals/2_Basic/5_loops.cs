
using System;

namespace C_Sharp_Fundamentals.Basic
{
    class LoopsDemo
    {
        static void Main(string[] args)
        {
            // 1. For Loop
            // Executes a block of code a specific number of times.
            // The for loop consists of three parts: initialization, condition, and increment/decrement.
            // The initialization is executed once at the beginning, the condition is checked before each iteration,
            // and the increment/decrement is executed after each iteration.
            // it is helpfu for iterating over a range of values or a collection.
            Console.WriteLine("For Loop:");
            for (int i = 0; i < 5; i++) // Initialization, Condition, Increment
            {
                Console.WriteLine($"Iteration {i}");
            }

            // 2. While Loop
            // Executes a block of code as long as the condition is true.
            // The condition is checked before each iteration, and if it is true, the block of code executes.
            // It is useful when the number of iterations is not known in advance.
            // it will be good to add an extra condition to avoid infinite loop.
            // For example, if the condition is always true, the loop will run indefinitely.
            Console.WriteLine("\nWhile Loop:");
            int count = 0;
            while (count < 5 && count >= 0) // Conditions
            {
                Console.WriteLine($"Count: {count}");
                count++; // Increment
            }

            // 3. Do-While Loop
            // Executes the block of code at least once, then repeats as long as the condition is true.
            // it is similar to the while loop, but the condition is checked after the block of code executes.
            // it is useful when you want to ensure that the block of code runs at least once.
            Console.WriteLine("\nDo-While Loop:");
            int number = 0;
            do
            {
                Console.WriteLine($"Number: {number}");
                number++; // Increment
            } while (number < 5); // Condition

            // 4. Foreach Loop
            // Iterates over a collection or array.
            // It is useful for iterating through elements without needing to manage the index manually.
            // The foreach loop is read-only, meaning you cannot modify the collection while iterating through it.
            // It is useful for collections like arrays, lists, and dictionaries.
            
            Console.WriteLine("\nForeach Loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits) // Iterates through each element
            {
                Console.WriteLine($"Fruit: {fruit}");
            }

            // 5. Nested Loops
            // A loop inside another loop.
            // The outer loop runs first, and for each iteration of the outer loop, the inner loop runs completely.
            // It is useful for working with multi-dimensional arrays or performing complex iterations.
            // but it can lead to performance issues if not used carefully.
            Console.WriteLine("\nNested Loops:");
            for (int i = 1; i <= 3; i++) // Outer loop
            {
                for (int j = 1; j <= 3; j++) // Inner loop
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                }
            }


            // 6 Infinite Loop
            // A loop that runs indefinitely (use with caution).
            // if the condition is always true, the loop will run forever.
            // This can lead to performance issues or application crashes if not handled properly.
            /*
            Console.WriteLine("\nInfinite Loop:");
            while (true)
            {
                Console.WriteLine("This will run forever!");
            }
            */

           
        }
    }
}