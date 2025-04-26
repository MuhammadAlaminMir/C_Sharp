// The Console class in C# is part of the System namespace and is used for basic input and output operations in console applications.
// It provides methods and properties to interact with the console window, enabling developers to read input from the user and display output.

// Purpose:
// The primary purpose of the Console class is to facilitate text-based interaction between the user and the application in a console environment.

// Features:
// 1. Input Handling:
//    - Console.ReadLine(): Reads a line of text input from the user.
//    - Console.Readline(): accepts a string input from the user and returns it as a string.
//    - it always returns a string value, even if the user enters a number or other data type.
//    - Console.ReadKey(): Captures a single key press from the user.
//    - Console.Read(): Reads the next character from the input stream.

// 2. Output Handling:
//    - Console.Write(): Writes text to the console without a newline.
//    - Console.WriteLine(): Writes text to the console also moves the cursor to the next line.
//    -  (e.g., Console.WriteLine("Hello, {0}!", name)).

// 3. Console Customization:
//    - Console.ForegroundColor: Sets the text color in the console.
//    - Console.BackgroundColor: Sets the background color of the console.
//    - Console.ResetColor(): Resets the console colors to their defaults.

// 4. Cursor and Buffer Management:
//    - Console.SetCursorPosition(): Sets the position of the cursor in the console window.
//    - Console.Clear(): Clears the console window.
//    - Console.BufferWidth and Console.BufferHeight: Manage the size of the console buffer.

// 5. Error Output Stream:
//    - Console.Error: Provides a TextWriter for error messages, allowing separation of standard output and error output.

// Important Features:
// - Console.ReadLine() and Console.WriteLine() are the most commonly used methods for basic input and output.
// - Customizing the console appearance using ForegroundColor and BackgroundColor enhances user experience.
// - The ability to handle formatted output makes it easier to display structured information.
// - Console.Clear() is useful for refreshing the console during interactive applications.

// The Console class is a fundamental part of C# programming for creating command-line applications and is widely used for learning and debugging purposes.