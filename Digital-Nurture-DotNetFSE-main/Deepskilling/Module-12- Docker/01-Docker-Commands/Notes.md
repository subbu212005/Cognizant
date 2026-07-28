# Docker CLI Commands - Study Notes

The Docker CLI is the interface we use to interact with the Docker Daemon. This guide groups the most frequently used commands by category.

---

## 1. Lifecycle Commands

These commands manage the execution state of containers.

### `docker run`
Creates and starts a new container from an image.
* **Syntax**: `docker run [options] <image> [command]`
* **Common Flags**:
  * `-d` : Run container in background (detached mode).
  * `-it` : Run interactively, attaching stdin and tty.
  * `--name <name>` : Give the container a custom name.
* **Example**:
  ```bash
  docker run -d --name my-webserver nginx
  ```

### `docker start` / `docker stop` / `docker restart`
Control existing containers.
* `docker start <container>` : Start a stopped container.
* `docker stop <container>` : Gracefully stop a running container (sends `SIGTERM`, then `SIGKILL` if it doesn't stop).
* `docker restart <container>` : Stop and start a container.
* **Example**:
  ```bash
  docker stop my-webserver
  docker start my-webserver
  ```

### `docker kill`
Forces a container to stop immediately (sends `SIGKILL`).
* **Example**:
  ```bash
  docker kill my-webserver
  ```

### `docker rm`
Removes one or more stopped containers.
* **Flag `-f`**: Forces removal of a running container.
* **Example**:
  ```bash
  docker rm my-webserver
  ```

---

## 2. Information and Query Commands

These commands let you inspect containers and system resources.

### `docker ps`
Lists containers.
* **Common Flags**:
  * (default) : Lists only *running* containers.
  * `-a` : Lists *all* containers (running and stopped).
  * `-q` : Lists only container IDs (quiet mode).
* **Example**:
  ```bash
  docker ps -a
  ```

### `docker logs`
Fetches log outputs from a container.
* **Common Flags**:
  * `-f` : Follow/stream log output.
  * `--tail <n>` : Show only the last `n` lines.
* **Example**:
  ```bash
  docker logs -f my-webserver
  ```

### `docker inspect`
Returns low-level, JSON-formatted configuration details of any Docker object (container, image, network, volume).
* **Example**:
  ```bash
  docker inspect my-webserver
  ```

### `docker stats`
Displays a live stream of container resource usage (CPU, Memory, Network I/O).
* **Example**:
  ```bash
  docker stats
  ```

### `docker top`
Displays the running processes inside a container.
* **Example**:
  ```bash
  docker top my-webserver
  ```

---

## 3. Image Management Commands

Commands for working with Docker images.

* `docker images` (or `docker image ls`): List local images.
* `docker pull <image>`: Download an image from Docker Hub.
* `docker rmi <image>` (or `docker image rm`): Remove a local image.
* `docker build -t <tag> .`: Build an image from a Dockerfile.

---

## 4. System Cleanup Commands

Docker can consume significant disk space over time. Use these commands to reclaim storage.

### `docker system df`
Shows disk usage by containers, images, volumes, and build cache.

### `docker system prune`
Cleans up unused data.
* **What it removes**:
  * All stopped containers.
  * All networks not used by at least one container.
  * All dangling images (images without tags and not referenced).
  * All dangling build cache.
* **Flag `-a`**: Also removes all unused images (not just dangling ones).
* **Flag `--volumes`**: Also removes all unused volumes.
* **Example**:
  ```bash
  docker system prune -a --volumes
  ```
