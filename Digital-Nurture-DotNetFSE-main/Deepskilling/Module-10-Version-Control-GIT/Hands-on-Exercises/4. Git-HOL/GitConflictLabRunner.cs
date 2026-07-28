using System;
using System.Diagnostics;
using System.IO;

namespace GitLabRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================================");
            Console.WriteLine("          GIT MERGE CONFLICT RESOLUTION RUNNER (C#)             ");
            Console.WriteLine("=================================================================");
            Console.ResetColor();

            // Set directory to the target workspace path
            string repoPath = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(repoPath);
            Console.WriteLine($"Running in repository path: {repoPath}\n");

            // Step 1: Verify master is in clean state
            RunStep(1, "Verify if master is clean", "git status");

            // Step 2: Create a branch "GitWork" and switch to it
            RunStep(2, "Create branch GitWork and switch to it", "git checkout -b GitWork");
            
            string helloCsPath = Path.Combine(repoPath, "hello.cs");
            string gitWorkContent = @"using System;

namespace GitLab
{
    public class Hello
    {
        public static void Greet()
        {
            Console.WriteLine(""Hello from GitWork branch!"");
        }
    }
}";
            File.WriteAllText(helloCsPath, gitWorkContent);
            Console.WriteLine("[C#] Created hello.cs with GitWork branch content.");

            // Step 3: Update hello.cs and observe status
            string updatedGitWorkContent = @"using System;

namespace GitLab
{
    public class Hello
    {
        public static void Greet()
        {
            Console.WriteLine(""Hello from GitWork branch!"");
            Console.WriteLine(""Updating content for step 3."");
        }
    }
}";
            File.WriteAllText(helloCsPath, updatedGitWorkContent);
            Console.WriteLine("[C#] Updated hello.cs content.");
            RunStep(3, "Observe status after update", "git status");

            // Step 4: Commit changes to GitWork branch
            RunStep(4, "Add and commit changes to GitWork", "git add hello.cs", "git commit -m \"Add and update hello.cs in GitWork branch\"");

            // Step 5: Switch to master
            RunStep(5, "Switch back to master branch", "git checkout master");

            // Step 6: Add hello.cs to master with different content
            string masterContent = @"using System;

namespace GitLab
{
    public class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(""Hello from master branch!"");
            Console.WriteLine(""This is the master branch version."");
        }
    }
}";
            File.WriteAllText(helloCsPath, masterContent);
            Console.WriteLine("[C#] Created hello.cs with master branch content.");

            // Step 7: Commit changes to master
            RunStep(7, "Add and commit changes to master", "git add hello.cs", "git commit -m \"Add hello.cs in master branch with master content\"");

            // Step 8: Observe graph log
            RunStep(8, "Observe git log with graph decoration", "git log --oneline --graph --decorate --all");

            // Step 9: Check diff
            RunStep(9, "Check diff between branches", "git diff master GitWork");

            // Step 10: P4Merge explanation
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[Step 10] For better visualization, configure and use P4Merge tool:");
            Console.WriteLine("Commands to configure P4Merge in Git:");
            Console.WriteLine("  git config --global merge.tool p4merge");
            Console.WriteLine("  git config --global mergetool.p4merge.path \"C:/Program Files/Perforce/p4merge.exe\"");
            Console.WriteLine("  git config --global diff.tool p4merge");
            Console.WriteLine("  git config --global difftool.p4merge.path \"C:/Program Files/Perforce/p4merge.exe\"");
            Console.WriteLine("To view differences: git difftool master GitWork");
            Console.ResetColor();

            // Step 11: Merge branch to master (will fail/conflict)
            RunStep(11, "Merge GitWork branch into master (will conflict)", "git merge GitWork");

            // Step 12: Observe markup
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[Step 12] Observing git conflict markup in hello.cs:");
            Console.ResetColor();
            if (File.Exists(helloCsPath))
            {
                Console.WriteLine(File.ReadAllText(helloCsPath));
            }

            // Step 13: Resolve conflict
            string resolvedContent = @"using System;

namespace GitLab
{
    public class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(""Hello from master branch!"");
            Console.WriteLine(""This is the master branch version."");
            Greet();
        }

        public static void Greet()
        {
            Console.WriteLine(""Hello from GitWork branch!"");
            Console.WriteLine(""Updating content for step 3."");
        }
    }
}";
            File.WriteAllText(helloCsPath, resolvedContent);
            Console.WriteLine("[C#] Conflict resolved in hello.cs by merging both methods.");

            // Step 14: Commit changes to master after conflict resolution
            RunStep(14, "Stage and commit resolved conflict", "git add hello.cs", "git commit -m \"Merge branch 'GitWork' into master and resolve conflict in hello.cs\"");

            // Step 15: Observe status and add backup to .gitignore
            string gitignorePath = Path.Combine(repoPath, ".gitignore");
            File.WriteAllText(gitignorePath, "*.orig" + Environment.NewLine);
            Console.WriteLine("[C#] Added *.orig to .gitignore");
            RunStep(15, "Observe status after merge", "git status");

            // Step 16: Commit .gitignore
            RunStep(16, "Add and commit .gitignore", "git add .gitignore", "git commit -m \"Add .gitignore to ignore *.orig backup files\"");

            // Step 17: List branches
            RunStep(17, "List available branches", "git branch -a");

            // Step 18: Delete the GitWork branch
            RunStep(18, "Delete the merged GitWork branch", "git branch -d GitWork");

            // Step 19: Observe log
            RunStep(19, "Observe final git log with graph decoration", "git log --oneline --graph --decorate");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=================================================================");
            Console.WriteLine("              LAB COMPLETED SUCCESSFULLY!                        ");
            Console.WriteLine("=================================================================");
            Console.ResetColor();
        }

        static void RunStep(int stepNumber, string description, params string[] commands)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[Step {stepNumber}] {description}");
            Console.ResetColor();

            foreach (var cmd in commands)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Executing: {cmd}");
                Console.ResetColor();

                var psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {cmd}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(psi))
                {
                    process.WaitForExit();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    if (!string.IsNullOrEmpty(output))
                    {
                        Console.WriteLine(output.Trim());
                    }
                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(error.Trim());
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
