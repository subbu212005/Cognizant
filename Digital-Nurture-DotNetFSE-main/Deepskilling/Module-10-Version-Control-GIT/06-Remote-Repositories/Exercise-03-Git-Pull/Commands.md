# Exercise 3: Commands

Follow these steps to fetch and integrate new commits from a remote repository.

### 1. Fetch Latest Changes from Remote
Run `git fetch` to download references and objects from the remote repository:
```bash
git fetch origin
```

### 2. Check Repository Status
Check how your local branch compares to the remote branch:
```bash
git status
```

#### Expected Output:
```text
On branch main
Your branch is behind 'origin/main' by 1 commit, and can be fast-forwarded.
  (use "git pull" to update your local branch)

nothing to commit, working tree clean
```
*Note: Your branch is "behind" because there is 1 commit on the remote that you don't have locally.*

### 3. Pull and Merge the Changes
Integrate the remote commits into your active local branch:
```bash
git pull
```

#### Expected Output:
```text
Updating 4f83b2e..5c92e10
Fast-forward
 index.html | 4 ++++
 1 file changed, 4 insertions(+)
 create mode 100644 index.html
```
*Note: `git pull` successfully fetched and merged `index.html` using a Fast-forward merge.*
