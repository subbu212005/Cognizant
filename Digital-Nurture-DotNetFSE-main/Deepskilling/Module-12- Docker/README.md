# Module 12: Containerization Using Docker

Welcome to the **Containerization Using Docker** learning module! This comprehensive module is designed to take you from a Docker beginner to a confident practitioner capable of containerizing applications, configuring complex environments, managing persistent storage, designing custom networks, and understanding the basics of container orchestration.

## Course Outline & Syllabus

This module is divided into 8 focused sub-modules and a resource toolkit:

1. **[01-Docker-Commands](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/01-Docker-Commands/)**
   * Introduction to CLI syntax and fundamental commands for container management.
2. **[02-Docker-Run](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/02-Docker-Run/)**
   * Mastering the `docker run` command, port mapping, env variables, and policies.
3. **[03-Docker-Images](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/03-Docker-Images/)**
   * Building optimized custom images using Dockerfiles and multi-stage builds.
4. **[04-Docker-Compose](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/04-Docker-Compose/)**
   * Defining and running multi-container applications declaratively.
5. **[05-Docker-Engine](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/05-Docker-Engine/)**
   * Exploring Docker's architecture, runtimes (runc, containerd), and kernel-level isolation.
6. **[06-Docker-Storage](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/06-Docker-Storage/)**
   * Managing persistent data using Volumes, Bind Mounts, and tmpfs.
7. **[07-Docker-Networking](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/07-Docker-Networking/)**
   * Custom networks, DNS resolution, and built-in drivers (bridge, host, overlay).
8. **[08-Container-Orchestration](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/08-Container-Orchestration/)**
   * Introduction to clustering and orchestration concepts (Docker Swarm & Kubernetes).

---

## Prerequisites & Local Setup

To follow along with the exercises and guides in this module, you need Docker installed on your development machine.

### Installation Options
* **Windows & macOS**: Download and install [Docker Desktop](https://www.docker.com/products/docker-desktop/).
  * *Windows Tip*: Ensure WSL 2 (Windows Subsystem for Linux) backend is enabled for optimal performance.
* **Linux (Ubuntu/Debian)**:
  ```bash
  sudo apt-get update
  sudo apt-get install docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin
  ```

### Verify Installation
Open your terminal/command prompt and run:
```bash
# Verify Docker version
docker --version

# Verify Docker Compose version
docker compose version

# Run a test container to ensure everything works
docker run hello-world
```

---

## Resources Toolkit
Keep these references handy as you work through the guides:
* **[Docker Cheat Sheet](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/Resources/Docker-Cheat-Sheet.md)**: A quick table of day-to-day command snippets.
* **[Docker Commands Reference](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/Resources/Docker-Commands-Reference.md)**: Comprehensive reference explaining syntax, options, and behaviors.
* **[Kubernetes Overview](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/Resources/Kubernetes-Overview.md)**: Jumpstart guide transitioning from single-host Docker to multi-node K8s.
* **[Useful Links](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/Resources/Useful-Links.md)**: Official documentation, online sandboxes, and registry portals.
