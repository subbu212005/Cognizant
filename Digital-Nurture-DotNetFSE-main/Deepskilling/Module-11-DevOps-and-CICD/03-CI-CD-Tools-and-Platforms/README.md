# Chapter 3: CI/CD Tools and Platforms

In this chapter, we bridge the gap between theory and execution. We will explore the modern landscape of CI/CD engines, compare self-hosted vs. SaaS offerings, and learn how to construct real-world pipeline files.

---

## 🎯 Chapter Learning Objectives

By the end of this chapter, you will be able to:
1. **Analyze the Tool Landscape**: Compare the trade-offs between self-hosted build automation engines (like Jenkins) and managed SaaS runners (like GitHub Actions and GitLab CI).
2. **Interpret Pipeline Definitions**: Read and debug configuration files written in YAML or Groovy.
3. **Configure GitHub Actions Workflows**: Construct a fully-functional GitHub Actions YAML workflow using triggers, jobs, environment variables, actions, and runners.
4. **Manage Pipeline Secrets**: Safely inject API keys and registry credentials into pipeline executions without exposing them in public git history.
5. **Decipher GitLab CI Syntax**: Recognize and explain the architecture of a `.gitlab-ci.yml` script.

---

## 📖 Table of Contents

* [Chapter 3 Notes: Hands-On Tools & Configs](file:///c:/Users/subbu/Downloads/Module-11-DevOps-and-CICD/03-CI-CD-Tools-and-Platforms/Notes.md)
  1. Self-Hosted vs. SaaS Pipelines
  2. Jenkins: Architecture and Jenkinsfile Structure
  3. GitLab CI/CD: Core Concepts & YAML
  4. GitHub Actions Deep Dive (Concepts, Syntax, Secrets, Cache)
  5. Platform Comparison Matrix

---

## 💡 Quick Overview: The Pipeline as Code (PaC)

Modern CI/CD relies on the concept of **Pipeline as Code**. Instead of clicking buttons in a graphical user interface (GUI) to configure builds, developers define their delivery pipeline in a configuration file checked directly into the git repository:

```text
  Local Workspace            Git Repository             CI/CD Platform
  ┌───────────────┐          ┌───────────────┐          ┌───────────────┐
  │  pipeline.yaml│ ──Git──> │  pipeline.yaml│ ──Runs──>│ Executes jobs │
  │ (Defined in   │   Push   │ (Tracked,     │  Auto-   │ on runners    │
  │  text editor) │          │  versioned)   │  trigger │ in the cloud  │
  └───────────────┘          └───────────────┘          └───────────────┘
```

Benefits of Pipeline as Code:
* **Versioned**: Pipeline changes are tracked alongside the application code.
* **Auditability**: Team members can review pipeline changes via pull requests.
* **Repeatability**: Easily duplicate pipelines across different services or projects.

👉 **Ready to learn more?** Proceed to the [Chapter 3 Notes](file:///c:/Users/subbu/Downloads/Module-11-DevOps-and-CICD/03-CI-CD-Tools-and-Platforms/Notes.md) to look at syntax, examples, and configurations.
