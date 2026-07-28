# Exercise 4: Commands

Follow these steps to manage remote and local tracking branches.

### 1. List Remote-Tracking Branches
List only the branches stored on the remote repository:
```bash
git branch -r
```

#### Expected Output:
```text
  origin/HEAD -> origin/main
  origin/main
  origin/feature-login
  origin/old-feature
```

### 2. List All Branches (Local and Remote)
List all branches, displaying local branches in standard color and remote branches (usually in red text):
```bash
git branch -a
```

#### Expected Output:
```text
* main
  remotes/origin/HEAD -> origin/main
  remotes/origin/main
  remotes/origin/feature-login
  remotes/origin/old-feature
```

### 3. Track a Remote Branch Locally
Check out the remote branch `feature-login`. Git will notice it exists on the remote and automatically create a matching local tracking branch:
```bash
git checkout feature-login
```
*(Or in modern Git: `git switch feature-login`)*

#### Expected Output:
```text
Branch 'feature-login' set up to track remote branch 'feature-login' from 'origin'.
Switched to a new branch 'feature-login'
```

### 4. Delete a Branch on the Remote Server
Delete the deprecated branch `old-feature` from the remote repository:
```bash
git push origin --delete old-feature
```

#### Expected Output:
```text
To https://github.com/your-username/remote-exercise.git
 - [deleted]         old-feature
```
