using System;
using System.IO;
using System.Diagnostics;

namespace GitIgnoreLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            PrintHeader();
            PrintExplanation();

            string workingDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"\nWorking Directory: {workingDir}\n");

            // 1. Clean up any previous runs
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Step 1: Cleaning up any previous lab files...");
            CleanupPreviousLab(workingDir);
            Console.WriteLine("Cleanup completed.");

            // 2. Initialize Git Repository
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 2: Initializing Git repository...");
            string initOutput = RunGitCommand("init");
            Console.WriteLine(initOutput);

            // Configure local user info if not set, to ensure commit works
            ConfigureLocalGitUser();

            // 3. Create a .log file and log/ folder with a file inside
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 3: Creating target files and folders...");
            
            string logFilePath = Path.Combine(workingDir, "app_execution.log");
            File.WriteAllText(logFilePath, "[INFO] 2026-07-28: Application started.\n[ERROR] 2026-07-28: Unexpected null reference.");
            Console.WriteLine($"Created log file: {Path.GetFileName(logFilePath)}");

            string logFolderPath = Path.Combine(workingDir, "log");
            Directory.CreateDirectory(logFolderPath);
            string innerLogFile = Path.Combine(logFolderPath, "server_debug.txt");
            File.WriteAllText(innerLogFile, "[DEBUG] Database connection opened.");
            Console.WriteLine($"Created folder: {Path.GetFileName(logFolderPath)} with file: {Path.GetFileName(innerLogFile)}");

            // 4. Check git status before adding .gitignore
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 4: Running 'git status' BEFORE configuring .gitignore...");
            string statusBefore = RunGitCommand("status");
            Console.WriteLine(statusBefore);

            // 5. Create .gitignore and write ignore patterns
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 5: Creating and configuring .gitignore...");
            string gitignorePath = Path.Combine(workingDir, ".gitignore");
            
            // Patterns:
            // *.log -> ignores all files with .log extension
            // log/  -> ignores the entire log directory and its contents
            // bin/, obj/ -> ignores dotnet build outputs
            string gitignoreContent = "# Ignore all log files\n*.log\n\n# Ignore the log folder\nlog/\n\n# Ignore C# build directories\nbin/\nobj/\n";
            File.WriteAllText(gitignorePath, gitignoreContent);
            
            Console.WriteLine("Written to .gitignore:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(gitignoreContent);
            Console.ResetColor();

            // 6. Check git status after adding .gitignore
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Step 6: Running 'git status' AFTER configuring .gitignore...");
            string statusAfter = RunGitCommand("status");
            Console.WriteLine(statusAfter);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Notice that 'app_execution.log' and 'log/' are no longer listed as untracked files!\nOnly '.gitignore', 'GitIgnoreLab.csproj', and 'Program.cs' are visible.");
            Console.ResetColor();

            // 7. Commit changes to verify they are not added
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 7: Staging and committing tracked files...");
            
            Console.WriteLine("Running: git add .");
            RunGitCommand("add .");
            
            Console.WriteLine("Running: git commit -m \"Configure git ignore and project files\"");
            string commitOutput = RunGitCommand("commit -m \"Configure git ignore and project files\"");
            Console.WriteLine(commitOutput);

            // 8. Verify git status is clean and ignored files remain untracked
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Step 8: Verifying Git Status of local repository after commit...");
            string finalStatus = RunGitCommand("status");
            Console.WriteLine(finalStatus);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Conclusion: The log files and log folder are completely ignored by Git and will not be tracked or pushed to the remote repository. The working tree is clean.");
            Console.ResetColor();
            
            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }

        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===============================================================================");
            Console.WriteLine("                 Git Ignore Lab Automation - C# Implementation                ");
            Console.WriteLine("===============================================================================");
            Console.ResetColor();
        }

        static void PrintExplanation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n--- EXPLANATION OF GIT IGNORE ---");
            Console.ResetColor();
            Console.WriteLine("1. What is Git Ignore?");
            Console.WriteLine("   Git views files in your working directory as either tracked, untracked, or ignored.");
            Console.WriteLine("   Ignored files are files that Git is told to explicitly look past and never track.");
            Console.WriteLine("   These are specified in a special file named '.gitignore' in the repository root.");
            Console.WriteLine("\n2. Why ignore files?");
            Console.WriteLine("   Unwanted files like compiled code (.exe, .dll, .class), log files (.log), database");
            Console.WriteLine("   files, environment variables (.env), and package dependencies (node_modules/)");
            Console.WriteLine("   clutter the repository, waste storage, and can leak credentials/secrets.");
            Console.WriteLine("\n3. How does Git Ignore pattern matching work?");
            Console.WriteLine("   - '*' matches zero or more characters. Example: '*.log' matches 'debug.log', 'app.log'.");
            Console.WriteLine("   - '/' at the end of a pattern matches directories. Example: 'log/' ignores the directory 'log' and all contents recursively.");
            Console.WriteLine("   - '!' negates a pattern. Example: '!important.log' ensures 'important.log' is tracked even if '*.log' is ignored.");
        }

        static void CleanupPreviousLab(string workingDir)
        {
            string logFile = Path.Combine(workingDir, "app_execution.log");
            if (File.Exists(logFile)) File.Delete(logFile);

            string gitignore = Path.Combine(workingDir, ".gitignore");
            if (File.Exists(gitignore)) File.Delete(gitignore);

            string logDir = Path.Combine(workingDir, "log");
            SafeDeleteDirectory(logDir);

            string gitDir = Path.Combine(workingDir, ".git");
            SafeDeleteDirectory(gitDir);
        }

        static void SafeDeleteDirectory(string path)
        {
            if (!Directory.Exists(path)) return;

            var directory = new DirectoryInfo(path) { Attributes = FileAttributes.Normal };
            foreach (var info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                info.Attributes = FileAttributes.Normal;
            }
            directory.Delete(true);
        }

        static string RunGitCommand(string arguments)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (var process = Process.Start(startInfo))
                {
                    if (process == null) return "Error: Failed to start git process.";
                    process.WaitForExit();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    
                    if (process.ExitCode != 0)
                    {
                        return $"Error (Exit Code {process.ExitCode}): {error}\n{output}";
                    }
                    return output;
                }
            }
            catch (Exception ex)
            {
                return $"Exception running git command: {ex.Message}";
            }
        }

        static void ConfigureLocalGitUser()
        {
            string userName = RunGitCommand("config user.name").Trim();
            if (string.IsNullOrEmpty(userName) || userName.StartsWith("Error"))
            {
                RunGitCommand("config --local user.name \"GitLab Student\"");
            }
            string userEmail = RunGitCommand("config user.email").Trim();
            if (string.IsNullOrEmpty(userEmail) || userEmail.StartsWith("Error"))
            {
                RunGitCommand("config --local user.email \"student@example.com\"");
            }
        }
    }
}
