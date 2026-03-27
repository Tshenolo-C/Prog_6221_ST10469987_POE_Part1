using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prog_6221_ST10469987_POE_Part1
{
    internal class ConsoleUI
    {
        public static void ConColour(string text, ConsoleColor colour, bool newLine = true)
        {
            Console.ForegroundColor = colour;
            if (newLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(text);
                Console.ResetColor();
            }

        }

        public static void Writing(string text, ConsoleColor colour = ConsoleColor.Gray, int Delayms = 16)
        {
            Console.ForegroundColor = colour;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(Delayms);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Divider(char symbol = '-', int width = 60, ConsoleColor colour = ConsoleColor.DarkGreen)
        {
            ConColour(new string(symbol, width), colour);
        }

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
                             .-------.
                            /         \
                           |           |
                           |           |
                            \         /
                    .-------'-........'------.
                    |  .-------------------. |
                    | | .----------------. | |
                    | | |                | | |
                    | | |       ()       | | |
                    | | |       ||       | | |
                    | | |       ||       | | |
                    | | '----------------' | |
                    | '-------------------'  |
                    '------------------------'  
            ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
               +-------------------------------------------------+
               |       CYBERSECURITY AWARENESS BOT               |
               |         Your Digital Safety Guide               |
               +-------------------------------------------------+
            ");
            Console.ResetColor();
        }

        public static void Header(string title) 
        {
            Console.WriteLine();
            Divider('-', 60, ConsoleColor.DarkGreen);
            ConColour(" " + title, ConsoleColor.Green);
            Divider('-', 60, ConsoleColor.DarkGreen);
        }


        public static void Botname()
        {
            ConColour("Cyber Bot >>", ConsoleColor.DarkGreen, newLine: false);

        }

        public static void Userprompt(string userName)
        {
            ConColour("\n" + userName + ">>", ConsoleColor.Red, newLine: false);
        }

    }
}
