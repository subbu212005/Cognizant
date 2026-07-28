# Step-by-Step Commands: GitFlow Simulation

Follow these commands to simulate a standardized GitFlow lifecycle for a feature.

### 1. Create the `develop` branch
Start on `main` and create the main integration branch, `develop`:

```bash
git switch main
git switch -c develop
```

---

### 2. Create the feature branch off `develop`
Now branch off `develop` to work on the authorization feature:

```bash
git switch -c feature/auth develop
```

---

### 3. Develop and commit the feature
Create `auth.js` and make a commit representing the completion of your feature:

```bash
echo "function auth() { console.log('Checking credentials...'); }" > auth.js
git add auth.js
git commit -m "Implement basic credentials authentication"
```

---

### 4. Merge the feature back into `develop`
Switch to `develop` and merge the feature. 

> [!TIP]
> In GitFlow, it is highly recommended to use the `--no-ff` (no fast-forward) flag when merging features. This forces Git to create a merge commit, preserving the historical existence of the feature branch in the commit graph.

```bash
git switch develop
git merge --no-ff feature/auth -m "Merge feature/auth into develop"
```

You can now safely delete the local feature branch:
```bash
git branch -d feature/auth
```

---

### 5. Release to production (`main`)
When develop is stable and ready to release, merge it into `main`. Since this is a production release, we switch to `main`, merge `develop`, and create a tag:

```bash
git switch main

# Merge develop into main
git merge --no-ff develop -m "Release v1.0.0"

# Tag the commit for release tracking
git tag -a v1.0.0 -m "Production Release v1.0.0"
```

---

### 6. Verify the final graph
Review the complete commit history showing the feature branch isolation and integration:

```bash
git log --oneline --graph --all
```

**Expected Output:**
```text
*   7a8b9c0 (HEAD -> main, tag: v1.0.0) Release v1.0.0
|\  
| *   5d6e7f8 (develop) Merge feature/auth into develop
| |\  
| | * 3c4d5e6 Implement basic credentials authentication
| |/  
|/    
* 2c3d4e5 Add base server port config
```
This graph cleanly visualizes the parallel lanes of feature branching, integration development (`develop`), and production release (`main`).
