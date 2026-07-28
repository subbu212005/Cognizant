# Module 01: Docker Commands

This sub-module covers the fundamental commands required to interact with the Docker CLI. Understanding these basic commands is crucial for managing containers, inspecting system status, and executing administrative actions.

## Learning Objectives
* Understand the core anatomy of a Docker command.
* Learn basic container lifecycle management (`run`, `start`, `stop`, `rm`).
* Learn how to query container state and system information (`ps`, `logs`, `inspect`, `stats`).
* Perform docker cleanup operations.

## CLI Command Structure
All Docker commands follow a standard hierarchical pattern:
```bash
docker <management-object> <sub-command> [options]
```
For example, to list containers:
```bash
docker container ls
```
To run a container:
```bash
docker container run -d nginx
```

> [!TIP]
> Docker also supports legacy shorthand syntax (e.g. `docker run` instead of `docker container run`, `docker ps` instead of `docker container ls`). Both syntaxes are active, but using the management-object style is considered a modern best practice as it makes commands more descriptive.

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/01-Docker-Commands/Notes.md)** for a detailed list of commands, examples, and hands-on scenarios.
