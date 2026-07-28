using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        PrintHeader();
        
        // Part 1: Explanations
        ExplainConcepts();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n================================================================================");
        Console.WriteLine("PART 2: HANDS-ON LAB AUTOMATION");
        Console.WriteLine("================================================================================");
        Console.ResetColor();

        // Check if Git is installed
        if (!IsGitInstalled())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] Git is not installed or not in the system PATH.");
            Console.ResetColor();
            return;
        }

        try
        {
            ExecuteLab();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] An unexpected error occurred: {ex.Message}");
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n================================================================================");
        Console.WriteLine("Lab finished successfully!");
        Console.WriteLine("================================================================================");
        Console.ResetColor();
    }

    static void PrintHeader()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
   ______ _ _      ____               _   _           _             
  |  ____(_) |    |  _ \             | | (_)         | |            
  | |__   _| |_   | |_) |_ __ __ _ _ | |  _ _ __   __| | __ _   _ 
  |  __| | | __|  |  _ <| '__/ _` | '_ \| | | '_ \ / _` |/ _` | | |
  | |    | | |_   | |_) | | | (_| | | | | | | | | | (_| | (_| |_| |
  |_|    |_|\__|  |____/|_|  \__,_|_| |_|_|_|_| |_|\__,_|\__, |\__, |
                                                          __/ | __/ |
                                                         |___/ |___/ 
        ");
        Console.ResetColor();
    }

    static void ExplainConcepts()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("================================================================================");
        Console.WriteLine("PART 1: CONCEPTS & EXPLANATIONS");
        Console.WriteLine("================================================================================");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n1. Branching and Merging in Git");
        Console.ResetColor();
        Console.WriteLine("   • Branching: A branch represents an independent line of development. Think of it as a");
        Console.WriteLine("     way to request a brand new working directory, staging area, and history. New commits");
        Console.WriteLine("     are recorded in the history of the current branch. This allows developers to isolate");
        Console.WriteLine("     their work (features, bug fixes) from the main line of development ('master' or 'main').");
        Console.WriteLine("   • Merging: Merging is the practice of combining the work done in two different branches.");
        Console.WriteLine("     Git does this by finding a common base commit between the two branches and performing");
        Console.WriteLine("     a three-way merge. If changes do not overlap, Git merges them automatically. If they do");
        Console.WriteLine("     overlap on the same lines, a 'merge conflict' occurs, which must be resolved manually.");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n2. Creating a Branch Request in GitLab");
        Console.ResetColor();
        Console.WriteLine("   • In GitLab, you typically avoid committing directly to protected branches (like 'master').");
        Console.WriteLine("   • To create a branch request:");
        Console.WriteLine("     a. In the GitLab UI: Navigate to Repository > Branches, click 'New branch', give it a name,");
        Console.WriteLine("        and select the source branch.");
        Console.WriteLine("     b. Via CLI: Create a local branch and push it to remote:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("        $ git checkout -b feature-branch");
        Console.WriteLine("        $ git push -u origin feature-branch");
        Console.ResetColor();
        Console.WriteLine("     c. This registers the new branch on the GitLab remote repository.");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n3. Creating a Merge Request (MR) in GitLab");
        Console.ResetColor();
        Console.WriteLine("   • A Merge Request is a proposal to merge changes from a source branch into a target branch.");
        Console.WriteLine("   • Steps to create an MR:");
        Console.WriteLine("     a. Once you push a new branch, GitLab will show a banner 'Create merge request' on the homepage.");
        Console.WriteLine("     b. Click the button or navigate to Merge Requests > New merge request.");
        Console.WriteLine("     c. Select the source branch (e.g., 'feature-branch') and the target branch (e.g., 'master').");
        Console.WriteLine("     d. Fill in the Title, Description (what changes were made, why, etc.).");
        Console.WriteLine("     e. Assign reviewers, add assignees, select milestones, or add labels.");
        Console.WriteLine("     f. Click 'Create merge request'. This triggers automatic CI/CD pipelines, displays code diffs,");
        Console.WriteLine("        and allows reviewers to comment on the code before merging.");
    }

    static bool IsGitInstalled()
    {
        try
        {
            var result = ExecuteCommand("git", "--version", false);
            return result.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }

    static void ExecuteLab()
    {
        string currentDir = Directory.GetCurrentDirectory();
        Console.WriteLine($"\nWorking Directory: {currentDir}\n");

        // 0. Initialize or check Git repo
        LogStep("0. Initializing Git Repository (or checking if already initialized)");
        RunAndDisplay("git", "init");

        // Set local config to prevent commit failures if no global config is set
        LogStep("Setting up local git configuration for user.name and user.email");
        RunAndDisplay("git", "config --local user.name \"Git Lab CSharp User\"");
        RunAndDisplay("git", "config --local user.email \"labuser@example.com\"");
        // Set default branch name to master for local init
        RunAndDisplay("git", "checkout -b master");

        // Create an initial commit if one doesn't exist, so branching can work.
        // We will add the project files that dotnet new console just created.
        LogStep("Creating an initial commit on master to establish trunk history");
        RunAndDisplay("git", "add .");
        RunAndDisplay("git", "commit -m \"Initial commit: Console application setup\"");

        // --- BRANCHING STEPS ---
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n--- BRANCHING ---");
        Console.ResetColor();

        // 1. Create a new branch "GitNewBranch".
        LogStep("1. Creating a new branch 'GitNewBranch'");
        RunAndDisplay("git", "branch GitNewBranch");

        // 2. List all the local and remote branches available in the current trunk. Observe the "*" mark.
        LogStep("2. Listing all local and remote branches");
        RunAndDisplay("git", "branch -a");

        // 3. Switch to the newly created branch. Add some files to it with some contents.
        LogStep("3. Switching to GitNewBranch and adding a new C# code file");
        RunAndDisplay("git", "checkout GitNewBranch");

        // Create MathUtils.cs C# code file
        string csharpFile = "MathUtils.cs";
        string csharpContent = @"using System;

namespace GitLabDemo
{
    public static class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}";
        File.WriteAllText(csharpFile, csharpContent);
        Console.WriteLine($"[INFO] Created file: {csharpFile} with C# math utility code.");

        // 4. Commit the changes to the branch.
        LogStep("4. Staging and committing changes to GitNewBranch");
        RunAndDisplay("git", "add MathUtils.cs");
        RunAndDisplay("git", "commit -m \"Add MathUtils.cs helper class\"");

        // 5. Check the status with "git status" command.
        LogStep("5. Checking git status on GitNewBranch");
        RunAndDisplay("git", "status");


        // --- MERGING STEPS ---
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n--- MERGING ---");
        Console.ResetColor();

        // 1. Switch to the master
        LogStep("1. Switching back to master branch");
        RunAndDisplay("git", "checkout master");

        // 2. List out all the differences between trunk and branch.
        LogStep("2. Listing differences between master and GitNewBranch");
        RunAndDisplay("git", "diff master..GitNewBranch");

        // 3. List out all the visual differences between master and branch using P4Merge tool.
        LogStep("3. Checking P4Merge tool configuration and attempting visual diff");
        // We will check if p4merge tool is configured.
        var p4check = ExecuteCommand("git", "config --get diff.tool", false);
        string currentDiffTool = p4check.Output.Trim();
        Console.WriteLine($"[INFO] Current configured git diff.tool: '{currentDiffTool}'");
        
        if (currentDiffTool != "p4merge")
        {
            Console.WriteLine("[INFO] Configuring local git to use p4merge as diff tool...");
            RunAndDisplay("git", "config --local diff.tool p4merge");
            RunAndDisplay("git", "config --local difftool.p4merge.path \"C:\\Program Files\\Perforce\\p4merge.exe\""); // Default Windows installation path
            RunAndDisplay("git", "config --local difftool.prompt false");
        }

        Console.WriteLine("[INFO] Running: git difftool master GitNewBranch");
        Console.WriteLine("       (If P4Merge is installed on your Windows machine, a visual window will open. Otherwise, git will fail back or prompt. Running non-interactively where possible...)");
        // We run difftool. Since it might block if p4merge isn't installed, we pass --no-prompt or use git diff as fallback.
        RunAndDisplay("git", "difftool --no-prompt master GitNewBranch");

        // 4. Merge the source branch to the trunk.
        LogStep("4. Merging GitNewBranch into master");
        // Use --no-edit to prevent git from opening vim/notepad for merge commit message
        RunAndDisplay("git", "merge GitNewBranch --no-edit");

        // 5. Observe the logging after merging using "git log --oneline --graph --decorate"
        LogStep("5. Observing commit logs (git log --oneline --graph --decorate)");
        RunAndDisplay("git", "log --oneline --graph --decorate -n 10");

        // 6. Delete the branch after merging with the trunk and observe the git status.
        LogStep("6. Deleting GitNewBranch and checking final status");
        RunAndDisplay("git", "branch -d GitNewBranch");
        RunAndDisplay("git", "status");
    }

    static void LogStep(string stepDescription)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n▶ {stepDescription}");
        Console.WriteLine(new string('-', stepDescription.Length + 2));
        Console.ResetColor();
    }

    static void RunAndDisplay(string cmd, string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"$ {cmd} {args}");
        Console.ResetColor();

        var result = ExecuteCommand(cmd, args, true);
        if (result.ExitCode != 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] Command exited with code {result.ExitCode}");
            if (!string.IsNullOrEmpty(result.Error))
            {
                Console.WriteLine($"[ERROR Output]: {result.Error.Trim()}");
            }
            Console.ResetColor();
        }
    }

    struct CommandResult
    {
        public int ExitCode;
        public string Output;
        public string Error;
    }

    static CommandResult ExecuteCommand(string cmd, string args, bool printOutput)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = cmd,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = new Process { StartInfo = startInfo })
        {
            var outputBuilder = new StringBuilder();
            var errorBuilder = new StringBuilder();

            process.OutputDataReceived += (s, e) =>
            {
                if (e.Data != null)
                {
                    outputBuilder.AppendLine(e.Data);
                    if (printOutput)
                    {
                        Console.WriteLine(e.Data);
                    }
                }
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data != null)
                {
                    errorBuilder.AppendLine(e.Data);
                }
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                return new CommandResult
                {
                    ExitCode = process.ExitCode,
                    Output = outputBuilder.ToString(),
                    Error = errorBuilder.ToString()
                };
            }
            catch (Exception ex)
            {
                return new CommandResult
                {
                    ExitCode = -1,
                    Output = "",
                    Error = ex.Message
                };
            }
        }
    }
}
