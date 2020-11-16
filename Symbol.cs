using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixPre
{
    class Symbol
    {
        public static Random randGen = new Random();
        
        //Generate random cymbol
        private char GetSymbol()
        {
            int t = randGen.Next(10);
            if (t <= 2)
                return (char)('0' + randGen.Next(10));
            else if (t <= 4)
                return (char)('a' + randGen.Next(27));
            else if (t <= 6)
                return (char)('A' + randGen.Next(27));
            else
                return (char)(randGen.Next(32, 255));
        }

        public void ShowSymbol(int left, int top, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSymbol());
        }
        public void ShowSpaceSymbol(int left, int top, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSymbol());
        }
    }
}
