# Exercise 1: Commands

To practice adding a remote repository, open a terminal on your computer and execute the following commands in an empty directory.

### 1. Initialize a Local Git Repository
Create a directory named `remote-exercise`, navigate inside it, and initialize a fresh Git repository:
```bash
mkdir remote-exercise
cd remote-exercise
git init
```

### 2. Add an Initial Commit
Create a sample text file, stage it, and commit it:
```bash
echo "# My Local Git Project" > README.md
git add README.md
git commit -m "feat: initial commit"
```

### 3. Check Current Remotes
Check if any remote connections are already defined (the output should be blank):
```bash
git remote -v
```

### 4. Connect to a Remote URL
Add a remote reference pointing to your remote server repository. Replace `your-username` with your GitHub username:
```bash
git remote add origin https://github.com/your-username/remote-exercise.git
```

### 5. Verify the Remote Setup
Verify that the remote has been successfully added:
```bash
git remote -v
```

#### Expected Output of the Verification:
```text
origin  https://github.com/your-username/remote-exercise.git (fetch)
origin  https://github.com/your-username/remote-exercise.git (push)
```
