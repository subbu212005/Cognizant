# Git Workflow Diagrams

This document contains visual representations of key Git concepts and branching strategies using Mermaid diagrams.

---

## 1. Git Architecture & File Lifecycle

This diagram demonstrates how files transition between the four zones of Git, showing the command used for each transition.

```mermaid
graph TD
    WD["Working Directory<br>(Workspace)"]
    SA["Staging Area<br>(Index)"]
    LR["Local Repository<br>(HEAD)"]
    RR["Remote Repository<br>(GitHub/GitLab)"]

    %% File Transitions (Forward)
    WD -->|git add| SA
    SA -->|git commit| LR
    LR -->|git push| RR

    %% File Transitions (Backward / Retrieve)
    RR -->|git clone / git fetch| LR
    LR -->|git checkout / git switch| WD
    SA -->|git restore| WD
    LR -->|git restore --staged| SA
    RR -->|git pull| WD
```

---

## 2. GitHub Flow

A lightweight, branch-based workflow that is ideal for continuous deployment.

```mermaid
gitGraph
    commit id: "Initial Commit"
    branch feature-auth
    checkout feature-auth
    commit id: "feat: add form UI"
    commit id: "feat: integrate API"
    checkout main
    merge feature-auth id: "Merge PR #1" tag: "v1.0.0"
    commit id: "chore: update config"
```

### Steps:
1. **Branch**: Create a branch off `main` with a descriptive name (e.g., `feature-login`).
2. **Commit**: Save your changes to your branch locally and push to your remote branch.
3. **Pull Request**: Open a Pull Request (PR) to discuss, review, and test your code.
4. **Merge**: Once approved, merge the PR into `main` and deploy to production.

---

## 3. Gitflow Workflow

A strict branching model designed around project releases. Excellent for projects with scheduled releases and multiple environments.

```mermaid
graph LR
    subgraph MainBranch [Main: Production-Ready]
        m1((v1.0.0)) --> m2((v1.1.0))
    end

    subgraph ReleaseBranch [Release: Preparation]
        r1((Release 1.1)) --> r2((Bug Fix))
    end

    subgraph DevelopBranch [Develop: Integration]
        d1((Develop)) --> d2((Commit)) --> d3((Commit)) --> d4((Merge Feature))
    end

    subgraph FeatureBranch [Feature: Development]
        f1((Feature Start)) --> f2((Commit))
    end

    %% Flow lines
    d1 -->|branch| f1
    f2 -->|merge| d4
    d3 -->|branch| r1
    r2 -->|merge| m2
    r2 -->|merge back| d4
```

### Branches:
* **`main`**: Stores official release history. Every commit on `main` represents a production-ready release.
* **`develop`**: Serves as an integration branch for features.
* **`feature/*`**: Branched from `develop` for specific new features; merged back into `develop` when finished.
* **`release/*`**: Branched from `develop` when preparing a new production release; merged into both `main` and `develop`.
* **`hotfix/*`**: Branched from `main` to address critical bugs in production immediately; merged into both `main` and `develop`.

---

## 4. Feature Branch Workflow (Interactive Walkthrough)

This diagram shows how multiple developers collaborate using local feature branches and a shared remote origin.

```mermaid
sequenceDiagram
    actor DevA as Developer A
    participant Remote as Remote Origin (GitHub)
    actor DevB as Developer B

    Note over DevA, DevB: Setup phase
    DevA->>Remote: git clone
    DevB->>Remote: git clone

    Note over DevA: Works on Auth Feature
    DevA->>DevA: git switch -c feat-auth
    DevA->>DevA: Make code changes & commit

    Note over DevB: Works on Profile Page
    DevB->>DevB: git switch -c feat-profile
    DevB->>DevB: Make code changes & commit

    Note over DevA: Share Auth Feature
    DevA->>Remote: git push -u origin feat-auth
    Note over Remote: Pull Request Created & Approved

    Remote->>Remote: Merge feat-auth into main

    Note over DevB: Sync with Dev A's work
    DevB->>Remote: git fetch origin
    DevB->>DevB: git merge origin/main
    DevB->>Remote: git push -u origin feat-profile
```
