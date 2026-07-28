# Notes: Git Remote Repositories

Collaborating with others in Git is centered around syncing changes between your local repository and a remote repository hosted on a server (like GitHub, GitLab, Bitbucket, or a private server).

---

## 1. What is a Remote Repository?

A **remote repository** is a version of your project that is hosted on the internet or a network location. 
*   **Local Repository**: Resides on your local machine (your hard drive). You write code, make commits, and manage branches locally.
*   **Remote Repository**: Resides on a server. It acts as the "source of truth" or the shared central repository where team members push their changes and pull new changes.

---

## 2. Remote Naming and URLs

### The Default Remote: `origin`
When you clone a repository, Git automatically names the remote server you cloned it from **`origin`**. 
*   `origin` is just an alias (a shortcut name) for the long repository URL.
*   You can name remotes whatever you want, but by convention, the main remote is called `origin`.
*   If you collaborate with multiple remotes (e.g., in open source, where you fork a repo), you might have an `upstream` remote pointing to the original repo and an `origin` pointing to your fork.

### Remote URLs
A remote repository can be accessed via two main protocols:
1.  **HTTPS**: `https://github.com/user/repository.git`
    *   Easier to set up, but requires entering credentials (often cached using a credentials helper or Personal Access Token).
2.  **SSH**: `git@github.com:user/repository.git`
    *   Uses secure SSH keys. Once configured, you don't need to type in usernames/passwords for every push/pull.

---

## 3. Key Remote Commands

### Managing Remotes
*   **`git remote`**: Lists the names of your configured remote repositories.
*   **`git remote -v`**: Lists the names and URLs (both for fetching and pushing) of your configured remotes.
*   **`git remote add <name> <url>`**: Connects your local repository to a new remote repository.
*   **`git remote remove <name>`**: Removes a configured remote from your local settings.
*   **`git remote set-url <name> <new-url>`**: Updates the URL of an existing remote.
*   **`git remote show <name>`**: Displays detailed information about a specific remote, including tracked branches and branch status relative to the remote.

### Syncing Changes
*   **`git push <remote-name> <branch-name>`**: Uploads your local commits from `<branch-name>` to `<remote-name>`.
    *   **`-u` or `--set-upstream` flag**: Sets the default upstream branch. For example, `git push -u origin main` binds the local `main` branch to `origin/main`. Once set, you can just run `git push` or `git pull` without specifying the remote and branch names.
*   **`git fetch <remote-name>`**: Downloads all history, branches, and tags from the remote repository to your local machine.
    *   **Important**: `git fetch` **does not** modify your working files. It updates the remote-tracking branches (e.g., `origin/main`), allowing you to review changes before merging.
*   **`git pull <remote-name> <branch-name>`**: Fetches changes from the remote and immediately merges them into your current local branch.
    *   `git pull` is essentially a shorthand command for running `git fetch` followed immediately by `git merge`.

---

## 4. Understanding Tracking Branches

When working with remotes, Git tracks references using three kinds of branches:

1.  **Local Branch**: The active branch you work on directly (e.g., `main`, `feature-login`).
2.  **Remote-Tracking Branch**: A read-only reference of the state of the branch on the remote server (e.g., `origin/main`, `origin/feature-login`).
    *   These act as bookmarks that only update when you run network operations like `git fetch`, `git pull`, or `git push`.
3.  **Remote Branch**: The actual branch residing on the remote server itself.

```mermaid
graph TD
    subgraph Local Machine
        LB[Local Branch: main] -->|Merge / Rebase| RTB[Remote-Tracking Branch: origin/main]
    end
    subgraph Remote Server (e.g. GitHub)
        RB[Remote Branch: main]
    end
    RTB -.->|git fetch / git pull| RB
    LB -.->|git push| RB
```

### Checking Status relative to Remote
When your local branch is tracking a remote branch, `git status` will tell you if you are ahead, behind, or diverged:
*   **Ahead**: You have commits locally that haven't been pushed yet (e.g., "Your branch is ahead of 'origin/main' by 2 commits.").
*   **Behind**: The remote has new commits that you haven't merged locally yet (e.g., "Your branch is behind 'origin/main' by 3 commits.").
*   **Diverged**: Both you and the remote have made new commits starting from the same common ancestor. You will need to pull/merge (and resolve conflicts if any) before you can push.
