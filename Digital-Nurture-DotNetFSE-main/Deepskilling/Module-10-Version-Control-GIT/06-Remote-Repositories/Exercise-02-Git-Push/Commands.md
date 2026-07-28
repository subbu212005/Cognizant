# Exercise 2: Commands

Follow these steps to practice pushing local changes to a remote repository.

### 1. Push and Set Upstream Tracking
Run the following command to push your local `main` branch to the remote repository `origin` and establish a tracking link:
```bash
git push -u origin main
```

#### Expected Output:
```text
Enumerating objects: 3, done.
Counting objects: 100% (3/3), done.
Writing objects: 100% (3/3), 241 bytes | 241.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
To https://github.com/your-username/remote-exercise.git
 * [new branch]      main -> main
branch 'main' set up to track 'origin/main'.
```

### 2. Verify Tracking Branch Configuration
Run this command to check how your local branches map to remote branches:
```bash
git branch -vv
```

#### Expected Output:
```text
* main 9c28a11 [origin/main] feat: initial commit
```
*Note: The `[origin/main]` text shows that your local branch `main` tracks `origin/main`.*

### 3. Make Another Local Change and Push
Create a second commit and push it without specifying the remote or branch name:
```bash
echo "Adding more content" >> README.md
git commit -am "docs: update README with project details"
git push
```

#### Expected Output:
```text
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Writing objects: 100% (3/3), 292 bytes | 292.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
To https://github.com/your-username/remote-exercise.git
   9c28a11..4f83b2e  main -> main
```
