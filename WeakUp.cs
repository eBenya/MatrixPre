using System;

namespace Les1_WeakUppNeo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int delay = 500;                        //delay в ms
            const int MIN_DELAY_COUNT = 100;		//bottom and
            const int MAX_DELAY_COUNT = 1000;		//upper bounds of delay

            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.Green;

            string[] s = new string[4];				//array of string, for printing to console
            s[0] = "Weak up, Neo...\n";
            s[1] = "The Matrix has you...\n";
            s[2] = "Follow the white rabbit.\n";
            s[3] = "Knock, knock, Neo.\n";

            for (int i = 0; i < s.Length; i++)
            {
                foreach (char ch in s[i])
                {
                    delay = rnd.Next(MIN_DELAY_COUNT, MAX_DELAY_COUNT);
                    Console.Write(ch);
                    System.Threading.Thread.Sleep(delay);
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }

            Console.ResetColor();
        }
    }
}