# Exercise 02: Creating a Pull Request

In this exercise, you will learn how to create a local feature branch, make code changes, commit them, push the branch to your fork (`origin`), and open a Pull Request (PR) to request merging those changes into the original project repository (`upstream`).

---

## 💡 Key Concepts

### What is a Pull Request (PR)?
A **Pull Request** is a feature offered by platforms like GitHub, GitLab, and Bitbucket. It is a formal proposal to merge changes from one branch (often on a fork) into another branch (often in the main upstream repository).
- It allows maintainers to review your code, run automated tests, discuss modifications, and suggest improvements before your changes become part of the official project.
- It is a key tool for code quality and collaboration in software engineering.

---

## 🛠️ Step-by-Step Instructions

Assuming you have completed **Exercise 01** and have your local repository connected to both `origin` (your fork) and `upstream` (original repo):

### Step 1: Sync Your Local Main Branch
Before starting new work, always ensure you have the latest updates from the upstream repository:
```bash
git checkout main
git pull upstream main
```

### Step 2: Create and Switch to a Feature Branch
Do not work directly on the `main` branch. Create a dedicated branch for your feature:
```bash
git checkout -b feature/my-new-feature
```
*(This creates and checks out a new branch named `feature/my-new-feature`).*

### Step 3: Make Changes and Commit Them
1. Open the project files in your editor.
2. Create or modify a file (e.g., add your name to a contributors list or create a simple file).
3. Check status and stage the changes:
   ```bash
   git status
   git add <filename>
   ```
4. Commit the changes with a clear, descriptive message:
   ```bash
   git commit -m "docs: Add student name to contributors list"
   ```

### Step 4: Push the Branch to Your Fork (`origin`)
Push your local feature branch to your remote fork:
```bash
git push origin feature/my-new-feature
```
*Note: Do not push to `upstream`. You typically do not have permission to do so.*

### Step 5: Open the Pull Request on GitHub
1. Open your web browser and go to your fork page on GitHub:
   `https://github.com/YOUR-USERNAME/original-repo-name`
2. You will see a banner saying *"feature/my-new-feature had recent pushes..."*. Click the green **Compare & pull request** button.
3. Review the branch settings:
   - **base repository**: original owner's repository (`upstream`)
   - **base**: `main` (or `master`)
   - **head repository**: your fork (`origin`)
   - **compare**: `feature/my-new-feature`
4. Write a clear title and description explaining what your changes do.
5. Click **Create pull request**.

---

## 🎯 Verification Checklist

1. Run `git branch` on your computer. It should list your feature branch, with an asterisk showing it is selected:
   ```text
   * feature/my-new-feature
     main
   ```
2. Navigate to your PR page on GitHub. It should state:
   `YOUR_USERNAME wants to merge 1 commit into ORIGINAL_OWNER:main from YOUR_USERNAME:feature/my-new-feature`
3. View `Output.png` in this directory to see the Pull Request lifecycle illustration.

Refer to [Commands.md](Commands.md) for a summary of commands.
