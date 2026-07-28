# Exercise 3: Git Pull

## Goal
Learn how to retrieve and integrate new changes from a remote repository into your local branch.

## Scenario
Another collaborator has pushed commits to the remote repository. Your local workspace is now out of date. You will fetch the updates to review what changed, check your repository status (which should show you are behind), and then pull the changes to bring your local repository up to date.

## Steps

1.  **Fetch changes**: Run `git fetch origin` to download the new commits and update your remote-tracking branches without merging them yet.
2.  **Verify status**: Run `git status` to see how many commits your branch is behind.
3.  **Review changes (Optional)**: Run `git log main..origin/main` to see the commits that exist on the remote but not in your local branch.
4.  **Pull changes**: Run `git pull` to fetch and automatically merge the changes into your local branch.

## Files
*   **[Commands.md](Commands.md)**: Contains the exact step-by-step commands to perform this exercise.
*   **[Output.png](Output.png)**: Terminal screenshot showing the successful output of `git pull`.
