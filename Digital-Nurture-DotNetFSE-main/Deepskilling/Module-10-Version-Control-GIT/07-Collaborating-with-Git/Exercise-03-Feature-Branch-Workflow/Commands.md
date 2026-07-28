# Exercise 03: Reference Commands

This reference sheet lists commands for branch creation, deletion, list management, and syncing changes within the Feature Branch Workflow.

---

## 💻 Commands List

### 1. Listing Local and Remote Branches
- **List local branches**:
  ```bash
  git branch
  ```
- **List remote branches**:
  ```bash
  git branch -r
  ```
- **List all branches (local and remote)**:
  ```bash
  git branch -a
  ```

### 2. Creating & Switching Branches
- **Create and switch to a branch**:
  ```bash
  git checkout -b feature/login-page
  ```
- **Switch back to an existing branch**:
  ```bash
  git checkout main
  ```

### 3. Synchronizing Your Feature Branch
To merge changes from `main` into your feature branch:
```bash
git checkout feature/login-page
git fetch origin
git merge origin/main
```
To rebase your feature branch onto `main`:
```bash
git checkout feature/login-page
git fetch origin
git rebase origin/main
```

### 4. Cleaning Up (Deleting Branches)
Once a PR is merged, clean up your workspace by deleting branches:
- **Delete local branch** (safely checks if merged):
  ```bash
  git branch -d feature/login-page
  ```
- **Force delete local branch** (unmerged branch):
  ```bash
  git branch -D feature/login-page
  ```
- **Delete remote branch** on origin:
  ```bash
  git push origin --delete feature/login-page
  ```

---

## 📝 Example Shell Session Output

```powershell
PS C:\Users\student\Projects\shared-project> git checkout -b feature/analytics
Switched to a new branch 'feature/analytics'

# [Implement analytics tracking script]

PS C:\Users\student\Projects\shared-project> git add src/analytics.js
PS C:\Users\student\Projects\shared-project> git commit -m "feat: Add basic mixpanel tracking script"
[feature/analytics d4e5f6g] feat: Add basic mixpanel tracking script
 1 file changed, 18 insertions(+)

# Dev A merges a change on 'main'. Let's sync:
PS C:\Users\student\Projects\shared-project> git fetch origin
remote: Enumerating objects: 5, done.
remote: Total 5 (delta 3), reused 0 (delta 0), pack-reused 2
Unpacking objects: 100% (5/5), done.
From https://github.com/my-team/shared-project
   a1b2c3d..9h8i7j6  main       -> origin/main

PS C:\Users\student\Projects\shared-project> git merge origin/main
Merge made by the 'ort' strategy.
 package.json | 2 +-
 1 file changed, 1 insertion(+), 1 deletion(-)

PS C:\Users\student\Projects\shared-project> git push origin feature/analytics
Enumerating objects: 8, done.
Writing objects: 100% (6/6), 582 bytes | 582.00 KiB/s, done.
To https://github.com/my-team/shared-project.git
 * [new branch]      feature/analytics -> feature/analytics

# [Once PR is merged on Github, clean up locally]
PS C:\Users\student\Projects\shared-project> git checkout main
Switched to branch 'main'
Your branch is behind 'origin/main' by 2 commits, and can be fast-forwarded.

PS C:\Users\student\Projects\shared-project> git pull origin main
Updating 9h8i7j6..k5l4m3n
Fast-forward
 src/analytics.js | 18 ++++++++++++++++++
 1 file changed, 18 insertions(+)

PS C:\Users\student\Projects\shared-project> git branch -d feature/analytics
Deleted branch feature/analytics (was d4e5f6g).
```
