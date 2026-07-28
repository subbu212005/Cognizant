# Collaborating with Git: Core Study Notes

When working on software projects within a team, Git is the primary tool used to coordinate changes. This document details the essential concepts, commands, and strategies for collaborating with Git.

---

## 1. Remote Repositories & Connections

A remote repository is a copy of your project hosted on the internet or a network server (such as GitHub, GitLab, or Bitbucket).

### Remotes: `origin` vs. `upstream`
When working on collaborated projects (especially using forks), you often interact with two different remote repositories:
1. **`origin`**: The remote repository that belongs to *your* personal account. It is the repository you cloned directly to your computer. You have read and write (push) access to it.
2. **`upstream`**: The original project repository owned by another user or organization. You typically have read-only access to it. You sync your local repository with it to stay up-to-date.

```
       ┌────────────────────────┐
       │  Upstream Repository   │ (Original Project)
       └───────────┬────────────┘
                   │
                   │ Fork
                   ▼
       ┌────────────────────────┐
       │   Origin Repository    │ (Your Personal Copy)
       └───────────┬────────────┘
                   │
         Clone /   │ Push /
         Pull      ▼ Pull
       ┌────────────────────────┐
       │    Local Repository    │ (Your Computer)
       └────────────────────────┘
```

### Essential Remote Commands
- **View configured remotes**:
  ```bash
  git remote -v
  ```
- **Add a new remote link**:
  ```bash
  git remote add <name> <url>
  # Example: git remote add upstream https://github.com/original-owner/repo.git
  ```
- **Rename a remote**:
  ```bash
  git remote rename <old-name> <new-name>
  ```
- **Remove a remote**:
  ```bash
  git remote remove <name>
  ```

---

## 2. Syncing & Branch Tracking

### Remote-Tracking Branches
Remote-tracking branches are references to the state of branches in your remote repositories. They are read-only branches that move automatically whenever you connect to the remote (using `git fetch` or `git pull`).
- They are named as `<remote>/<branch>` (e.g., `origin/main`, `upstream/main`).

### Fetch vs. Pull
It is vital to understand the difference between fetching and pulling:

- **`git fetch <remote>`**:
  - Downloads the latest commits, files, and branches from the specified remote.
  - Updates your remote-tracking branches (e.g., `origin/main`).
  - **Does not** modify your working directory or merge changes into your current local branch. It is completely safe.

- **`git pull <remote> <branch>`**:
  - Performs a `git fetch` first.
  - Immediately runs `git merge` to integrate the fetched commits into your currently checked-out local branch.
  - Equivalent to:
    ```bash
    git fetch remote
    git merge remote/branch
    ```

> [!TIP]
> Use `git fetch` to review remote changes before merging them, especially in active shared codebases.

---

## 3. Merging vs. Rebasing

Integrating changes from one branch into another can be done using two primary methods: merging or rebasing.

| Feature | Git Merge | Git Rebase |
| :--- | :--- | :--- |
| **History** | Preserves the exact chronological history and creation of merge commits. | Rewrites commit history to create a clean, linear sequence of commits. |
| **Conflict Resolution** | Done once during the merge commit. | Done commit-by-commit; you may have to resolve conflicts multiple times. |
| **Traceability** | Easy to trace where a feature branch joined main. | History looks like all work happened sequentially on main. |
| **Safety** | Non-destructive; does not modify existing commit IDs. | Destructive; creates new commit hashes. Avoid rebasing shared public branches. |

---

## 4. Resolving Merge Conflicts

A merge conflict occurs when Git cannot automatically decide how to integrate changes from two branches. This happens when:
- Two developers modify the **same line(s)** of the **same file**.
- One developer deletes a file that another developer modified.

### Identifying Conflict Markers
When a conflict occurs, Git pauses the merge process and marks the file with conflict markers:

```markdown
<<<<<<< HEAD
This is the line modified in your current (local) branch.
=======
This is the line modified in the branch you are merging in (remote/incoming).
>>>>>>> feature-branch
```

### Steps to Resolve Conflicts
1. **Find the conflicted files**: Run `git status` to see files listed under "Unmerged paths".
2. **Open the files**: Locate the conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`).
3. **Decide what code to keep**: Edit the file to keep the desired code and delete all conflict markers.
4. **Stage the resolved files**: Run `git add <filename>` to signal to Git that the conflict is resolved.
5. **Commit the resolution**: Run `git commit` to finalize the merge commit.

---

## 5. Overview of Git Workflows

### A. Centralized Workflow
- **Model**: Everyone clones the central repo and pushes/pulls directly to a single shared branch (usually `main`).
- **Best for**: Small teams, simple projects, transition from SVN.
- **Limitation**: High chance of push rejections due to out-of-date local repositories, leading to frequent manual merges/rebases.

### B. Feature Branch Workflow
- **Model**: All feature development takes place in dedicated, temporary branches instead of the shared `main` branch. Developers push features to the shared repository and submit Pull Requests to merge them back to `main`.
- **Best for**: Standard product development teams.
- **Benefit**: Keeps `main` stable, enables code reviews (Pull Requests) before merging.

### C. Forking Workflow
- **Model**: Instead of using a single shared repository, every developer has their own remote repository (`origin`) and pushes code to it. Contributions to the official repository (`upstream`) are made via Pull Requests.
- **Best for**: Open-source projects, large teams, untrusted contributors.
- **Benefit**: No write-access control management needed for the official repository.
