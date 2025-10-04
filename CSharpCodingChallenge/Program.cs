using System;
using static MyNameSpace.MyMethodClass; // Import static methods

class Program
{
    static void Main(string[] args)
    {
        /// Test cases for oldPhonePad 
        Console.WriteLine("Testing OldPhonePad conversion:");

        // Example test cases
        Console.WriteLine(OldPhonePad("33#")); // Output: E
        Console.WriteLine(OldPhonePad("227*#")); // Output: B
        Console.WriteLine(OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhonePad("8 88777444666*664#")); // Output: ????
    } 
}