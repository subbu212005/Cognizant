using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace GitLabTutorial
{
    public class RealGitAutomator
    {
        private string _username = "Subrahmanyeswara";
        private string _email = "yedula2005@gmail.com";
        private string _repoPath = "";

        public void Run()
        {
            Console.Clear();
            ConsoleHelper.DrawHeader("REAL GIT SYSTEM AUTOMATOR", ConsoleColor.Red);
            Console.WriteLine("This module will execute actual processes on your machine.");
            Console.WriteLine("It will:");
            Console.WriteLine(" 1. Verify and set global Git configurations.");
            Console.WriteLine(" 2. Search for Notepad++ and add it to your User PATH variable if needed.");
            Console.WriteLine(" 3. Set Notepad++ as the default Git editor.");
            Console.WriteLine(" 4. Create and initialize a local 'GitDemo' repository.");
            Console.WriteLine(" 5. Create 'welcome.txt', stage, and prompt a real Git commit.");
            ConsoleHelper.DrawDivider();
            
            ConsoleHelper.WriteColored("Do you want to proceed? (Y/N): ", ConsoleColor.Yellow);
            var confirm = Console.ReadKey(true).Key;
            if (confirm != ConsoleKey.Y) return;

            Console.WriteLine("\nStarting Automation...\n");

            // Step 1: Check Git Client
            if (!CheckGitInstalled())
            {
                ConsoleHelper.WriteLineColored("Error: Git is not installed or not in your system PATH.", ConsoleColor.Red);
                ConsoleHelper.WriteLineColored("Please install Git Bash client before running this script.", ConsoleColor.Yellow);
                ConsoleHelper.WaitForKey();
                return;
            }

            // Step 2: Set credentials
            Console.WriteLine("Step 1/6: Setting Global Git Configurations (user.name and user.email)...");
            RunCommand("git", $"config --global user.name \"{_username}\"");
            RunCommand("git", $"config --global user.email \"{_email}\"");
            ConsoleHelper.WriteLineColored("✓ Credentials configured.", ConsoleColor.Green);
            
            // Step 3: Verify credentials
            Console.WriteLine("\nStep 2/6: Verifying Git Config...");
            string configList = RunCommandWithOutput("git", "config --list");
            Console.WriteLine("Current global config excerpt:");
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);
            Console.WriteLine(string.Join("\n", configList.Split('\n').Where(l => l.Contains("user.name") || l.Contains("user.email") || l.Contains("editor"))));
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);

            // Step 4: Locate & Config Notepad++
            Console.WriteLine("\nStep 3/6: Checking Notepad++ Installation...");
            string? nppPath = LocateNotepadPlusPlus();
            if (string.IsNullOrEmpty(nppPath))
            {
                ConsoleHelper.WriteLineColored("Notepad++ could not be found automatically in standard locations.", ConsoleColor.Yellow);
                Console.WriteLine("We recommend installing Notepad++ to complete the lab's editor integration.");
                Console.WriteLine("Skipping Notepad++ configuration. Git will use default editor.");
            }
            else
            {
                ConsoleHelper.WriteLineColored($"✓ Notepad++ found at: {nppPath}", ConsoleColor.Green);
                string? nppDir = Path.GetDirectoryName(nppPath);
                
                // Add to Environment path if not present
                if (!string.IsNullOrEmpty(nppDir))
                {
                    CheckAndAddToPath(nppDir);
                }

                // Config editor in git
                Console.WriteLine("Setting global editor to notepad++...");
                RunCommand("git", "config --global core.editor \"notepad++\"");
                ConsoleHelper.WriteLineColored("✓ Global editor configured.", ConsoleColor.Green);

                Console.WriteLine("Launching notepad++ to test PATH (notepad++ will open). Close it to continue...");
                RunCommand("cmd.exe", "/c notepad++");
            }

            // Step 5: Initialize GitDemo directory
            Console.WriteLine("\nStep 4/6: Creating 'GitDemo' Repository...");
            // Use parent directory of this console app for GitDemo
            string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\.."));
            _repoPath = Path.Combine(baseDirectory, "GitDemo");
            
            if (Directory.Exists(_repoPath))
            {
                Console.WriteLine($"Directory '{_repoPath}' already exists. Reinitializing...");
            }
            else
            {
                Directory.CreateDirectory(_repoPath);
                Console.WriteLine($"Created folder: {_repoPath}");
            }

            string initOutput = RunCommandWithOutput("git", "init", _repoPath);
            Console.WriteLine(initOutput.Trim());

            // Step 6: Create welcome.txt and verify
            Console.WriteLine("\nStep 5/6: Creating 'welcome.txt'...");
            string welcomeFilePath = Path.Combine(_repoPath, "welcome.txt");
            File.WriteAllText(welcomeFilePath, "Welcome to Git\n");
            ConsoleHelper.WriteLineColored("✓ welcome.txt created with content: 'Welcome to Git'", ConsoleColor.Green);

            Console.WriteLine("Running 'git status':");
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);
            Console.WriteLine(RunCommandWithOutput("git", "status", _repoPath).Trim());
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);

            // Step 7: Add and Commit
            Console.WriteLine("\nStep 6/6: Staging and Committing welcome.txt...");
            Console.WriteLine("Running 'git add welcome.txt'...");
            RunCommand("git", "add welcome.txt", _repoPath);
            
            Console.WriteLine("\nLaunching Commit (Notepad++ will open to edit commit message if configured)...");
            ConsoleHelper.WriteLineColored("IMPORTANT: Save and close Notepad++ when done to finalize the commit.", ConsoleColor.Cyan);
            
            // Running git commit. We run it in a way that allows interaction or waits for editor
            RunCommandInteractive("git", "commit", _repoPath);

            Console.WriteLine("\nGit Commit completed.");
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);
            Console.WriteLine("Checking updated status:");
            Console.WriteLine(RunCommandWithOutput("git", "status", _repoPath).Trim());
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);

            // Step 8: GitLab Push Instructions
            Console.WriteLine("\nRemote Repository Setup Info:");
            Console.WriteLine("To link your local repository with GitLab and push your changes:");
            ConsoleHelper.WriteLineColored(" 1. Create a repository named 'GitDemo' in GitLab.", ConsoleColor.Cyan);
            ConsoleHelper.WriteLineColored(" 2. Run the following commands in the 'GitDemo' directory:", ConsoleColor.Cyan);
            ConsoleHelper.WriteColored("    git remote add origin ", ConsoleColor.Green);
            ConsoleHelper.WriteLineColored("https://gitlab.com/<your_username>/GitDemo.git", ConsoleColor.Yellow);
            ConsoleHelper.WriteLineColored("    git push -u origin master", ConsoleColor.Green);

            ConsoleHelper.WriteLineColored("\n✓ Real automation complete!", ConsoleColor.Green);
            ConsoleHelper.WaitForKey();
        }

        private bool CheckGitInstalled()
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "git",
                        Arguments = "--version",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                process.WaitForExit();
                return process.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }

        private string? LocateNotepadPlusPlus()
        {
            string[] paths = {
                @"C:\Program Files\Notepad++\notepad++.exe",
                @"C:\Program Files (x86)\Notepad++\notepad++.exe"
            };

            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return null;
        }

        private void CheckAndAddToPath(string nppDir)
        {
            try
            {
                string pathName = "Path";
                string currentPath = Environment.GetEnvironmentVariable(pathName, EnvironmentVariableTarget.User) ?? "";
                
                bool alreadyInPath = currentPath.Split(';')
                    .Select(p => p.Trim().TrimEnd('\\'))
                    .Any(p => string.Equals(p, nppDir.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase));

                if (!alreadyInPath)
                {
                    Console.WriteLine("Notepad++ folder is not in your User PATH variable. Adding it...");
                    string newPath = currentPath;
                    if (!newPath.EndsWith(";") && newPath.Length > 0)
                    {
                        newPath += ";";
                    }
                    newPath += nppDir;
                    Environment.SetEnvironmentVariable(pathName, newPath, EnvironmentVariableTarget.User);
                    ConsoleHelper.WriteLineColored("✓ Notepad++ directory added to User PATH environment variable.", ConsoleColor.Green);
                    ConsoleHelper.WriteLineColored("Note: You may need to restart any active terminal sessions to refresh environmental variables.", ConsoleColor.Yellow);
                }
                else
                {
                    Console.WriteLine("Notepad++ folder is already present in your User PATH variable.");
                }
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteLineColored($"Failed to update environment path automatically: {ex.Message}", ConsoleColor.Yellow);
                Console.WriteLine("Please manually add the Notepad++ installation folder to your environment variables if needed.");
            }
        }

        private void RunCommand(string fileName, string arguments, string workingDir = "")
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                if (!string.IsNullOrEmpty(workingDir))
                {
                    psi.WorkingDirectory = workingDir;
                }
                var process = Process.Start(psi);
                process?.WaitForExit();
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteLineColored($"Command execution failed: {fileName} {arguments}. Error: {ex.Message}", ConsoleColor.Red);
            }
        }

        private string RunCommandWithOutput(string fileName, string arguments, string workingDir = "")
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                if (!string.IsNullOrEmpty(workingDir))
                {
                    psi.WorkingDirectory = workingDir;
                }
                using (var process = Process.Start(psi))
                {
                    if (process == null) return "";
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    return string.IsNullOrEmpty(output) ? error : output;
                }
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }

        private void RunCommandInteractive(string fileName, string arguments, string workingDir = "")
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false // Run in the same console session so editor can be launched/redirected
                };
                if (!string.IsNullOrEmpty(workingDir))
                {
                    psi.WorkingDirectory = workingDir;
                }
                var process = Process.Start(psi);
                process?.WaitForExit();
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteLineColored($"Command execution failed: {fileName} {arguments}. Error: {ex.Message}", ConsoleColor.Red);
            }
        }
    }
}
