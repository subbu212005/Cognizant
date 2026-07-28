# Step-by-Step Commands: Resolving Merge Conflicts

Follow these commands to simulate a merge conflict, analyze it, and resolve it.

### 1. Create a base file on `main`
Ensure you are on the `main` branch, then create `config.txt`:

```bash
git switch main

# Create config.txt with basic line
echo "server_port = 8080" > config.txt

git add config.txt
git commit -m "Add base server port config"
```

---

### 2. Create `dev-a` and modify the port
Create and switch to `dev-a`, change the port to `9000`, and commit:

```bash
git switch -c dev-a

# Modify the port
echo "server_port = 9000" > config.txt

git add config.txt
git commit -m "Update server port to 9000 in dev-a"
```

---

### 3. Create `dev-b` and modify the same line differently
Switch back to `main`, then branch off to `dev-b`. Change the port to `3000` and commit:

```bash
git switch main
git switch -c dev-b

# Modify the port differently
echo "server_port = 3000" > config.txt

git add config.txt
git commit -m "Update server port to 3000 in dev-b"
```

---

### 4. Merge `dev-a` into `main`
Switch to `main` and merge `dev-a`. This will be a standard fast-forward merge:

```bash
git switch main
git merge dev-a
```

---

### 5. Attempt to merge `dev-b` (Triggers Conflict)
Now, try to merge `dev-b` into `main`. Since `dev-b` modified the same line from the base commit, but `main` already updated it to `9000` (via `dev-a`), Git cannot auto-merge:

```bash
git merge dev-b
```

**Expected Output:**
```text
Auto-merging config.txt
CONFLICT (content): Merge conflict in config.txt
Automatic merge failed; fix conflicts and then commit the result.
```

---

### 6. Inspect the conflict markers
Open `config.txt` in a text editor. You will see:

```text
<<<<<<< HEAD
server_port = 9000
=======
server_port = 3000
>>>>>>> dev-b
```

---

### 7. Resolve the conflict
Decide to keep port `9000` (or set a new port like `80` if needed). Edit the file to remove conflict markers so it looks exactly like this:

```text
server_port = 9000
```

---

### 8. Stage and commit the merge
Tell Git the conflict is resolved by staging and committing the file:

```bash
# Stage the resolved file
git add config.txt

# Complete the merge commit
git commit -m "Merge dev-b into main, resolving conflict in favor of port 9000"
```

---

### 9. Verify the commit history
Verify that a new 3-way merge commit has been created:

```bash
git log --oneline --graph --all
```

**Expected Output:**
```text
*   d4e5f6g (HEAD -> main) Merge dev-b into main, resolving conflict in favor of port 9000
|\  
| * c2b3a4f (dev-b) Update server port to 3000 in dev-b
* | a1b2c3d (dev-a) Update server port to 9000 in dev-a
|/  
* 2c3d4e5 Add base server port config
```
Notice the branch split and merge-commit convergence in the graph.
