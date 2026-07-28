# Exercise 03: Feature Branch Workflow

In this exercise, you will learn how to implement the **Feature Branch Workflow** within a team working on a shared central repository. 

Unlike the Forking Workflow, in the Feature Branch Workflow all developers have push access to a single shared repository, and they push their work to branches hosted directly in that central repository.

---

## 💡 Key Concepts

### Core Idea
The core idea of the Feature Branch Workflow is that **all feature development should take place in a dedicated branch instead of the `main` branch**. 
- This encapsulation makes it easy for multiple developers to work on separate features without disturbing the main codebase.
- It guarantees that the `main` branch only contains stable, buildable, and production-ready code.

### Workflow Process
```text
[Clone Shared Repo] ──> [Create Feature Branch] ──> [Develop & Commit]
                                                             │
[Merge via PR] <── [Review & Discuss] <── [Push Branch] <────┘
```

1. **Create Branch**: Create a local branch off `main` for your feature.
2. **Commit Work**: Make changes and commit locally.
3. **Push to Central Remote**: Push the branch directly to the shared repository.
4. **Open a Pull Request**: Submit a Pull Request comparing your feature branch to the central `main` branch.
5. **Code Review & Merge**: Once approved and tests pass, the PR is merged into `main`. The feature branch is then deleted.

---

## 🛠️ Step-by-Step Instructions

### Step 1: Clone the Shared Repository
Clone the central repository (in this workflow, you do not fork):
```bash
git clone https://github.com/YOUR-TEAM/shared-project.git
cd shared-project
```

### Step 2: Create a Feature Branch locally
Create a feature branch using a naming convention:
```bash
git checkout -b feature/user-authentication
```
*Common naming conventions:*
- `feature/<name>` or `feat/<name>`
- `bugfix/<issue-number>` or `fix/<name>`
- `hotfix/<name>`

### Step 3: Implement and Commit Changes
Edit code files locally and make atomic commits:
```bash
git add src/login.js
git commit -m "feat: Add Google OAuth provider integration"
```

### Step 4: Keep Your Feature Branch Synchronized
If other team members merge features to `main` while you are working, keep your branch up-to-date to prevent conflicts later:
```bash
# Get remote updates
git fetch origin

# Merge updates into your feature branch
git checkout feature/user-authentication
git merge origin/main
```
*(Alternatively, you can use `git rebase origin/main` to maintain a linear history).*

### Step 5: Push Branch and Create Pull Request
Push your branch directly to the central remote:
```bash
git push origin feature/user-authentication
```
Go to the shared repository on GitHub and open a Pull Request from `feature/user-authentication` into `main`.

---

## 🎯 Verification Checklist

1. Run `git branch -r` to check remote branches. You should see your branch listed on the central remote:
   ```text
   origin/main
   origin/feature/user-authentication
   ```
2. The central repository's commit history should show that the feature branch diverged from `main`, received commits, and was integrated back via a merge commit.
3. Review the git branch visualization diagram in `Output.png`.

Refer to [Commands.md](Commands.md) for terminal references.
