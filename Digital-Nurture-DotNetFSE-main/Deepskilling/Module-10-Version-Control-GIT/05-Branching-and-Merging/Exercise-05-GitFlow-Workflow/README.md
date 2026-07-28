# Exercise 05: The GitFlow Workflow

In this exercise, you will walk through the lifecycle of a feature branch within a simulated GitFlow branching strategy.

## Objectives
- Initialize a `develop` branch from `main`.
- Create a feature branch `feature/auth` off `develop`.
- Implement changes on the feature branch and merge them back into `develop`.
- Simulate merging `develop` to `main` for a production release.

## Background Context
In professional team settings, developers rarely merge directly into `main` (production). Instead, they follow branching strategies. One of the most popular is **GitFlow**, which utilizes two primary long-lived branches:
1. **`main`**: The codebase in production. Everything here is stable and tag-versioned.
2. **`develop`**: The integration branch for active development. Features are merged here first.

When starting work on a new user story or feature:
- A developer creates a temporary branch off `develop` named `feature/<feature-name>`.
- Once development is complete, the feature is merged back into `develop`.
- When `develop` is ready for a release, it is merged into `main` (often via a release branch or direct pull request) and tagged with a version number.

## Instructions
1. Switch to `main` and branch to create the long-running `develop` branch.
2. Create your feature branch `feature/auth` branching off `develop`.
3. Simulate feature development by creating `auth.js` and committing.
4. Switch to `develop` and merge the feature branch (non-fast-forward merge is recommended to preserve history).
5. Switch to `main` and merge `develop` to simulate a product release.
6. Tag the release on `main` as `v1.0.0`.

Check the **[Commands.md](./Commands.md)** file for the specific commands to run.
