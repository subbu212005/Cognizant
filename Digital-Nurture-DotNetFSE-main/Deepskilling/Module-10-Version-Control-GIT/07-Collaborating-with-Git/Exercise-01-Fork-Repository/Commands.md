# Exercise 01: Reference Commands

Here is the exact sequence of terminal commands used to clone a fork and set up the connection to the upstream repository.

---

## 💻 Commands List

### 1. Clone your Fork
Downloads your fork of the repository from GitHub to your local machine.
```bash
git clone https://github.com/YOUR_USERNAME/repo-name.git
```

### 2. Change Directory
Move into the root folder of the cloned repository.
```bash
cd repo-name
```

### 3. Check Current Remotes
Show the remote repositories linked to this local project. By default, only your fork (`origin`) is listed.
```bash
git remote -v
```

### 4. Connect to Original Repository (`upstream`)
Creates a new remote connection named `upstream` pointing to the original repository.
```bash
git remote add upstream https://github.com/ORIGINAL_OWNER/repo-name.git
```

### 5. Verify the Dual Remotes
Confirm both `origin` (your write-enabled fork) and `upstream` (the read-only source repository) are configured.
```bash
git remote -v
```

---

## 📝 Example Shell Session Output

```powershell
PS C:\Users\student\Projects> git clone https://github.com/octocat/Spoon-Knife.git
Cloning into 'Spoon-Knife'...
remote: Enumerating objects: 16, done.
remote: Total 16 (delta 0), reused 0 (delta 0), pack-reused 16
Receiving objects: 100% (16/16), done.

PS C:\Users\student\Projects> cd Spoon-Knife

PS C:\Users\student\Projects\Spoon-Knife> git remote -v
origin  https://github.com/octocat/Spoon-Knife.git (fetch)
origin  https://github.com/octocat/Spoon-Knife.git (push)

PS C:\Users\student\Projects\Spoon-Knife> git remote add upstream https://github.com/octo-org/Spoon-Knife.git

PS C:\Users\student\Projects\Spoon-Knife> git remote -v
origin    https://github.com/octocat/Spoon-Knife.git (fetch)
origin    https://github.com/octocat/Spoon-Knife.git (push)
upstream  https://github.com/octo-org/Spoon-Knife.git (fetch)
upstream  https://github.com/octo-org/Spoon-Knife.git (push)
```
