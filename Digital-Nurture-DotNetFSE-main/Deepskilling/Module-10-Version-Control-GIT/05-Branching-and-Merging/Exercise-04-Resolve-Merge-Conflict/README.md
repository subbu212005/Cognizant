# Exercise 04: Resolving Merge Conflicts

In this exercise, you will artificially construct and resolve a merge conflict in Git.

## Objectives
- Create two branches that modify the exact same line of the same file.
- Attempt to merge the branches to trigger a merge conflict.
- Learn how to read Git conflict markers.
- Manually resolve the conflict and complete the merge commit.

## Background Context
Merge conflicts happen when Git is unable to automatically integrate changes from one branch into another. This typically occurs when two people modify the same lines of a file, or one person deletes a file that another person is modifying.
When Git encounters a conflict, it marks the conflict in the files using markers:
- `<<<<<<< HEAD` : Beginning of the active branch's changes.
- `=======` : Divider between the two branches' changes.
- `>>>>>>> <branch-name>` : End of the incoming branch's changes.

Your job as a developer is to open the conflicted file, decide which version (or combination of both) is correct, delete the markers, stage the resolved file, and commit.

## Instructions
1. Create a base file named `config.txt` on `main` and commit it.
2. Create and switch to a branch `dev-a`, edit the file, and commit.
3. Switch back to `main`, create a branch `dev-b`, edit the *exact same line* of `config.txt`, and commit.
4. Switch back to `main` and merge `dev-a`. (This will succeed as a Fast-Forward merge).
5. Attempt to merge `dev-b` into `main`. This will fail with a conflict.
6. Open `config.txt`, resolve the conflict, stage, and commit.

Check the **[Commands.md](./Commands.md)** file for the specific commands to run.
