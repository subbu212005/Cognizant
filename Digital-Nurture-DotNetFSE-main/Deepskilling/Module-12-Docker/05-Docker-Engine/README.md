# Module 05: Docker Engine

This sub-module explores the internal architecture and low-level mechanics of the **Docker Engine**. Understanding the system components that run containers helps you debug issues, optimize performance, and design secure environments.

## 🎯 Learning Objectives
* Describe the components of the Docker Client-Server architecture.
* Understand the roles of the Docker Daemon (`dockerd`), `containerd`, and `runc`.
* Learn how Linux kernel namespaces provide container isolation.
* Explain how Control Groups (cgroups) allocate system resources.
* Differentiate between container isolation levels.

## 💡 Quick Overview
Docker is not a single monolithic application; it is a collection of tools working together. When you run `docker run`, your command goes through a sequence of handoffs:
1. The **Docker Client** translates your command into a REST API call.
2. The **Docker Daemon (`dockerd`)** processes the API request, manages images, and delegates container execution.
3. **`containerd`** manages the container lifecycle (start, stop, pause, destroy).
4. **`runc`** interacts directly with the Linux kernel to create namespaces and cgroups, starts the container, and then exits.

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/05-Docker-Engine/Notes.md)** for architecture diagrams (represented in text/tables) and in-depth explanations of namespace and cgroup configuration.
