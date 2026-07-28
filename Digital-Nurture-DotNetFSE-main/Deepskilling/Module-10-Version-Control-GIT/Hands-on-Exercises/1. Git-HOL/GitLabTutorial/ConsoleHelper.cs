#pragma warning disable CA1416
using System;
using System.Threading;

namespace GitLabTutorial
{
    public static class ConsoleHelper
    {
        public static void WriteColored(string text, ConsoleColor color)
        {
            var prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = prev;
        }

        public static void WriteLineColored(string text, ConsoleColor color)
        {
            var prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = prev;
        }

        public static void Typewriter(string text, int delayMs = 15)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                if (c != ' ' && c != '\n')
                {
                    Thread.Sleep(delayMs);
                }
            }
            Console.WriteLine();
        }

        public static void DrawHeader(string title, ConsoleColor borderColors = ConsoleColor.Blue)
        {
            int width = Math.Min(Console.WindowWidth - 4, 80);
            if (width < 30) width = 50;

            string horizontalBorder = new string('═', width - 2);
            WriteLineColored($"╔{horizontalBorder}╗", borderColors);
            
            // Center title
            int spaces = (width - 2 - title.Length) / 2;
            string leftSpace = new string(' ', Math.Max(0, spaces));
            string rightSpace = new string(' ', Math.Max(0, width - 2 - title.Length - leftSpace.Length));
            
            WriteColored("║", borderColors);
            Console.Write($"{leftSpace}{title}{rightSpace}");
            WriteLineColored("║", borderColors);
            
            WriteLineColored($"╚{horizontalBorder}╝", borderColors);
        }

        public static void DrawDivider(ConsoleColor color = ConsoleColor.DarkGray)
        {
            int width = Math.Min(Console.WindowWidth - 4, 80);
            if (width < 30) width = 50;
            WriteLineColored(new string('─', width), color);
        }

        public static int ShowMenu(string title, string[] options)
        {
            int selectedIndex = 0;
            ConsoleKey key;
            
            // Hide cursor
            bool originalCursorVisible = true;
            try { originalCursorVisible = Console.CursorVisible; Console.CursorVisible = false; } catch {}

            do
            {
                Console.Clear();
                DrawHeader(title, ConsoleColor.Magenta);
                Console.WriteLine();
                Console.WriteLine(" Use Up/Down Arrow keys to navigate and press Enter to select:");
                Console.WriteLine();

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        WriteColored("  ► ", ConsoleColor.Green);
                        WriteLineColored(options[i], ConsoleColor.Green);
                    }
                    else
                    {
                        Console.WriteLine($"    {options[i]}");
                    }
                }

                Console.WriteLine();
                DrawDivider();
                WriteLineColored(" Press Escape to go back/exit if applicable.", ConsoleColor.DarkGray);

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % options.Length;
                }
                else if (key == ConsoleKey.Escape)
                {
                    try { Console.CursorVisible = originalCursorVisible; } catch {}
                    return -1;
                }

            } while (key != ConsoleKey.Enter);

            try { Console.CursorVisible = originalCursorVisible; } catch {}
            return selectedIndex;
        }

        public static void WaitForKey()
        {
            WriteLineColored("\nPress any key to continue...", ConsoleColor.DarkGray);
            Console.ReadKey(true);
        }
    }
}
