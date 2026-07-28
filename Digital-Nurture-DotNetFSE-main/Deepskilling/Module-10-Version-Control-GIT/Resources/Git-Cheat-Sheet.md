# Git Cheat Sheet

Git is a free and open-source distributed version control system designed to handle everything from small to very large projects with speed and efficiency.

---

## 🏗️ Git Architecture & The Four Areas

To use Git effectively, it is critical to understand its database architecture. Git manages files across four distinct zones:

```
┌────────────────────────────────────────────────────────────────────────┐
│                              LOCAL MACHINE                             │
│                                                                        │
│ ┌──────────────────┐    ┌──────────────────┐    ┌──────────────────┐   │
│ │                  │    │                  │    │                  │   │   ┌──────────────────┐
│ │Working Directory │───>│   Staging Area   │───>│ Local Repository │───┼──>│Remote Repository │
│ │  (Untracked/     │    │     (Index)      │    │      (HEAD)      │   │   │  (GitHub/GitLab) │
│ │   Modified)      │    │                  │    │                  │   │   │                  │
│ └──────────────────┘    └──────────────────┘    └──────────────────┘   │   └──────────────────┘
└────────────────────────────────────────────────────────────────────────┘
```

1. **Working Directory (Workspace)**: Your local directory containing the project files you are actively modifying.
2. **Staging Area (Index)**: A preparation area (a single file within `.git`) that stores information about what will go into your next commit.
3. **Local Repository**: The `.git` directory containing all committed versions, history, and branches on your machine.
4. **Remote Repository**: A version of your project hosted on a server (like GitHub, GitLab, or Bitbucket) for collaboration.

---

## ⚙️ Configuration Setup

Configure Git with your identity. This metadata is attached to every commit you make.

| Command | Description |
| :--- | :--- |
| `git config --global user.name "Your Name"` | Set the name associated with your commits |
| `git config --global user.email "your.email@example.com"` | Set the email associated with your commits |
| `git config --global core.editor "code --wait"` | Set VS Code (or another editor) as your default editor |
| `git config --global init.defaultBranch main` | Set the default branch name to `main` |
| `git config --list` | List all current configurations |

> [!TIP]
> You can omit the `--global` flag if you want to configure settings specifically for a single repository. Project-specific configs override global configs.

---

## 🔄 Core Workflow

The standard lifecycle of any change you make in a Git repository involves the following steps:

### 1. Initialize or Clone
Start a new repository or download an existing one.
```bash
# Initialize a new Git repository in the current directory
git init

# Clone an existing repository from a remote host
git clone <repository-url>
```

### 2. Make Changes & Stage
After editing your files locally, stage them to prepare for a commit.
```bash
# View the status of files (untracked, modified, or staged)
git status

# Stage a specific file
git add <filename>

# Stage all files in the current directory
git add .
```

### 3. Commit
Save the staged snapshot to your local repository history.
```bash
# Commit staged files with a descriptive message
git commit -m "feat: add user authentication layout"

# Commit and bypass the staging area for already tracked files
git commit -am "fix: resolve navigation alignment issue"
```

### 4. Share & Sync
Send your committed changes to the remote repository.
```bash
# Push your local commits to the remote repository (first time set upstream)
git push -u origin <branch-name>

# Push subsequent updates
git push
```

---

## 🛠️ Essential Diagnostic Commands

Check status, inspect changes, and view history.

* **Check status**: `git status` lists modified, untracked, and staged files.
* **Inspect differences**:
  * `git diff` shows modifications in the working directory that are *not yet staged*.
  * `git diff --staged` shows modifications that *are staged* and ready for commit.
* **Inspect history**:
  * `git log` shows commit history for the current active branch.
  * `git log --oneline --graph --decorate` prints a clean, visual representation of history.

---

## 💡 The `.gitignore` File

To prevent Git from tracking unwanted files (such as build outputs, temporary files, IDE configs, or credentials), create a `.gitignore` file in your repository's root.

**Example `.gitignore`:**
```text
# Node dependencies
node_modules/

# Environment variables (secret credentials)
.env
.env.local

# OS generated files
.DS_Store
Thumbs.db

# Build outputs
dist/
build/
*.log
```

> [!WARNING]
> If a file is already being tracked by Git, adding it to `.gitignore` will **not** stop Git from tracking it. You must first un-track the file using `git rm --cached <file>`.
