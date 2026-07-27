# Setting Up Git

## Introduction

Git is a free, open-source Distributed Version Control System (DVCS) that helps developers track changes in source code, collaborate with team members, and maintain project history. Before using Git, it must be installed and configured properly.

Setting up Git is a one-time process that prepares your computer for version control. Once configured, Git can identify the author of each commit and communicate with remote repositories such as GitHub, GitLab, and Bitbucket.

This chapter explains how to install Git, configure user information, verify the installation, create repositories, and understand Git configuration files.

---

# Why Install Git?

Git provides several advantages during software development:

- Tracks every change made to project files.
- Maintains complete project history.
- Allows multiple developers to work together.
- Supports offline development.
- Makes branching and merging easy.
- Prevents accidental loss of source code.
- Integrates with GitHub and other remote hosting services.

---

# System Requirements

The minimum requirements for installing Git are:

- Windows 10/11
- Linux (Ubuntu, Fedora, Debian, etc.)
- macOS
- Internet Connection
- Administrator privileges (for installation)

---

# Installing Git on Windows

## Step 1: Download Git

Visit the official Git website:

**https://git-scm.com**

Download the latest Windows installer.

---

## Step 2: Run the Installer

Double-click the downloaded installer.

The Git Setup Wizard will appear.

---

## Step 3: Installation Options

During installation, keep the default settings unless your organization requires custom configurations.

Recommended options:

- Git Bash
- Git GUI
- Add Git to PATH
- OpenSSH
- Default text editor
- Checkout Windows-style, commit Unix-style line endings

Click **Next** until the installation begins.

---

## Step 4: Complete Installation

Click **Install**.

After installation is complete, click **Finish**.

Git is now installed successfully.

---

# Installing Git on Linux

Ubuntu/Debian

```bash
sudo apt update
sudo apt install git
```

Fedora

```bash
sudo dnf install git
```

Arch Linux

```bash
sudo pacman -S git
```

---

# Installing Git on macOS

Using Homebrew

```bash
brew install git
```

Or download Git from:

https://git-scm.com

---

# Verify Git Installation

Open Command Prompt, PowerShell, Git Bash, or Terminal.

Execute:

```bash
git --version
```

Example Output

```text
git version 2.53.0.windows.1
```

If the version number appears, Git has been installed successfully.

---

# Configure Git

Git stores author information with every commit.

Configure the username:

```bash
git config --global user.name "Subrahmanyeswara"
```

Configure the email address:

```bash
git config --global user.email "yedula2005@gmail.com"
```

---

# Verify Configuration

To display all Git configuration settings:

```bash
git config --list
```

Example Output

```text
user.name=Subrahmanyeswara
user.email=yedula2005@gmail.com
```

Display only the username:

```bash
git config user.name
```

Display only the email:

```bash
git config user.email
```

---

# Global and Local Configuration

Git supports three levels of configuration.

## System Configuration

Applies to every user on the computer.

Configuration File

```
system gitconfig
```

---

## Global Configuration

Applies to the current user.

Command

```bash
git config --global user.name "Subrahmanyeswara"
```

Configuration File

```
~/.gitconfig
```

---

## Local Configuration

Applies only to the current repository.

Command

```bash
git config user.name "ProjectUser"
```

Configuration File

```
.git/config
```

Priority Order

```
Local Configuration

↓

Global Configuration

↓

System Configuration
```

---

# Create a New Git Repository

Create a project folder.

```bash
mkdir GitDemo
```

Move into the folder.

```bash
cd GitDemo
```

Initialize Git.

```bash
git init
```

Output

```text
Initialized empty Git repository in C:/GitDemo/.git/
```

Git creates a hidden folder named **.git** that stores all repository information.

---

# Clone an Existing Repository

Clone a repository from GitHub.

```bash
git clone https://github.com/username/project.git
```

Example Output

```text
Cloning into 'project'...
Receiving objects...
Resolving deltas...
```

A complete copy of the repository is downloaded to your local computer.

---

# Check Repository Status

Execute:

```bash
git status
```

Example Output

```text
On branch master

No commits yet

nothing to commit
```

This command displays:

- Current branch
- Modified files
- Untracked files
- Files ready for commit

---

# Git Configuration Files

Git stores configuration in three files.

| Configuration | Location | Scope |
|--------------|----------|-------|
| System | System GitConfig | Entire Computer |
| Global | ~/.gitconfig | Current User |
| Local | .git/config | Current Repository |

---

# Frequently Used Setup Commands

Check Git Version

```bash
git --version
```

Configure Username

```bash
git config --global user.name "Subrahmanyeswara"
```

Configure Email

```bash
git config --global user.email "yedula2005@gmail.com"
```

View All Settings

```bash
git config --list
```

Initialize Repository

```bash
git init
```

Clone Repository

```bash
git clone <repository-url>
```

Check Repository Status

```bash
git status
```

---

# Best Practices

- Install the latest stable version of Git.
- Configure your username before creating commits.
- Use the email associated with your GitHub account.
- Verify installation using `git --version`.
- Verify configuration using `git config --list`.
- Keep Git updated.
- Initialize a repository before tracking files.
- Use meaningful repository names.
- Backup projects using GitHub or another remote repository.
- Do not share sensitive information such as passwords or API keys in repositories.

---

# Troubleshooting

## Git command is not recognized

Cause

Git is not installed or not added to the system PATH.

Solution

Reinstall Git and enable the **Add Git to PATH** option.

---

## Incorrect Username

Update it using:

```bash
git config --global user.name "Correct Name"
```

---

## Incorrect Email

Update it using:

```bash
git config --global user.email "correct@example.com"
```

---

## Verify Current Configuration

```bash
git config --list
```

---

# Advantages of Proper Git Setup

- Accurate author information for commits.
- Easy integration with GitHub.
- Faster project initialization.
- Better collaboration with team members.
- Reliable version tracking.
- Simplified repository management.
- Improved software development workflow.

---

# Real-World Example

A software development team is creating an Online Shopping Application.

Before starting development:

1. Every developer installs Git.
2. Each developer configures their username and email.
3. Every developer clones the project repository.
4. Developers create local repositories for testing.
5. Changes are committed and later pushed to GitHub.

This ensures that every contribution is correctly identified and project history is maintained.

---

# Summary

Setting up Git is the first step toward efficient version control. After installing Git, configuring your username and email, verifying the installation, and creating or cloning repositories, you are ready to manage source code effectively. Proper Git setup provides a strong foundation for advanced operations such as staging changes, committing code, branching, merging, and collaborating with teams using GitHub.
