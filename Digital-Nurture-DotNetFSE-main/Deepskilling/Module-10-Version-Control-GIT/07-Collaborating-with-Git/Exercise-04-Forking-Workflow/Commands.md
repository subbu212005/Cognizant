# Exercise 04: Reference Commands

This document contains commands for fetching, merging, rebasing, and syncing remotes in the Forking Workflow.

---

## 💻 Commands List

### 1. Sync Fork Remote via Local Branch
Update your local `main` branch with the upstream project, then push to update your remote fork (`origin`).
```bash
# Checkout main branch
git checkout main

# Fetch changes from upstream
git fetch upstream

# Merge upstream main into local main
git merge upstream/main

# Push updated local main to origin fork
git push origin main
```

### 2. Syncing Your Active Feature Branch (Merge Strategy)
Integrate upstream updates into your feature branch using `merge`.
```bash
git checkout feature/my-feature
git fetch upstream
git merge upstream/main
```

### 3. Syncing Your Active Feature Branch (Rebase Strategy)
Apply your commits on top of the latest upstream commits using `rebase`.
```bash
git checkout feature/my-feature
git fetch upstream
git rebase upstream/main
```

### 4. Handling Conflicts During Rebase
If Git finds conflicts during a rebase, follow these commands:
```bash
# 1. Check which files have conflicts
git status

# [Fix conflicts manually in your code editor]

# 2. Stage the resolved files
git add path/to/resolved-file.txt

# 3. Continue the rebase process
git rebase --continue

# Note: If you want to abort the rebase and go back to original state:
# git rebase --abort
```

### 5. Pushing Rebased Branch
If you have already pushed your branch to your fork before rebasing, Git will reject a standard push. You must force push to overwrite your remote fork branch with the new rebased history. Always use `--force-with-lease` for safety.
```bash
git push origin feature/my-feature --force-with-lease
```

---

## 📝 Example Shell Session Output

```powershell
PS C:\Users\student\Projects\Spoon-Knife> git checkout feature/add-styles
Switched to branch 'feature/add-styles'

PS C:\Users\student\Projects\Spoon-Knife> git fetch upstream
From https://github.com/octo-org/Spoon-Knife
 * branch            main       -> FETCH_HEAD

PS C:\Users\student\Projects\Spoon-Knife> git rebase upstream/main
Auto-merging css/style.css
CONFLICT (content): Merge conflict in css/style.css
error: could not apply 7b8c9d0... style: Add dark mode card backgrounds
Resolve all conflicts manually, mark them as resolved with
"git add/rm <conflicted_files>", then run "git rebase --continue".
You can instead skip this commit: run "git rebase --skip".
To abort and get back to the state before "git rebase", run "git rebase --abort".

# [Resolve conflict in css/style.css editor]

PS C:\Users\student\Projects\Spoon-Knife> git add css/style.css

PS C:\Users\student\Projects\Spoon-Knife> git rebase --continue
Successfully rebased and updated refs/heads/feature/add-styles.

PS C:\Users\student\Projects\Spoon-Knife> git push origin feature/add-styles --force-with-lease
Enumerating objects: 7, done.
Writing objects: 100% (5/5), 450 bytes | 450.00 KiB/s, done.
To https://github.com/octocat/Spoon-Knife.git
 + 9f8e7d6...7b8c9d0 feature/add-styles -> feature/add-styles (forced update)
```
