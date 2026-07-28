# Chapter 2: Understanding CI/CD

This chapter focuses on the core technical practices of DevOps: **Continuous Integration (CI)**, **Continuous Delivery (CD)**, and **Continuous Deployment (CD)**. We will examine how a pipeline works from code commit to customer-facing deployment.

---

## 🎯 Chapter Learning Objectives

By the end of this chapter, you will be able to:
1. **Differentiate the Three Cs**: Explain the precise differences between Continuous Integration, Continuous Delivery, and Continuous Deployment.
2. **Deconstruct a Pipeline**: Detail the anatomy of a deployment pipeline including Source, Build, Test, and Deploy phases.
3. **Design Testing Gates**: Determine where and how unit, integration, performance, and security testing fit within the software release process.
4. **Select Deployment Strategies**: Evaluate the pros, cons, and mechanics of Blue-Green, Canary, Rolling, and Recreate deployment configurations.
5. **Establish Feedback Mechanisms**: Design notification alerts to keep engineering teams informed of pipeline statuses.

---

## 📖 Table of Contents

* [Chapter 2 Notes: Pipelines & Deployment Strategies](file:///c:/Users/subbu/Downloads/Module-11-DevOps-and-CICD/02-Understanding-CI-CD/Notes.md)
  1. The Core Definitions (CI vs. CD vs. CD)
  2. The Anatomy of a Pipeline
  3. Build Automation & Artifact Management
  4. Automated Testing Gates
  5. Modern Deployment Strategies (With comparative diagrams)
  6. Feedback Loops and Notifications

---

## 💡 Quick Overview: The Pipeline Flow

A typical CI/CD pipeline acts as a conveyor belt, moving code changes from developers' workstations safely to the customer:

```text
               ┌────────┐     ┌────────┐     ┌────────┐     ┌────────┐
  Developer ──>│ Source │ ──> │ Build  │ ──> │  Test  │ ──> │ Deploy │ ──> Production
  Commit       └────────┘     └────────┘     └────────┘     └────────┘
                 Git          Packaging      Automated      Staging/
                              & Compiling      Tests        Production
```

Each step acts as a "quality gate"—if any step fails, the pipeline halts immediately, the team is notified, and the code is prevented from reaching production.

👉 **Ready to learn more?** Proceed to the [Chapter 2 Notes](file:///c:/Users/subbu/Downloads/Module-11-DevOps-and-CICD/02-Understanding-CI-CD/Notes.md) to explore the technical implementation of pipelines.
