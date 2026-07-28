# Exercise 03: Merging Branches

In this exercise, you will learn how to merge the changes from your feature branch back into the main branch, focusing on a **Fast-Forward Merge**.

## Objectives
- Switch back to the `main` branch.
- Merge the `feature-login` branch into `main`.
- Understand the mechanics of a Fast-Forward merge.

## Background Context
Merging is the process of combining two independent lines of development into one.
When you merge, Git identifies the relationship between the branch you are on (target branch) and the branch you want to merge (source branch).
If the target branch (`main`) has no new commits since the source branch (`feature-login`) diverged, Git performs a **Fast-Forward Merge**. This means Git doesn't need to create a new merge commit; it simply moves the `main` branch pointer forward to point to the same commit as `feature-login`.

## Instructions
1. Switch back to the `main` branch. Note that `login.js` disappears from your workspace because it doesn't exist on `main` yet!
2. Run the merge command to integrate `feature-login`.
3. Check your workspace: `login.js` should reappear.
4. Verify the git log to confirm the fast-forward update.

Check the **[Commands.md](./Commands.md)** file for the specific commands to run.
