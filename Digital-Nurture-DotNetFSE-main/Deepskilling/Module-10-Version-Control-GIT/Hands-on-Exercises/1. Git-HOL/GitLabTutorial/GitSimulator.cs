using System;
using System.Collections.Generic;
using System.Threading;

namespace GitLabTutorial
{
    public class GitSimulator
    {
        private class Step
        {
            public int Number { get; set; }
            public string? Title { get; set; }
            public string? Explanation { get; set; }
            public string? ExpectedCommandCmd { get; set; }
            public string? ExpectedCommandBash { get; set; }
            public string? OutputCmd { get; set; }
            public string? OutputBash { get; set; }
            public Action<Step>? ActionBeforeOutput { get; set; }
            public Action<Step>? ActionAfterOutput { get; set; }
        }

        private int _currentStepIdx = 0;
        private string _username = "Subrahmanyeswara";
        private string _email = "yedula2005@gmail.com";
        private bool _isGitDemoDir = false;
        private bool _isGitInit = false;
        private string _shellTheme = "bash"; // "cmd" or "bash"
        private List<Step> _steps = new List<Step>();

        public void Run()
        {
            InitializeSteps();
            _currentStepIdx = 0;
            _isGitDemoDir = false;
            _isGitInit = false;

            // Choose shell theme
            string[] shellOptions = { "Git Bash (Recommended)", "Command Prompt (CMD)" };
            int themeSel = ConsoleHelper.ShowMenu("Select Simulated Terminal Shell Theme", shellOptions);
            if (themeSel == -1) return;
            _shellTheme = themeSel == 0 ? "bash" : "cmd";

            Console.Clear();
            ConsoleHelper.DrawHeader($"GIT LAB INTERACTIVE SIMULATOR ({(_shellTheme == "bash" ? "Git Bash" : "CMD")})", ConsoleColor.Green);
            ConsoleHelper.WriteLineColored("Goal: Complete the 12 steps of the Git configuration and repository lab.", ConsoleColor.Cyan);
            Console.WriteLine("Instructions:");
            Console.WriteLine(" 1. Read the instructions & explanation for each step.");
            Console.WriteLine(" 2. Type the exact command displayed, or just press [Enter] to auto-type.");
            Console.WriteLine(" 3. Type 'exit' at any prompt to return to the main menu.");
            Console.WriteLine(" 4. Type 'theme' to toggle between Git Bash and CMD shell style.");
            ConsoleHelper.DrawDivider();
            ConsoleHelper.WaitForKey();

            while (_currentStepIdx < _steps.Count)
            {
                Step step = _steps[_currentStepIdx];
                ShowStepHeader(step);

                string prompt = GetPromptString();
                Console.Write(prompt);

                string? input = Console.ReadLine()?.Trim();
                
                if (input != null && input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (input != null && input.Equals("theme", StringComparison.OrdinalIgnoreCase))
                {
                    _shellTheme = _shellTheme == "bash" ? "cmd" : "cmd";
                    Console.WriteLine($"\nShell theme toggled to: {(_shellTheme == "bash" ? "Git Bash" : "CMD")}\n");
                    continue;
                }

                string expected = (_shellTheme == "cmd" ? step.ExpectedCommandCmd : step.ExpectedCommandBash) ?? "";

                // Auto-type if input is empty
                if (string.IsNullOrEmpty(input))
                {
                    AutoType(expected);
                    input = expected;
                }

                if (ValidateCommand(input, expected))
                {
                    // Execute pre-actions (like opening editor)
                    step.ActionBeforeOutput?.Invoke(step);

                    // Print command output
                    string? output = _shellTheme == "cmd" ? step.OutputCmd : step.OutputBash;
                    if (!string.IsNullOrEmpty(output))
                    {
                        ConsoleColor outputColor = ConsoleColor.White;
                        if (output.Contains("warning") || output.Contains("On branch"))
                        {
                            outputColor = ConsoleColor.Gray;
                        }
                        
                        // Parse status message colors in simulation
                        if (output.Contains("welcome.txt") && output.Contains("Untracked"))
                        {
                            // Output contains untracked warning, let's draw "welcome.txt" red
                            PrintStatusOutput(output);
                        }
                        else
                        {
                            ConsoleHelper.WriteLineColored(output, outputColor);
                        }
                    }

                    // Execute post-actions
                    step.ActionAfterOutput?.Invoke(step);

                    ConsoleHelper.WriteLineColored($"\n[Step {step.Number} Completed successfully!]", ConsoleColor.Green);
                    ConsoleHelper.DrawDivider(ConsoleColor.DarkGreen);
                    _currentStepIdx++;
                    ConsoleHelper.WaitForKey();
                }
                else
                {
                    ConsoleHelper.WriteLineColored($"Invalid command. Expected: \"{expected}\"", ConsoleColor.Red);
                    ConsoleHelper.WriteLineColored("Hint: Type the command exactly as shown, or press [Enter] to auto-type.", ConsoleColor.DarkYellow);
                    Console.WriteLine();
                }
            }

            Console.Clear();
            ConsoleHelper.DrawHeader("SIMULATION COMPLETE!", ConsoleColor.Green);
            Console.WriteLine("\nCongratulations! You have completed all steps of the Git Hands-On Lab in simulation mode.\n");
            ConsoleHelper.WaitForKey();
        }

        private void InitializeSteps()
        {
            _steps.Clear();

            // Step 1
            _steps.Add(new Step
            {
                Number = 1,
                Title = "Check Git Client Installation",
                Explanation = "Checks if the Git command-line client is installed properly. Running 'git --version' returns the installed client version.",
                ExpectedCommandCmd = "git --version",
                ExpectedCommandBash = "git --version",
                OutputCmd = "git version 2.53.0.windows.1",
                OutputBash = "git version 2.53.0.windows.1"
            });

            // Step 2
            _steps.Add(new Step
            {
                Number = 2,
                Title = "Set User Configuration Credentials",
                Explanation = "Configures global user level settings: name and email. These identify you as the author of commits.",
                ExpectedCommandCmd = $"git config --global user.name \"{_username}\" && git config --global user.email \"{_email}\"",
                ExpectedCommandBash = $"git config --global user.name \"{_username}\" && git config --global user.email \"{_email}\"",
                OutputCmd = "",
                OutputBash = ""
            });

            // Step 3
            _steps.Add(new Step
            {
                Number = 3,
                Title = "Verify Configuration Settings",
                Explanation = "Lists all current settings to verify that user name and email have been properly written to global configuration files.",
                ExpectedCommandCmd = "git config --list",
                ExpectedCommandBash = "git config --list",
                OutputCmd = $"diff.astextplain.textconv=astextplain\ncore.autocrlf=true\ncore.editor=notepad++\nuser.name={_username}\nuser.email={_email}\ninit.defaultbranch=master",
                OutputBash = $"diff.astextplain.textconv=astextplain\ncore.autocrlf=true\ncore.editor=notepad++\nuser.name={_username}\nuser.email={_email}\ninit.defaultbranch=master"
            });

            // Step 4
            _steps.Add(new Step
            {
                Number = 4,
                Title = "Test Notepad++ Command Execution",
                Explanation = "Attempts to launch Notepad++ from the shell to verify it's added to your PATH environment variables.",
                ExpectedCommandCmd = "notepad++",
                ExpectedCommandBash = "notepad++",
                OutputCmd = "[Launching Notepad++ editor environment...]",
                OutputBash = "[Launching Notepad++ editor environment...]",
                ActionBeforeOutput = (s) =>
                {
                    ConsoleHelper.WriteLineColored("\n[Simulation] Opening Notepad++ window mockup...", ConsoleColor.DarkYellow);
                    Thread.Sleep(1000);
                    string doc = "Welcome to Notepad++!\nEnvironment variable config is verified successfully.\nYou can close this editor to return to the CLI.";
                    SimulatedNpp.Open("New Document.txt", doc);
                }
            });

            // Step 5
            _steps.Add(new Step
            {
                Number = 5,
                Title = "Set Notepad++ as default Editor",
                Explanation = "Configures Git to default to Notepad++ as the core editor when creating commit messages or editing config files.",
                ExpectedCommandCmd = "git config --global core.editor \"notepad++\"",
                ExpectedCommandBash = "git config --global core.editor \"notepad++\"",
                OutputCmd = "",
                OutputBash = ""
            });

            // Step 6
            _steps.Add(new Step
            {
                Number = 6,
                Title = "Open and Edit global config file",
                Explanation = "Uses 'git config --global -e' which opens the global `.gitconfig` file in Notepad++ so you can verify settings manually.",
                ExpectedCommandCmd = "git config --global -e",
                ExpectedCommandBash = "git config --global -e",
                OutputCmd = "[Opening global configuration file `.gitconfig` in Notepad++...]",
                OutputBash = "[Opening global configuration file `.gitconfig` in Notepad++...]",
                ActionBeforeOutput = (s) =>
                {
                    ConsoleHelper.WriteLineColored("\n[Simulation] Opening .gitconfig file in Notepad++ editor...", ConsoleColor.DarkYellow);
                    Thread.Sleep(1000);
                    string configContent = $"[diff \"astextplain\"]\n\ttextconv = astextplain\n[filter \"lfs\"]\n\tclean = git-lfs clean -- %f\n\tsmudge = git-lfs smudge -- %f\n\tprocess = git-lfs filter-process\n\trequired = true\n[core]\n\tautocrlf = true\n\teditor = notepad++\n[user]\n\tname = {_username}\n\temail = {_email}";
                    SimulatedNpp.Open(".gitconfig", configContent);
                }
            });

            // Step 7
            _steps.Add(new Step
            {
                Number = 7,
                Title = "Initialize new Local Repository",
                Explanation = "Creates a directory 'GitDemo', changes directory, and runs 'git init' to initialize tracking database.",
                ExpectedCommandCmd = "mkdir GitDemo && cd GitDemo && git init",
                ExpectedCommandBash = "mkdir GitDemo && cd GitDemo && git init",
                OutputCmd = "Initialized empty Git repository in C:/Users/subbu/GitDemo/.git/",
                OutputBash = "Initialized empty Git repository in C:/Users/subbu/GitDemo/.git/",
                ActionAfterOutput = (s) =>
                {
                    _isGitDemoDir = true;
                    _isGitInit = true;
                }
            });

            // Step 8
            _steps.Add(new Step
            {
                Number = 8,
                Title = "Create welcome.txt and Verify Content",
                Explanation = "Writes 'Welcome to Git' to a file 'welcome.txt' and outputs the file content (cat/type) to verify it.",
                ExpectedCommandCmd = "echo \"Welcome to Git\" > welcome.txt && type welcome.txt",
                ExpectedCommandBash = "echo \"Welcome to Git\" > welcome.txt && cat welcome.txt",
                OutputCmd = "Welcome to Git",
                OutputBash = "Welcome to Git"
            });

            // Step 9
            _steps.Add(new Step
            {
                Number = 9,
                Title = "Check Git Status",
                Explanation = "Runs 'git status' to inspect current differences. Newly created files are untracked and marked in red.",
                ExpectedCommandCmd = "git status",
                ExpectedCommandBash = "git status",
                OutputCmd = "On branch master\n\nNo commits yet\n\nUntracked files:\n  (use \"git add <file>...\" to include in what will be committed)\n\twelcome.txt\n\nnothing added to commit but untracked files present (use \"git add\" to track)",
                OutputBash = "On branch master\n\nNo commits yet\n\nUntracked files:\n  (use \"git add <file>...\" to include in what will be committed)\n\twelcome.txt\n\nnothing added to commit but untracked files present (use \"git add\" to track)"
            });

            // Step 10
            _steps.Add(new Step
            {
                Number = 10,
                Title = "Track welcome.txt File",
                Explanation = "Executes 'git add welcome.txt' to move the file to the staging area, prepping it for committing.",
                ExpectedCommandCmd = "git add welcome.txt",
                ExpectedCommandBash = "git add welcome.txt",
                OutputCmd = "warning: in the working copy of 'welcome.txt', LF will be replaced by CRLF the next time Git touches it",
                OutputBash = "warning: in the working copy of 'welcome.txt', LF will be replaced by CRLF the next time Git touches it"
            });

            // Step 11
            _steps.Add(new Step
            {
                Number = 11,
                Title = "Commit File via Default Editor",
                Explanation = "Launches 'git commit' which triggers Notepad++ to allow writing a multi-line descriptive message.",
                ExpectedCommandCmd = "git commit",
                ExpectedCommandBash = "git commit",
                OutputCmd = "[Opening Notepad++ to edit commit comments...]",
                OutputBash = "[Opening Notepad++ to edit commit comments...]",
                ActionBeforeOutput = (s) =>
                {
                    ConsoleHelper.WriteLineColored("\n[Simulation] Git launches Notepad++ to edit commit comments...", ConsoleColor.DarkYellow);
                    Thread.Sleep(1000);
                    string template = "\n# Please enter the commit message for your changes. Lines starting\n# with '#' will be ignored, and an empty message aborts the commit.\n#\n# On branch master\n# Initial commit\n#\n# Changes to be committed:\n#\tnew file:   welcome.txt\n#";
                    string result = SimulatedNpp.Open("COMMIT_EDITMSG", template);
                    
                    // Extract commit message
                    string commitMsg = "Added welcome.txt with intro";
                    var firstLine = result.Split('\n')[0].Trim();
                    if (!string.IsNullOrEmpty(firstLine) && !firstLine.StartsWith("#"))
                    {
                        commitMsg = firstLine;
                    }
                    
                    string commitOutput = $"[master (root-commit) c8094f8] {commitMsg}\n 1 file changed, 1 insertion(+)\n create mode 100644 welcome.txt";
                    s.OutputCmd = commitOutput;
                    s.OutputBash = commitOutput;
                }
            });

            // Step 12
            _steps.Add(new Step
            {
                Number = 12,
                Title = "Link and Push to GitLab Repository",
                Explanation = "Links the local repository to GitLab and pushes files to the master branch of GitLab.",
                ExpectedCommandCmd = "git remote add origin https://gitlab.com/subbu/GitDemo.git && git push origin master",
                ExpectedCommandBash = "git remote add origin https://gitlab.com/subbu/GitDemo.git && git push origin master",
                OutputCmd = "Enumerating objects: 3, done.\nCounting objects: 100% (3/3), done.\nWriting objects: 100% (3/3), 282 bytes | 282.00 KiB/s, done.\nTotal 3 (delta 0), reused 0 (delta 0), pack-reused 0\nTo https://gitlab.com/subbu/GitDemo.git\n * [new branch]      master -> master",
                OutputBash = "Enumerating objects: 3, done.\nCounting objects: 100% (3/3), done.\nWriting objects: 100% (3/3), 282 bytes | 282.00 KiB/s, done.\nTotal 3 (delta 0), reused 0 (delta 0), pack-reused 0\nTo https://gitlab.com/subbu/GitDemo.git\n * [new branch]      master -> master"
            });
        }

        private void ShowStepHeader(Step step)
        {
            Console.WriteLine();
            ConsoleHelper.DrawDivider(ConsoleColor.Cyan);
            ConsoleHelper.WriteColored($"STEP {step.Number}: ", ConsoleColor.Green);
            ConsoleHelper.WriteLineColored(step.Title ?? "", ConsoleColor.White);
            Console.WriteLine();
            ConsoleHelper.WriteColored("Explanation: ", ConsoleColor.DarkYellow);
            ConsoleHelper.WriteLineColored(step.Explanation ?? "", ConsoleColor.Gray);
            Console.WriteLine();
            string expected = (_shellTheme == "cmd" ? step.ExpectedCommandCmd : step.ExpectedCommandBash) ?? "";
            ConsoleHelper.WriteColored("Task: Type: ", ConsoleColor.Yellow);
            ConsoleHelper.WriteLineColored(expected, ConsoleColor.Magenta);
            ConsoleHelper.WriteLineColored("      (Or press [Enter] to auto-type)", ConsoleColor.DarkGray);
            ConsoleHelper.DrawDivider(ConsoleColor.DarkGray);
        }

        private string GetPromptString()
        {
            if (_shellTheme == "cmd")
            {
                string path = _isGitDemoDir ? @"C:\Users\subbu\GitDemo" : @"C:\Users\subbu";
                return $"{path}>";
            }
            else
            {
                string path = _isGitDemoDir ? "/c/Users/subbu/GitDemo" : "/c/Users/subbu";
                string branch = _isGitInit ? " (master)" : "";
                return $"subbu@DESKTOP-5F8KL MINGW64 {path}{branch}\n$ ";
            }
        }

        private bool ValidateCommand(string input, string expected)
        {
            if (string.IsNullOrEmpty(input)) return false;
            // Clean spaces and quotes for slightly looser matching (but still correct)
            string cleanInput = input.Replace("  ", " ").Trim();
            string cleanExpected = expected.Replace("  ", " ").Trim();
            return string.Equals(cleanInput, cleanExpected, StringComparison.OrdinalIgnoreCase);
        }

        private void AutoType(string command)
        {
            ConsoleHelper.WriteColored("[Auto-typing]: ", ConsoleColor.DarkGray);
            foreach (char c in command)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            Thread.Sleep(300);
        }

        private void PrintStatusOutput(string output)
        {
            var lines = output.Split('\n');
            foreach (var line in lines)
            {
                if (line.Contains("welcome.txt") && !line.Contains("use \"git add"))
                {
                    // Print prefix spaces
                    int welcomeIdx = line.IndexOf("welcome.txt");
                    if (welcomeIdx > 0)
                    {
                        Console.Write(line.Substring(0, welcomeIdx));
                    }
                    ConsoleHelper.WriteLineColored("welcome.txt", ConsoleColor.Red);
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
