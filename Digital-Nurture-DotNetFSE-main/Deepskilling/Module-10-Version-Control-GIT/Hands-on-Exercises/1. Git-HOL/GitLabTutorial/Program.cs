using System;
using System.Diagnostics;
using System.IO;

namespace GitLabTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console output to support UTF-8 symbols
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
            }
            catch {}

            bool running = true;
            while (running)
            {
                string[] options = {
                    "Run Lab Interactive Simulator (Safe Sandbox Mode)",
                    "Run Real Git System Automator (Configures actual Git & Notepad++)",
                    "Open Lab Guide HTML in Web Browser",
                    "Exit Application"
                };

                int selection = ConsoleHelper.ShowMenu("GIT & NOTEPAD++ HANDS-ON LAB TUTORIAL (C#)", options);

                switch (selection)
                {
                    case 0:
                        var simulator = new GitSimulator();
                        simulator.Run();
                        break;

                    case 1:
                        var automator = new RealGitAutomator();
                        automator.Run();
                        break;

                    case 2:
                        OpenLabGuideInBrowser();
                        break;

                    case 3:
                    case -1: // Escape key
                        running = false;
                        Console.Clear();
                        ConsoleHelper.WriteLineColored("Thank you for using the C# Git Lab Tutorial! Goodbye.", ConsoleColor.Cyan);
                        break;
                }
            }
        }

        private static void OpenLabGuideInBrowser()
        {
            Console.Clear();
            ConsoleHelper.DrawHeader("OPENING LAB GUIDE", ConsoleColor.Magenta);
            
            // Get path to HTML guide
            string baseDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\.."));
            string htmlPath = Path.Combine(baseDir, "Git_Lab_Guide.html");

            if (File.Exists(htmlPath))
            {
                Console.WriteLine($"Found HTML guide at: {htmlPath}");
                Console.WriteLine("Opening in your default browser...");
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = htmlPath,
                        UseShellExecute = true
                    });
                    ConsoleHelper.WriteLineColored("✓ Browser launched successfully.", ConsoleColor.Green);
                }
                catch (Exception ex)
                {
                    ConsoleHelper.WriteLineColored($"Failed to launch browser: {ex.Message}", ConsoleColor.Red);
                    Console.WriteLine($"You can open the file manually at: {htmlPath}");
                }
            }
            else
            {
                ConsoleHelper.WriteLineColored("Error: Git_Lab_Guide.html was not found in the workspace.", ConsoleColor.Red);
            }

            ConsoleHelper.WaitForKey();
        }
    }
}
