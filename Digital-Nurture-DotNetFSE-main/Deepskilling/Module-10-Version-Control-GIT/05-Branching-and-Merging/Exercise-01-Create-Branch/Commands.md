# Step-by-Step Commands: Creating a Branch

Follow these commands to create and inspect a new Git branch.

### 1. Initialize repository and make initial commit
If you haven't done so, initialize a repository and make an initial commit so that Git has a baseline history:

```bash
# Initialize repository with 'main' as default branch
git init -b main

# Create a sample file
echo "# Git Practice" > README.md

# Stage and commit the file
git add README.md
git commit -m "Initial commit"
```

---

### 2. Create the new branch
Create a branch named `feature-login` using the `git branch` command:

```bash
git branch feature-login
```

> [!NOTE]
> This command creates the pointer `feature-login` pointing to the exact same commit as `main`. Note that your active branch remains `main` (you haven't switched yet).

---

### 3. Verify the branches
List all local branches in the repository:

```bash
git branch
```

**Expected Output:**
```text
  feature-login
* main
```

The asterisk `*` indicates that you are currently on the `main` branch.

---

### 4. Inspect branch details (verbose mode)
To see which commit each branch points to, use the verbose flag:

```bash
git branch -v
```

**Expected Output:**
```text
  feature-login 1a2b3c4 Initial commit
* main          1a2b3c4 Initial commit
```
Both branches point to the exact same commit hash.
