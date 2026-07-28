# Module 06: Docker Storage

This sub-module explores data management and persistence in Docker. By default, any files created inside a container are ephemeral and will be permanently lost when the container is deleted. To persist data or share it between host and container, Docker offers three different storage types.

## 🎯 Learning Objectives
* Understand the ephemeral nature of a container's read-write layer.
* Differentiate between **Volumes**, **Bind Mounts**, and **tmpfs Mounts**.
* Learn when to use Volumes vs. Bind Mounts in development and production.
* Perform volume lifecycle operations (`create`, `ls`, `inspect`, `rm`, `prune`).
* Configure mounts using the `-v` and `--mount` flags.

## 💡 Quick Overview
Docker provides three main types of mounts:

```
                  Host System File System
┌────────────────────────────────────────────────────────┐
│                                                        │
│  ┌──────────────────┐            ┌──────────────────┐  │
│  │   Bind Mounts    │            │     Volumes      │  │
│  │  (Any Host Path) │            │ (Managed Docker  │  │
│  └────────┬─────────┘            │  Area on Host)   │  │
│           │                      └────────┬─────────┘  │
│           │                               │            │
│           └──────────────┬────────────────┘            │
│                          ▼                             │
│                  ┌──────────────┐                      │
│                  │  Container   │                      │
│                  └──────────────┘                      │
│                          ▲                             │
│                          │                             │
│                  ┌───────┴──────┐                      │
│                  │ tmpfs Mounts │                      │
│                  │  (Host RAM)  │                      │
│                  └──────────────┘                      │
└────────────────────────────────────────────────────────┘
```

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/06-Docker-Storage/Notes.md)** for mounting syntax, database persistence patterns, and storage best practices.
