# Common Git Commands Reference

This is a comprehensive index of common Git commands, flags, and patterns, categorized by usage.

---

## 📂 Setup & Initialization

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git init` | `git init` | Initializes a new local Git repository in the current directory. |
| `git clone` | `git clone <url>` | Clones (downloads) a remote repository to your local machine. |
| `git config` | `git config --global user.name "John Doe"` | Configures system-wide preferences, such as username and email. |

---

## 💾 Staging & Committing

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git status` | `git status` | Shows status of working directory and staging area (untracked/modified/staged files). |
| `git add` | `git add <file>` / `git add .` | Adds file changes to the staging area. Use `.` to stage all changes. |
| `git commit` | `git commit -m "<msg>"` | Commits staged changes to local repository history. |
| `git commit --amend` | `git commit --amend -m "<new-msg>"` | Overwrites/modifies the very last local commit. |
| `git rm` | `git rm <file>` | Removes files from the working directory and stages the deletion. |
| `git rm --cached` | `git rm --cached <file>` | Removes files from Git tracking but keeps them in your local directory. |
| `git mv` | `git mv <old> <new>` | Renames or moves a file, staging the rename automatically. |

---

## 🌿 Branching & Merging

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git branch` | `git branch` | Lists all local branches. The active branch is prefixed with `*`. |
| `git branch -a` | `git branch -a` | Lists all local and remote branches. |
| `git branch <name>` | `git branch feature-auth` | Creates a new branch at the current commit. |
| `git branch -d <name>` | `git branch -d feature-auth` | Deletes a branch safely (only if changes are fully merged). |
| `git branch -D <name>` | `git branch -D feature-auth` | Force deletes a branch, discarding unmerged changes. |
| `git checkout` | `git checkout <branch>` | Switches to the specified branch. |
| `git checkout -b` | `git checkout -b <branch>` | Creates a new branch and immediately switches to it. |
| `git switch` | `git switch <branch>` | A modern, safer alternative to `git checkout` for switching branches. |
| `git switch -c` | `git switch -c <branch>` | A modern alternative for creating and switching branches. |
| `git merge` | `git merge <branch>` | Integrates commits from the target branch into the current active branch. |
| `git rebase` | `git rebase <branch>` | Applies commits from the current branch on top of another branch. |

---

## 📡 Sharing & Synchronizing (Remotes)

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git remote -v` | `git remote -v` | Lists all configured remote connections and their URLs. |
| `git remote add` | `git remote add origin <url>` | Connects your local repository to a remote server. |
| `git fetch` | `git fetch` | Downloads metadata, branches, and tags from the remote repo without merging them. |
| `git pull` | `git pull` | Fetches changes from the remote tracking branch and merges them into your active branch. |
| `git push` | `git push origin <branch>` | Uploads local branch commits to the remote repository. |

---

## 🔍 Inspection & History

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git log` | `git log` | Displays chronological commit history of the current branch. |
| `git log --oneline` | `git log --oneline` | Displays commit history in a highly condensed single-line format. |
| `git show` | `git show <commit-hash>` | Shows the metadata and detailed code diff of a specific commit. |
| `git diff` | `git diff` | Displays changes in the working directory that are not yet staged. |
| `git diff --staged` | `git diff --staged` | Displays changes that are staged for the next commit. |
| `git blame` | `git blame <file>` | Displays line-by-line commit information for a specific file. |
| `git reflog` | `git reflog` | Lists every single action Git has performed (excellent for recovering lost commits). |

---

## ⏪ Undoing Changes

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git restore` | `git restore <file>` | Discards local uncommitted changes in your working directory. |
| `git restore --staged` | `git restore --staged <file>` | Unstages a file, keeping the changes in your working directory. |
| `git reset` | `git reset --soft <commit>` | Resets history; moves your branch back to `<commit>`, keeping changes staged. |
| `git reset --mixed` | `git reset --mixed <commit>` | Default reset. Resets history and unstages changes; keeps changes in working directory. |
| `git reset --hard` | `git reset --hard <commit>` | **DANGEROUS**. Discards all history, staging, and working directory changes since `<commit>`. |
| `git revert` | `git revert <commit>` | Creates a new commit that applies the exact inverse changes of `<commit>`. |

---

## 📦 Stashing (Temporary Saving)

Stashing lets you save dirty working directory modifications without committing, allowing you to switch contexts cleanly.

| Command | Usage / Example | Description |
| :--- | :--- | :--- |
| `git stash` | `git stash` / `git stash save` | Saves current dirty state (modified tracked files) onto a temporary stack. |
| `git stash list` | `git stash list` | Lists all currently stashed change states. |
| `git stash pop` | `git stash pop` | Applies the most recently stashed state and removes it from the stash stack. |
| `git stash apply` | `git stash apply` | Applies the stashed changes but keeps them saved in the stash stack. |
| `git stash drop` | `git stash drop stash@{0}` | Deletes a specific stash from the stack. |
| `git stash clear` | `git stash clear` | Removes all stashes from the stash stack. |
