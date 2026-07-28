# Exercise 04: Forking Workflow

In this exercise, you will explore the **Forking Workflow**, which is the gold standard for open-source project contributions and distributed teams. You will learn how to maintain a fork, sync changes from the upstream repository, and resolve diverged branches.

---

## 💡 Key Concepts

### Workflow Overview
The Forking Workflow does not require developers to have write access to the central repository. Instead, every developer has a personal server-side repository (a **fork**).
- Developers push branches containing features to their own fork (`origin`).
- Developers pull updates from the original repository (`upstream`).
- Contributions are integrated into the main project by submitting a **Pull Request** from the developer's fork to the official repository.

### Syncing Your Fork
Because the official project repository (`upstream`) is constantly receiving commits from other contributors, your fork and local clone will fall out of date. To sync your local repository:
1. Fetch latest commits from `upstream`.
2. Merge `upstream/main` into your local `main` branch.
3. Push your updated local `main` branch to your fork (`origin/main`).

```text
  Upstream Repository (original)
      │
      │ git fetch upstream
      ▼
  Local Repository (PC) ──git push origin main──> Origin Repository (fork)
```

---

## 🛠️ Step-by-Step Instructions

Assuming you have added the `upstream` remote from **Exercise 01**:

### Step 1: Update Your Local Main Branch
Make sure your local copy of `main` is completely in sync with the official project:
```bash
git checkout main
git fetch upstream
git merge upstream/main
```
*(If no local commits were made on `main`, this will perform a clean **fast-forward merge**).*

### Step 2: Push Synced Main to Your Fork
Keep your remote GitHub fork repository up to date with the original upstream project:
```bash
git push origin main
```

### Step 3: Create a Feature Branch
Create a new branch off the freshly synced `main`:
```bash
git checkout -b feature/user-profile
```

### Step 4: Rebase Feature Branch (Optional but Recommended)
If the upstream repository is updated *while* you are working on your feature branch, rebase your feature branch instead of merging. Rebasing rewrites history so your new commits are placed on top of the newest upstream code, maintaining a clean, linear history.

```bash
# 1. Fetch latest upstream changes
git fetch upstream

# 2. Rebase feature branch onto the upstream main
git checkout feature/user-profile
git rebase upstream/main
```
If conflicts occur during rebase:
1. Git will pause. Open the conflicted files and resolve the differences.
2. Run `git add <resolved-files>`.
3. Run `git rebase --continue` (do *not* run `git commit`).
4. Repeat if there are multiple commits with conflicts.

### Step 5: Push and Open Pull Request
Push the feature branch to your fork. If you rebased and previously pushed this branch, you may need to force-push using the safe `--force-with-lease` flag:
```bash
git push origin feature/user-profile --force-with-lease
```
Submit the Pull Request on GitHub.

---

## 🎯 Verification Checklist

1. Run `git remote -v` to ensure `origin` is your fork and `upstream` is the original repository.
2. In your GitHub PR, confirm that the commit history is clean and linear (commits are ordered on top of the latest upstream commits).
3. Refer to the flow lifecycle diagram in `Output.png` for a visual map.

See [Commands.md](Commands.md) for terminal syntax guides.
