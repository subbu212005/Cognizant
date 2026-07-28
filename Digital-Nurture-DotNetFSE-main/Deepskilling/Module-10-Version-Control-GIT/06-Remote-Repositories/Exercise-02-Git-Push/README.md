# Exercise 2: Git Push

## Goal
Learn how to push commits from your local repository to a remote repository and set up upstream tracking for a branch.

## Scenario
You have successfully added a remote URL (origin) to your repository. Now you need to upload your local commits to the server. You want to configure the local `main` branch to track the remote `main` branch so that pushing and pulling in the future becomes seamless.

## Steps

1.  **Commit more changes**: Make sure you have commits on your local branch (e.g., `main`).
2.  **Push and set upstream**: Use `git push -u origin main` to upload the commits and bind the local branch to the remote branch.
3.  **Confirm the push**: Verify on the remote (conceptually) or check `git branch -vv` to verify that the upstream tracking has been set correctly.
4.  **Push a second commit**: Create another commit and push using the simplified `git push` command, validating that the upstream connection works.

## Files
*   **[Commands.md](Commands.md)**: Contains the exact step-by-step commands to perform this exercise.
*   **[Output.png](Output.png)**: Terminal screenshot showing the successful output of the initial upstream push.
