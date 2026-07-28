# Exercise 02: Switching Branches

In this exercise, you will learn how to switch between different branches and understand the role of the `HEAD` pointer.

## Objectives
- Switch from `main` to your newly created branch `feature-login`.
- Make a commit on the `feature-login` branch.
- Visualize how the `HEAD` pointer and the branch pointers diverge.

## Background Context
Creating a branch only creates the pointer. To start working on that branch, you must switch your active working directory to it. 
In newer versions of Git (v2.23+), the `git switch` command is preferred for switching branches, while older versions use `git checkout`. 
When you switch branches, Git changes the `HEAD` pointer to point to the branch name, and updates the files in your working directory to match that branch's snapshot.

## Instructions
1. Switch to the `feature-login` branch.
2. Confirm that `HEAD` has shifted by checking the branch status.
3. Modify a file (e.g., add login logic in `login.js`) and commit the change.
4. Observe that `feature-login` moves forward by one commit, while `main` remains at the initial commit.

Check the **[Commands.md](./Commands.md)** file for the specific commands to run.
