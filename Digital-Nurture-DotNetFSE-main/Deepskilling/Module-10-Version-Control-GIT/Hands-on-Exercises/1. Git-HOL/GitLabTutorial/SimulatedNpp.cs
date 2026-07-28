#pragma warning disable CA1416
using System;
using System.Collections.Generic;
using System.Text;

namespace GitLabTutorial
{
    public static class SimulatedNpp
    {
        public static string Open(string filename, string initialContent)
        {
            var lines = new List<string>();
            if (string.IsNullOrEmpty(initialContent))
            {
                lines.Add("");
            }
            else
            {
                var split = initialContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                lines.AddRange(split);
            }

            int cursorX = 0;
            int cursorY = 0;
            bool editing = true;
            bool saved = false;

            // Store original console settings
            ConsoleColor origBg = Console.BackgroundColor;
            ConsoleColor origFg = Console.ForegroundColor;
            bool origCursor = true;
            try { origCursor = Console.CursorVisible; } catch {}

            while (editing)
            {
                DrawEditor(filename, lines, cursorX, cursorY);
                Console.SetCursorPosition(Math.Min(8 + cursorX, Console.WindowWidth - 1), Math.Min(5 + cursorY, Console.WindowHeight - 1));
                try { Console.CursorVisible = true; } catch {}

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                
                // Check for Ctrl+S to Save and Exit
                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0 && keyInfo.Key == ConsoleKey.S)
                {
                    saved = true;
                    editing = false;
                    break;
                }
                // Check for Escape to cancel
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Close without saving? (Y/N)");
                    var choice = Console.ReadKey(true).Key;
                    if (choice == ConsoleKey.Y)
                    {
                        saved = false;
                        editing = false;
                    }
                    continue;
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cursorY > 0)
                        {
                            cursorY--;
                            cursorX = Math.Min(cursorX, lines[cursorY].Length);
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (cursorY < lines.Count - 1)
                        {
                            cursorY++;
                            cursorX = Math.Min(cursorX, lines[cursorY].Length);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (cursorX > 0)
                        {
                            cursorX--;
                        }
                        else if (cursorY > 0)
                        {
                            cursorY--;
                            cursorX = lines[cursorY].Length;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (cursorX < lines[cursorY].Length)
                        {
                            cursorX++;
                        }
                        else if (cursorY < lines.Count - 1)
                        {
                            cursorY++;
                            cursorX = 0;
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (cursorX > 0)
                        {
                            lines[cursorY] = lines[cursorY].Remove(cursorX - 1, 1);
                            cursorX--;
                        }
                        else if (cursorY > 0)
                        {
                            int prevLineLen = lines[cursorY - 1].Length;
                            lines[cursorY - 1] += lines[cursorY];
                            lines.RemoveAt(cursorY);
                            cursorY--;
                            cursorX = prevLineLen;
                        }
                        break;

                    case ConsoleKey.Delete:
                        if (cursorX < lines[cursorY].Length)
                        {
                            lines[cursorY] = lines[cursorY].Remove(cursorX, 1);
                        }
                        else if (cursorY < lines.Count - 1)
                        {
                            lines[cursorY] += lines[cursorY + 1];
                            lines.RemoveAt(cursorY + 1);
                        }
                        break;

                    case ConsoleKey.Enter:
                        string currentLine = lines[cursorY];
                        string firstHalf = currentLine.Substring(0, cursorX);
                        string secondHalf = currentLine.Substring(cursorX);
                        lines[cursorY] = firstHalf;
                        lines.Insert(cursorY + 1, secondHalf);
                        cursorY++;
                        cursorX = 0;
                        break;

                    case ConsoleKey.Home:
                        cursorX = 0;
                        break;

                    case ConsoleKey.End:
                        cursorX = lines[cursorY].Length;
                        break;

                    default:
                        if (keyInfo.KeyChar >= 32 && keyInfo.KeyChar <= 126) // printable chars
                        {
                            lines[cursorY] = lines[cursorY].Insert(cursorX, keyInfo.KeyChar.ToString());
                            cursorX++;
                        }
                        break;
                }
            }

            // Restore console state
            Console.BackgroundColor = origBg;
            Console.ForegroundColor = origFg;
            try { Console.CursorVisible = origCursor; } catch {}
            Console.Clear();

            return saved ? string.Join("\n", lines) : initialContent;
        }

        private static void DrawEditor(string filename, List<string> lines, int cursorX, int cursorY)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // 1. Notepad++ Header bar
            Console.SetCursorPosition(0, 0);
            string header = $" 📝 {filename} - Notepad++ (SIMULATED)";
            Console.Write(header.PadRight(Console.WindowWidth));

            // 2. Menu Bar
            Console.SetCursorPosition(0, 1);
            Console.Write(" File  Edit  Search  View  Encoding  Language  Settings  Tools  Macro  Run  Plugins  Window  ?");
            Console.SetCursorPosition(0, 2);
            Console.Write(new string('─', Console.WindowWidth));

            // 3. Tab bar
            Console.SetCursorPosition(0, 3);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($" 📂 [ {filename} ] ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(new string(' ', Console.WindowWidth - Console.CursorLeft));
            Console.SetCursorPosition(0, 4);
            Console.Write(new string('═', Console.WindowWidth));

            // 4. Content Area
            int viewHeight = Console.WindowHeight - 7;
            for (int i = 0; i < viewHeight; i++)
            {
                Console.SetCursorPosition(0, 5 + i);
                if (i < lines.Count)
                {
                    // Line number
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" {i + 1,4} | ");

                    // Line content
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    
                    string lineStr = lines[i];
                    // Strip/pad line to fit window width
                    int maxContentWidth = Console.WindowWidth - 8;
                    if (lineStr.Length > maxContentWidth)
                    {
                        lineStr = lineStr.Substring(0, maxContentWidth);
                    }
                    else
                    {
                        lineStr = lineStr.PadRight(maxContentWidth);
                    }
                    Console.Write(lineStr);
                }
                else
                {
                    // Empty background
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("       | ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(new string(' ', Console.WindowWidth - 9));
                }
            }

            // 5. Status bar
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(new string('─', Console.WindowWidth));
            
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string status = $" Ln: {cursorY + 1}  Col: {cursorX + 1}     [Ctrl+S: Save & Exit] [Esc: Cancel]";
            Console.Write(status.PadRight(Console.WindowWidth));
        }
    }
}
