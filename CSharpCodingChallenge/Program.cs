using System;

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

    public static string OldPhonePad(string input)
    {
        string[] keypad = { " ", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
        string result = "";
        int count = 0;
        char lastChar = '\0';

        foreach (char c in input)
        {
            if (c == '#') break;

            if (c == '*')
            {
                count = 0; // Reset count when deleting
                lastChar = '\0'; // Reset lastChar when deleting
                continue;
            }

            if (c == ' ')
            {
                if (lastChar != '\0' && count > 0)
                {
                    int index = lastChar - '0';
                    if (index >= 0 && index < keypad.Length)
                    {
                        result += keypad[index][(count - 1) % keypad[index].Length];
                    }
                }
                lastChar = c;
                count = 0; 
            }
            else if (c == lastChar)
            {
                count++;
            }
            else
            {
                if (lastChar != '\0' && count > 0)
                {
                    int index = lastChar - '0';
                    if (index >= 0 && index < keypad.Length)
                    {
                        result += keypad[index][(count - 1) % keypad[index].Length];
                    }
                }
                lastChar = c;
                count = 1;
            }
        }

        if (lastChar != '\0' && count > 0)
        {
            int index = lastChar - '0';
            if (index >= 0 && index < keypad.Length)
            {
                result += keypad[index][(count - 1) % keypad[index].Length];
            }
        }

        return result;
    }
}