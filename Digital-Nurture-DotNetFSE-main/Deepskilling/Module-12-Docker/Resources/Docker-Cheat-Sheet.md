# Docker Command Cheat Sheet

A quick-reference guide for standard, day-to-day Docker operations.

---

## Container Lifecycle

| Command | Action |
|---|---|
| `docker run -d -p 80:80 --name web nginx` | Runs container in background, maps port 80, sets name |
| `docker run -it alpine sh` | Runs container interactively in foreground with a shell |
| `docker start <name>` | Starts a stopped container |
| `docker stop <name>` | Gracefully stops a running container |
| `docker kill <name>` | Forcefully kills a running container |
| `docker restart <name>` | Stops and restarts a container |
| `docker rm <name>` | Deletes a stopped container |
| `docker rm -f <name>` | Force-deletes a running container |

---

## Query & Inspection

| Command | Action |
|---|---|
| `docker ps` | List running containers |
| `docker ps -a` | List all containers (running and stopped) |
| `docker logs <name>` | View logs of container |
| `docker logs -f --tail 100 <name>` | Follow logs of container, showing last 100 lines |
| `docker inspect <name>` | Returns detailed configuration details of object in JSON |
| `docker stats` | Live-stream of container resource usage statistics |
| `docker top <name>` | Displays processes running inside the container |
| `docker port <name>` | List port mappings or specific mapping for container |

---

## Image Management

| Command | Action |
|---|---|
| `docker images` | List local Docker images |
| `docker pull <image>` | Pull an image from Docker Hub registry |
| `docker rmi <image>` | Remove local image |
| `docker build -t <tag> .` | Build an image from Dockerfile in current directory |
| `docker tag <src> <target>` | Tag an image with a new name/version tag |
| `docker push <tag>` | Push image to Docker Hub or remote registry |
| `docker history <image>` | Show build history of an image |

---

## Volumes & Networks

| Command | Action |
|---|---|
| `docker volume ls` | List all volumes |
| `docker volume create <name>` | Create a named volume |
| `docker volume inspect <name>` | Inspect a volume's storage path details |
| `docker volume rm <name>` | Delete a volume |
| `docker network ls` | List all networks |
| `docker network create <name>` | Create a custom bridge network |
| `docker network connect <net> <c>` | Connect a running container to a network |
| `docker network disconnect <net> <c>`| Disconnect a container from a network |
| `docker network rm <name>` | Remove network |

---

## System Cleanups

| Command | Action |
|---|---|
| `docker system df` | Show disk usage analysis by Docker objects |
| `docker container prune` | Remove all stopped containers |
| `docker image prune` | Remove all dangling (untagged) images |
| `docker volume prune` | Remove all unused local volumes |
| `docker system prune -a --volumes` | Remove ALL unused containers, networks, images, and volumes |
