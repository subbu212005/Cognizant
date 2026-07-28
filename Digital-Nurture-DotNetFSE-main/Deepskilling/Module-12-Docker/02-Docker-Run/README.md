# Module 02: Docker Run

This sub-module focuses entirely on the `docker run` command, which is the most powerful and complex command in the Docker toolset. It is used to pull (if not present), create, configure, and start containers all in one go.

## 🎯 Learning Objectives
* Understand what happens behind the scenes during a `docker run` invocation.
* Master the differences between Foreground (Interactive) and Background (Detached) container modes.
* Configure containers via Port Mapping (`-p`) and Environment Variables (`-e`).
* Configure auto-recovery capabilities using Restart Policies (`--restart`).
* Learn resource constraint enforcement (CPU/Memory limits).

## 💡 Quick Overview
A standard `docker run` command looks like:
```bash
docker run -d -p 8080:80 --name my-web nginx:latest
```
This single line executes multiple operations:
1. Checks for the local image `nginx:latest`. If missing, pulls it from Docker Hub.
2. Creates the container container with name `my-web`.
3. Sets up networking: maps host port `8080` to container port `80`.
4. Runs the container in background (detached mode `-d`).
5. Launches the default process inside the container.

Refer to **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/02-Docker-Run/Notes.md)** for detailed specifications, parameter keys, and hands-on practice guides.
