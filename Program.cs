using MatrixPre;
using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shower shower = new Shower();

            Console.Clear();

            int ms = 0;
            while(true)
            {
                DateTime time = DateTime.Now;

                shower.ShowSymbol();

                ms = 200 - (int)(DateTime.Now - time).TotalMilliseconds;
                if (ms > 0) System.Threading.Thread.Sleep(ms);
            }
        }
    }
}