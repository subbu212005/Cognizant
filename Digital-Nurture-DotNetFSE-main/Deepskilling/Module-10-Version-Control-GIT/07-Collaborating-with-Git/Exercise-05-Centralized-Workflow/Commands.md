# Exercise 05: Reference Commands

Here is the reference sheet for syncing and resolving push rejections under a Centralized Workflow model.

---

## 💻 Commands List

### 1. Committing and Pushing Changes
Typical workflow when no conflicts occur:
```bash
git add .
git commit -m "style: Clean up container layout margins"
git push origin main
```

### 2. Resolving Out-of-Date Pushes (Rebase Strategy)
If push is rejected, pull using rebase to keep commit history linear:
```bash
# Pull remote changes and rebase local commits on top
git pull --rebase origin main

# Once rebase succeeds, push changes
git push origin main
```

### 3. Resolving Out-of-Date Pushes (Merge Strategy)
Alternatively, pull using the default merge strategy, which creates a merge commit:
```bash
# Pull remote changes and merge automatically
git pull origin main

# Once merge succeeds, push changes
git push origin main
```

### 4. Interactive Conflict Resolution during Pull --rebase
If a conflict occurs during `git pull --rebase`:
```bash
# 1. Check which files are conflicted
git status

# [Open conflicted files in editor and remove markers <<<<<<, =====, >>>>>>]

# 2. Stage the resolved files
git add src/index.js

# 3. Continue the rebase process
git rebase --continue

# 4. Push changes once rebase is complete
git push origin main
```

---

## 📝 Example Shell Session Output

```powershell
PS C:\Users\student\Projects\central-project> git push origin main
To https://github.com/my-team/central-project.git
 ! [rejected]        main -> main (non-fast-forward)
error: failed to push some refs to 'https://github.com/my-team/central-project.git'
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

PS C:\Users\student\Projects\central-project> git pull --rebase origin main
From https://github.com/my-team/central-project
 * branch            main       -> FETCH_HEAD
Auto-merging src/index.js
CONFLICT (content): Merge conflict in src/index.js
error: could not apply 3b8c9d0... feat: Add user greeting function
Resolve all conflicts manually, mark them as resolved with
"git add/rm <conflicted_files>", then run "git rebase --continue".
You can instead skip this commit: run "git rebase --skip".
To abort and get back to the state before "git rebase", run "git rebase --abort".

# [Resolve conflict in src/index.js in editor]

PS C:\Users\student\Projects\central-project> git add src/index.js

PS C:\Users\student\Projects\central-project> git rebase --continue
Successfully rebased and updated refs/heads/main.

PS C:\Users\student\Projects\central-project> git push origin main
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 8 threads
Compressing objects: 100% (3/3), done.
Writing objects: 100% (3/3), 346 bytes | 346.00 KiB/s, done.
Total 3 (delta 2), reused 0 (delta 0), pack-reused 0
To https://github.com/my-team/central-project.git
   e4f5g6h..3b8c9d0  main -> main
```
