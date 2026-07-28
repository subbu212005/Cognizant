# Exercise 01: Forking a Repository

In this exercise, you will learn how to create your own copy of a remote Git repository (forking), clone it to your local machine, and link your local repository back to the original source to fetch updates.

---

## 💡 Key Concepts

### What is a Fork?
A **fork** is a copy of a repository that is created on the hosting service (such as GitHub, GitLab, or Bitbucket) under *your* account. 
- It exists on the remote server, not on your computer.
- It allows you to make changes to a project without affecting the original repository.
- It is commonly used in open-source projects or organizations where developers do not have direct write permissions to the main codebase.

### Fork vs. Clone
- **Forking** creates a copy of the repository on the remote hosting service (e.g., GitHub server) under your namespace.
- **Cloning** downloads a copy of a remote repository (either the original or your fork) to your local machine so you can edit files.

---

## 🛠️ Step-by-Step Instructions

To complete this exercise, follow these steps:

### Step 1: Fork the Original Repository
1. Open your web browser and navigate to the original repository you wish to work on.
2. Click the **Fork** button (usually located in the top-right corner of the page).
3. Select your user account/organization as the destination.
4. Git will create a copy of the project under your account. The URL will look like:
   `https://github.com/YOUR-USERNAME/original-repo-name`

### Step 2: Clone Your Fork
Now that the copy exists in your online account, download it to your local computer:
1. Copy the clone URL of *your* fork (make sure your username is in the URL).
2. Open your terminal and run:
   ```bash
   git clone https://github.com/YOUR-USERNAME/original-repo-name.git
   ```
3. Navigate into the cloned folder:
   ```bash
   cd original-repo-name
   ```

### Step 3: Inspect Current Remotes
Check which remote connections Git configured automatically:
```bash
git remote -v
```
You will see that `origin` points to your forked repository on GitHub.

### Step 4: Link to the Upstream (Original) Repository
To receive future updates from the original project, you must set up a link to it called `upstream`:
1. Copy the clone URL of the **original** repository (owned by the original author).
2. Run the following command in your terminal:
   ```bash
   git remote add upstream https://github.com/ORIGINAL-OWNER/original-repo-name.git
   ```
3. Verify that you now have both `origin` (your fork) and `upstream` (the original repo) configured:
   ```bash
   git remote -v
   ```

---

## 🎯 Verification Checklist

Verify your setup by running `git remote -v` in the project directory. The output should look similar to:
```text
origin    https://github.com/YOUR_USERNAME/repo-name.git (fetch)
origin    https://github.com/YOUR_USERNAME/repo-name.git (push)
upstream  https://github.com/ORIGINAL_OWNER/repo-name.git (fetch)
upstream  https://github.com/ORIGINAL_OWNER/repo-name.git (push)
```

Refer to [Commands.md](Commands.md) for a summary of the terminal commands.
Visual topology is illustrated in `Output.png`.
