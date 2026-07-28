# Step-by-Step Commands: Merging Branches

Follow these commands to switch to the target branch and merge your changes.

### 1. Switch back to the `main` branch
You must always switch to the branch you want to merge **into**:

```bash
git switch main
```

**Expected Output:**
```text
Switched to branch 'main'
```

If you look at your file list (e.g. `ls` or `dir`), `login.js` will no longer be visible because it only exists in `feature-login`.

---

### 2. Merge `feature-login` into `main`
Run the merge command:

```bash
git merge feature-login
```

**Expected Output:**
```text
Updating 1a2b3c4..2c3d4e5
Fast-forward
 login.js | 1 +
 1 file changed, 1 insertion(+)
 create mode 100644 login.js
```

Observe the words **"Fast-forward"** in the output. This confirms Git did not create a new merge commit, but simply shifted the pointer.

---

### 3. Verify the git log
Verify that both `main` and `feature-login` now point to the same commit:

```bash
git log --oneline --graph --all
```

**Expected Output:**
```text
* 2c3d4e5 (HEAD -> main, feature-login) Add basic login function
* 1a2b3c4 Initial commit
```
Both pointers are now aligned at `2c3d4e5`.

---

### 4. Delete the merged feature branch (Optional Cleanup)
Since the feature is fully merged, you can safely delete the branch pointer:

```bash
git branch -d feature-login
```
