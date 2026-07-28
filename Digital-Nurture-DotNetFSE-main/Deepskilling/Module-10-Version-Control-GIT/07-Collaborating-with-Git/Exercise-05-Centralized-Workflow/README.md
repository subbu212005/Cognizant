# Exercise 05: Centralized Workflow & Conflict Resolution

In this exercise, you will learn about the **Centralized Workflow**, which mirrors traditional version control systems (like SVN) where developers commit directly to a single shared remote branch (usually `main`). You will also learn how to handle push rejections and resolve merge conflicts.

---

## 💡 Key Concepts

### Centralized Workflow Model
In this workflow:
- The central repository has only one main branch (e.g., `main`).
- All developers clone this repository, make changes locally on their `main` branch, and push directly to the remote `main` branch.
- **Limitation**: If Developer A pushes updates to the central repository, and then Developer B tries to push their own changes without pulling Developer A's changes first, Git will reject the push.

### Push Rejections
When your local repository is behind the remote repository, Git rejects your push to prevent overwriting other people's work. The error message looks like:
```text
error: failed to push some refs to 'https://github.com/org/repo.git'
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
```

### Resolving Push Rejections
To resolve this rejection, you must pull the remote changes first. You have two options:
1. **Merge on Pull (`git pull`)**: Fetches remote changes and merges them, creating a merge commit in your history.
2. **Rebase on Pull (`git pull --rebase`)**: Fetches remote changes and applies your local commits on top of them. This keeps a linear history without extra merge commits. (Recommended)

---

## 🛠️ Step-by-Step Instructions

### Step 1: Clone the Repository
Clone the central repository and navigate to it:
```bash
git clone https://github.com/YOUR-TEAM/central-project.git
cd central-project
```

### Step 2: Make Changes Locally
Edit a file (e.g., `src/index.js`) and commit your changes to your local `main` branch:
```bash
git add src/index.js
git commit -m "feat: Add user greeting function"
```

### Step 3: Attempt to Push (and Encounter Rejection)
If someone else pushed changes to the remote repository while you were editing, your push will fail:
```bash
git push origin main
```
*(Git prints the "Updates were rejected" error message).*

### Step 4: Pull and Integrate Remote Changes
Pull the remote changes using the rebase strategy to keep history clean:
```bash
git pull origin main --rebase
```

### Step 5: Handle Merge Conflicts (If they occur)
If you and another developer edited the same lines of code, Git will stop the pull/rebase and mark the files as conflicted.
1. Run `git status` to identify the conflicted files.
2. Open the conflicted files. Find the conflict markers:
   ```markdown
   <<<<<<< HEAD
   // Code currently on the remote server
   =======
   // Code you wrote locally
   >>>>>>> [commit-hash]
   ```
3. Edit the file to select the correct code and delete the conflict markers.
4. Stage the resolved files:
   ```bash
   git add src/index.js
   ```
5. Continue the rebase:
   ```bash
   git rebase --continue
   ```

### Step 6: Push Again
Now that your local branch contains both your changes and the remote changes, push successfully:
```bash
git push origin main
```

---

## 🎯 Verification Checklist

1. Run `git log --oneline --graph` to verify the history. If you used `--rebase`, the commit history should be a single straight line.
2. Verify that the files on GitHub contain both your edits and the edits of your teammate.
3. Review the conflict and sync topology diagram in `Output.png`.

Refer to [Commands.md](Commands.md) for terminal command notes.
