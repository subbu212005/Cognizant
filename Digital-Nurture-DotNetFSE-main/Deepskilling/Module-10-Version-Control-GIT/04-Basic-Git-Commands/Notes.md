# Notes – Basic Git Commands

## Introduction

Git is a distributed version control system used to track changes in source code during software development. It allows multiple developers to work on the same project efficiently.

---

# 1. git init

Creates a new Git repository in the current directory.

### Syntax

```bash
git init
```

### Purpose

- Starts version control.
- Creates a hidden `.git` folder.

---

# 2. git clone

Downloads an existing Git repository from a remote server.

### Syntax

```bash
git clone <repository-url>
```

Example

```bash
git clone https://github.com/user/project.git
```

---

# 3. git add

Stages changes before committing.

### Add one file

```bash
git add filename
```

### Add all files

```bash
git add .
```

---

# 4. git commit

Stores staged changes permanently in Git history.

### Syntax

```bash
git commit -m "Commit message"
```

Example

```bash
git commit -m "Added login page"
```

---

# 5. git status

Displays the current repository status.

### Syntax

```bash
git status
```

Shows

- Modified files
- New files
- Staged files
- Untracked files

---

# 6. git log

Displays commit history.

### Syntax

```bash
git log
```

Useful options

```bash
git log --oneline
```

```bash
git log --graph
```

```bash
git log --all
```

---

# Basic Git Workflow

```
Create Files
      │
      ▼
git add
      │
      ▼
git commit
      │
      ▼
git log
```

---

# Best Practices

- Commit frequently.
- Write meaningful commit messages.
- Check status before committing.
- Review history using git log.
- Stage only necessary files.

---

# Summary

These commands form the foundation of Git. Mastering them is essential before learning advanced topics such as branching, merging, rebasing, and collaboration.
