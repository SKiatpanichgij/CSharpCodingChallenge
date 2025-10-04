using System.Text;

namespace MyNameSpace
{
    public class MyMethodClass
    {
        /// <summary>
        /// Decodes an old-style phone pad sequence into a string.
        /// The sequence stops at the first '#' character.
        /// '*' clears the current sequence.
        /// ' ' (space) finalizes the current character and resets the count.
        /// </summary>
        /// <param name="input">The string of button presses.</param>
        /// <returns>The decoded string.</returns> 
        public static string OldPhonePad(string input)
        {
            // The first element is for '0' (space), the second for '1' and so on 
            string[] keypad = { " ", "&'(\"", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            var result = new StringBuilder();
            int count = 0;
            char lastChar = '\0';

            // Local function to append the charater
            void AppendChar()
            {
                if (lastChar >= '0' && count > 0)
                {
                    int index = lastChar - '0';
                    if (index >= 0 && index < keypad.Length && keypad[index].Length > 0)
                    {
                        result.Append(keypad[index][(count - 1) % keypad[index].Length]);
                    }
                }
            }

            foreach (char c in input)
            {
                // 1. Termination : Stop processing the sequence 
                if (c == '#') break;

                // 2. Clear : Reset current sequence
                if (c == '*')
                {
                    count = 0;
                    lastChar = '\0';
                    continue;
                }

                // 3. Space Finalze the current character character and move to the next  
                if (c == ' ')
                {
                    AppendChar();
                    lastChar = '\0';
                    count = 0;
                    continue;                    
                }

                // 4. Digit Input      
                if (c == lastChar)
                {
                    count++;
                }
                else
                {
                    AppendChar();
                    lastChar = c;
                    count = 1;
                }
            }

            // 5. End of input: 
            AppendChar();

            return result.ToString();
        }
    }
}