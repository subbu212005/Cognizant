# Exercise 02: Reference Commands

Here is a summary of the terminal commands used to create branches, commit code, and push branches to your origin remote to set up a Pull Request.

---

## 💻 Commands List

### 1. Update and Switch to Main
Switch to your local main branch and pull updates from upstream to ensure your work is based on the latest codebase.
```bash
git checkout main
git pull upstream main
```

### 2. Create a Feature Branch
Create a new branch and check it out immediately.
```bash
git checkout -b feature/my-new-feature
```
*Tip: This is a shortcut for:*
```bash
git branch feature/my-new-feature
git checkout feature/my-new-feature
```

### 3. Check Working Tree Status
Review modified, deleted, and untracked files in your directory.
```bash
git status
```

### 4. Stage Changes
Add specific files or all modified files to the staging area.
```bash
git add file1.md
# Or add all modified files: git add .
```

### 5. Commit Changes
Save staged snapshots to the local git history. Keep messages imperative (e.g. "Add...", "Fix...").
```bash
git commit -m "feat: Add profile validation rules"
```

### 6. Push Branch to Origin
Publish your local branch to your remote fork repository (`origin`).
```bash
git push -u origin feature/my-new-feature
```
*Note: The `-u` flag sets the remote tracking connection, meaning future pushes/pulls on this branch can just use `git push` or `git pull`.*

---

## 📝 Example Shell Session Output

```powershell
PS C:\Users\student\Projects\Spoon-Knife> git checkout main
Already on 'main'
Your branch is up to date with 'origin/main'.

PS C:\Users\student\Projects\Spoon-Knife> git pull upstream main
From https://github.com/octo-org/Spoon-Knife
 * branch            main       -> FETCH_HEAD
Updating a1b2c3d..e4f5g6h
Fast-forward
 index.html | 2 +-
 1 file changed, 1 insertion(+), 1 deletion(-)

PS C:\Users\student\Projects\Spoon-Knife> git checkout -b feature/update-readme
Switched to a new branch 'feature/update-readme'

# [Modify README.md in editor]

PS C:\Users\student\Projects\Spoon-Knife> git status
On branch feature/update-readme
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   README.md

no changes added to commit (use "git add" and/or "git commit -a")

PS C:\Users\student\Projects\Spoon-Knife> git add README.md

PS C:\Users\student\Projects\Spoon-Knife> git commit -m "docs: Update readme instructions for setup"
[feature/update-readme 7b8c9d0] docs: Update readme instructions for setup
 1 file changed, 4 insertions(+)

PS C:\Users\student\Projects\Spoon-Knife> git push -u origin feature/update-readme
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 8 threads
Compressing objects: 100% (3/3), done.
Writing objects: 100% (3/3), 328 bytes | 328.00 KiB/s, done.
Total 3 (delta 2), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (2/2), completed with 2 local objects.
remote: 
remote: Create a pull request for 'feature/update-readme' on GitHub by visiting:
remote:      https://github.com/octocat/Spoon-Knife/pull/new/feature/update-readme
remote: 
To https://github.com/octocat/Spoon-Knife.git
 * [new branch]      feature/update-readme -> feature/update-readme
branch 'feature/update-readme' set up to track 'origin/feature/update-readme'.
```
