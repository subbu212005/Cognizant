# Module 03: Docker Images

This sub-module focuses on how Docker Images are created, structured, and managed. You will learn to write Dockerfiles, configure processes, optimize image sizes, and share images with registry portals.

## 🎯 Learning Objectives
* Understand what a Docker Image is and its layered design.
* Write syntax-compliant and production-grade Dockerfiles.
* Distinguish between build-time and run-time parameters (`CMD` vs. `ENTRYPOINT`).
* Leverage Docker build cache to speed up development cycles.
* Implement Multi-Stage Builds to dramatically reduce final image sizes.
* Build, tag, and publish images to Docker registries.

## 💡 Quick Overview
A Docker image is a read-only template that contains a set of instructions for creating a container. It consists of multiple read-only layers stacked on top of each other. When a container is started, Docker adds a thin read-write layer (the container layer) on top.

Images are defined using a text file named `Dockerfile`. Building an image is done with:
```bash
docker build -t my-username/my-app:1.0 .
```

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/03-Docker-Images/Notes.md)** for syntax details, multi-stage templates, and hands-on image creation exercises.
