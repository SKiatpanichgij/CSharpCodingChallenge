using System;
using System.Collections.Generic;
using System.Text;

namespace MyNameSpace
{
    public class MyMethodClass
    {
        public static string OldPhonePad(string input)
        {
            string[] keypad = { " ", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            var result = new StringBuilder();
            int count = 0;
            char lastChar = '\0';

            void AppendChar()
            {
                if (lastChar >= '0' && lastChar <= '9' && count > 0)
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
                if (c == '#') break;

                if (c == '*')
                {
                    count = 0;
                    lastChar = '\0';
                    continue;
                }

                if (c == ' ')
                {
                    AppendChar();
                    lastChar = '\0';
                    count = 0;
                }
                else if (c == lastChar)
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

            AppendChar();

            return result.ToString();
        }
    }
}