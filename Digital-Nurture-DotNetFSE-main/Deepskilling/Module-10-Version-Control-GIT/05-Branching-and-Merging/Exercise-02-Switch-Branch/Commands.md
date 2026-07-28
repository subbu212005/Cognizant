# Step-by-Step Commands: Switching Branches

Follow these commands to switch branches, make a commit, and inspect the branch divergence.

### 1. Switch to the `feature-login` branch
You can use `git switch` (recommended for newer Git versions) or `git checkout` (traditional):

```bash
# Recommended command
git switch feature-login

# Alternative command (older Git versions)
# git checkout feature-login
```

**Expected Output:**
```text
Switched to branch 'feature-login'
```

---

### 2. Verify that HEAD has changed
List the branches. The asterisk `*` should now be next to `feature-login`:

```bash
git branch
```

**Expected Output:**
```text
* feature-login
  main
```

---

### 3. Create a new file and commit it
Now that you are on `feature-login`, create a new file representing your login feature and commit the changes:

```bash
# Create login.js
echo "function login() { console.log('User logged in!'); }" > login.js

# Stage and commit the file
git add login.js
git commit -m "Add basic login function"
```

---

### 4. Verify branch divergence
Run the following log command to view the commit graph. This shows both branches and where `HEAD` currently points:

```bash
git log --oneline --graph --all
```

**Expected Output:**
```text
* 2c3d4e5 (HEAD -> feature-login) Add basic login function
* 1a2b3c4 (main) Initial commit
```

> [!NOTE]
> The commit `2c3d4e5` is the active commit (`HEAD`) and belongs to `feature-login`. The `main` branch is still pointing to the older commit `1a2b3c4`.
