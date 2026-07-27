# Setting Up Git

## Overview

Git is one of the most popular Distributed Version Control Systems (DVCS) used by developers worldwide to manage source code efficiently. Before using Git to track changes and collaborate on software projects, it must be installed and configured correctly.

This module provides a step-by-step guide for installing Git, configuring the user identity, verifying the installation, and creating your first Git repository. Proper Git configuration ensures that every commit is associated with the correct author information and enables seamless collaboration using platforms such as GitHub, GitLab, and Bitbucket.

By completing this module, learners will establish a fully functional Git environment that serves as the foundation for all future Git operations, including branching, merging, pushing, pulling, and collaborative development.

---

# Objectives

After completing this module, you will be able to:

- Understand the importance of installing and configuring Git.
- Install Git on Windows, Linux, and macOS.
- Verify that Git has been installed successfully.
- Configure Git with your username and email address.
- Understand the difference between Global and Local Git configurations.
- Initialize a new Git repository.
- Clone an existing Git repository from a remote server.
- Verify Git configuration settings.
- Prepare your development environment for GitHub integration.

---

# Prerequisites

Before starting this module, ensure that you have:

- Basic knowledge of computers.
- Basic understanding of Version Control concepts.
- Internet connection.
- Administrator privileges (for installation).
- Windows, Linux, or macOS operating system.

---

# Software Requirements

The following software is recommended:

- Git
- Git Bash (Windows)
- Command Prompt / PowerShell / Terminal
- Visual Studio Code (Optional)
- GitHub Account (Optional)

---

# Installation Steps

### Step 1: Download Git

Download the latest stable version of Git from the official website.

Official Website:

https://git-scm.com

---

### Step 2: Install Git

Run the downloaded installer and follow the installation wizard.

Recommended installation options include:

- Add Git to PATH
- Install Git Bash
- Install Git GUI
- Use OpenSSH
- Checkout Windows-style, commit Unix-style line endings

After installation is complete, click **Finish**.

---

### Step 3: Verify Installation

Open Command Prompt or Git Bash and execute:

```bash
git --version
```

Example Output

```text
git version 2.53.0.windows.1
```

If the version number is displayed, Git has been installed successfully.

---

### Step 4: Configure Git

Configure your username.

```bash
git config --global user.name "Subrahmanyeswara"
```

Configure your email.

```bash
git config --global user.email "yedula2005@gmail.com"
```

---

### Step 5: Verify Configuration

Execute:

```bash
git config --list
```

Example Output

```text
user.name=Subrahmanyeswara
user.email=yedula2005@gmail.com
```

This confirms that Git has been configured successfully.

---

### Step 6: Create Your First Repository

Create a project folder.

```bash
mkdir GitDemo
```

Navigate into the folder.

```bash
cd GitDemo
```

Initialize Git.

```bash
git init
```

Example Output

```text
Initialized empty Git repository in C:/GitDemo/.git/
```

---

### Step 7: Check Repository Status

```bash
git status
```

Git displays the current state of your repository.

---

# Folder Structure

```
03-Setting-Up-Git/
│
├── README.md
├── Notes.md
└── Screenshots/
    ├── Git-Installation.png
    └── Git-Configuration.png
```

---

# Screenshots Included

## Git-Installation.png

This screenshot verifies that Git has been installed successfully by executing:

```bash
git --version
```

---

## Git-Configuration.png

This screenshot verifies the configured username and email using:

```bash
git config --list
```

---

# Key Git Configuration Commands

| Command | Description |
|----------|-------------|
| `git --version` | Displays the installed Git version |
| `git config --global user.name "Name"` | Sets the global username |
| `git config --global user.email "Email"` | Sets the global email |
| `git config --list` | Displays all Git configuration settings |
| `git init` | Initializes a new Git repository |
| `git status` | Displays the current repository status |

---

# Best Practices

- Always install the latest stable version of Git.
- Configure your Git username and email before making commits.
- Use the same email associated with your GitHub account.
- Verify Git installation after setup.
- Keep Git updated regularly.
- Initialize repositories before starting development.
- Review configuration settings using `git config --list`.
- Store projects in dedicated folders.
- Create meaningful repository names.
- Regularly back up your repositories using GitHub or another remote hosting service.

---

# Learning Outcome

After completing this module, learners will be able to:

- Install Git successfully on different operating systems.
- Configure Git with the correct user information.
- Verify installation and configuration settings.
- Initialize and manage Git repositories.
- Clone remote repositories.
- Understand Git configuration files and their scope.
- Prepare the system for advanced Git operations such as committing, branching, merging, pushing, pulling, and collaboration through GitHub.

---

# Conclusion

Setting up Git is the first practical step toward effective version control and collaborative software development. Proper installation and configuration ensure that every change made to a project is accurately tracked and attributed to the correct developer. With Git installed and configured, developers are ready to manage source code efficiently, collaborate with teams, maintain project history, and integrate with remote repositories such as GitHub.

This setup forms the foundation for all subsequent Git operations and is an essential skill for every software developer and DevOps engineer.
