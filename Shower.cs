using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixPre
{
    class Shower
    {
        private int heighthWindow;
        private int widthWindow;
        private int[] widthPosOne;
        private int[] widthPosSec;

        private readonly Symbol symbol = new Symbol();

        public Shower(int width, int height)
        {            
            heighthWindow = height;
            widthWindow = width;

            int h1 = heighthWindow / 2;
            int h2 = heighthWindow / 4;

            widthPosOne = new int[widthWindow];
            widthPosSec = new int[widthWindow];

            for (int i = 0; i < widthWindow; i++)
            {
                widthPosOne[i] = Symbol.randGen.Next(heighthWindow);

                int k = (i % 11 != 10) ? 2 : 1;
                int min = h2 * k;
                int max = h1 * k;
                widthPosSec[i] = Symbol.randGen.Next(min, max);
            }
        }
        public Shower() : this((Console.WindowWidth - 1), Console.WindowHeight) { }

        public void ShowSymbol()
        {
            for (int i = 0; i < widthWindow; i++)
            {            
                if (widthPosOne[i] < 10)
                {
                    symbol.ShowSymbol(i, widthPosOne[i], ConsoleColor.DarkGreen);
                }
                else if (widthPosOne[i] < 25)
                {
                    symbol.ShowSymbol(i, widthPosOne[i]);
                }
                else
                {
                    symbol.ShowSymbol(i, widthPosOne[i], ConsoleColor.Gray);
                }
                //move on height pos
                widthPosOne[i] = CheckNextPos(widthPosOne[i] + 1, heighthWindow);

                int next = widthPosOne[i] - widthPosSec[i];
                int nextPos = CheckNextPos(next, heighthWindow);
                symbol.ShowSpaceSymbol(i, nextPos);
            }
        }

        private int CheckNextPos(int next, int height) =>
            (next % height) < 0 ? next + height : next;
    }
}
