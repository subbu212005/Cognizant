# Module 04: Docker Compose

This sub-module explores **Docker Compose**, a tool for defining and running multi-container Docker applications. Compose allows you to specify your entire application stack (services, databases, caches, networks, volumes) in a single YAML configuration file and deploy it with a single command.

## Learning Objectives
* Understand why multi-container orchestration is needed.
* Master the structure and syntax of the `docker-compose.yml` file.
* Learn to link containers using services, dependencies (`depends_on`), and shared networks.
* Control application startup sequences and environment variable injection.
* Utilize the Compose CLI commands (`up`, `down`, `build`, `logs`, etc.).

## Quick Overview
Instead of running several long commands like:
```bash
docker run -d --name db postgres
docker run -d --name app -p 8080:8080 --link db app-image
```

You can define everything in a `docker-compose.yml` file:
```yaml
services:
  db:
    image: postgres
  web:
    image: my-app-image
    ports:
      - "8080:8080"
    depends_on:
      - db
```
And start the entire stack with:
```bash
docker compose up -d
```

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/04-Docker-Compose/Notes.md)** for syntax options, service configurations, and a full multi-container deployment exercise.
