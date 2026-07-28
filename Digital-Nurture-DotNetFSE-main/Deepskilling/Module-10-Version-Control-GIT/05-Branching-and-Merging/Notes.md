# Conceptual Notes: Git Branching and Merging

Understanding branching and merging is the key to mastering Git. This document details the underlying mechanics of how Git handles these features.

---

## 1. What is a Git Branch?

In Git, a branch is **not** a copy of your files. Instead, a branch is simply a **lightweight, mutable pointer to a specific commit**.

When you commit in Git, Git stores a commit object that contains:
- A pointer to the snapshot of staged content.
- Metadata (author, message, etc.).
- A pointer to the parent commit(s).

Because a branch is just a 40-character SHA-1 checksum file pointing to a commit, branches are incredibly cheap to create and destroy in Git (unlike older version control systems like SVN which copied directories).

```
   (Commit A) <-- (Commit B) <-- (Commit C)  [main]
                                    ^
                                    |
                                  [HEAD]
```

### The Role of `HEAD`
`HEAD` is a special pointer that tells Git which branch you are currently working on. 
- In the diagram above, `HEAD` points to `main`, which points to `Commit C`.
- When you make a new commit, Git automatically updates the branch pointed to by `HEAD` to point to the new commit.

---

## 2. Merging Strategies

When you want to merge work from one branch (e.g., `feature`) into another (e.g., `main`), Git uses one of two main strategies depending on the state of the commit graph:

### Strategy A: Fast-Forward Merge
A Fast-Forward merge occurs when there is a **linear path** from the target branch to the branch being merged. 
- If `main` has not diverged since you created `feature`, Git simply moves the `main` pointer forward to point to the same commit as `feature`.
- No new commit is created.

**Before Merge:**
```
A --- B (main)
       \
        C --- D (feature)
```

**After `git merge feature`:**
```
A --- B --- C --- D (main, feature)
```

### Strategy B: Three-Way Merge (Merge Commit)
A Three-Way merge occurs when the branches have **diverged**. If `main` has received new commits since `feature` was branched, a linear fast-forward is impossible.
- Git finds the **common ancestor** (the point where they split).
- It performs a three-way merge using:
  1. The common ancestor commit.
  2. The tip of the target branch (`main`).
  3. The tip of the source branch (`feature`).
- Git creates a new **merge commit** that has two parent commits.

**Before Merge:**
```
A --- B --- C (main)
       \
        D --- E (feature)
```

**After `git merge feature`:**
```
A --- B --- C ------- F (main)
       \             /
        D --- E ----/ (feature)
```

---

## 3. Merge Conflicts

A merge conflict happens when Git cannot automatically reconcile differences between two branches. This typically occurs when **the same line in the same file** is modified differently on both branches.

When a conflict occurs:
1. Git pauses the merge process and leaves the working directory in a conflicted state.
2. It inserts **conflict markers** into the affected files.
3. You must open the file, decide which changes to keep, remove the markers, stage the file (`git add`), and run `git commit` to complete the merge.

### Anatomy of Conflict Markers
```html
<<<<<<< HEAD
This content is from the branch you are currently on (e.g., main).
=======
This content is from the branch you are merging in (e.g., feature-login).
>>>>>>> feature-login
```

---

## 4. The GitFlow Workflow

GitFlow is a structured branching model designed by Vincent Driessen that provides a robust framework for managing large projects.

### Core Branches
*   **`main`**: Stores the official release history. All code in `main` is production-ready.
*   **`develop`**: Serves as an integration branch for features. This is where active development is consolidated.

### Supporting Branches
*   **Feature Branches (`feature/*`)**: Used to develop new features. They branch off `develop` and must merge back into `develop`.
*   **Release Branches (`release/*`)**: Support preparation of a new production release. They branch off `develop` and merge into both `main` and `develop`.
*   **Hotfix Branches (`hotfix/*`)**: Used to quickly patch production releases. They branch off `main` and merge into both `main` and `develop` (or `release`).

```
main       ============================== [V1.0] ==================== [V1.1]
                                           ^                           ^
release/v1.1                              /   o-----------------------o
                                         /   /                       /
develop    =============================o===o-------o===============o
                                         \         /
feature/   -------------------------------o-------o (feature-auth)
```
