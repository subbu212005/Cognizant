# Git Branching & Merging

Welcome to the **Branching and Merging** module. This module is designed to give you hands-on experience with how Git manages branches, merges diverged work, resolves merge conflicts, and structures teamwork via standard branching models like GitFlow.

## Module Objectives

By the end of this module, you will understand:
1. What a Git branch is (a lightweight, mutable pointer to a commit).
2. How to create, switch, delete, and list branches.
3. The difference between **Fast-Forward** and **Three-Way (Merge Commit)** merges.
4. How to confidently identify and resolve merge conflicts.
5. How a collaborative Git model like **GitFlow** organizes development.

---

## Exercise Outline

This module is split into 5 progressive exercises:

| Exercise | Topic | Primary Commands |
| :--- | :--- | :--- |
| **[Exercise 01](./Exercise-01-Create-Branch/)** | **Create Branch** | `git branch <branch-name>` |
| **[Exercise 02](./Exercise-02-Switch-Branch/)** | **Switch Branch** | `git switch <branch-name>` / `git checkout` |
| **[Exercise 03](./Exercise-03-Merge-Branches/)** | **Merge Branches** | `git merge <branch-name>` |
| **[Exercise 04](./Exercise-04-Resolve-Merge-Conflict/)** | **Resolve Merge Conflict** | `git merge` & manual conflict editing |
| **[Exercise 05](./Exercise-05-GitFlow-Workflow/)** | **GitFlow Workflow** | Feature branching lifecycle |

---

## Getting Started

To follow along with these exercises, ensure you have Git installed on your system. Open your terminal or Git Bash, create a clean directory for testing, and initialize a new Git repository:

```bash
# Create a test directory
mkdir git-practice
cd git-practice

# Initialize Git
git init -b main
```

Refer to the individual exercise folders to get started! Read the **[Notes.md](./Notes.md)** file for a deep dive into the theoretical aspects of branching and merging.
