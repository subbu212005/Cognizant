# Docker Commands Reference Manual

A comprehensive reference of the essential Docker commands. This manual details syntax, flags, description, and concrete examples.

---

## 1. `docker run`
Creates and starts a container in one step.
* **Syntax**: `docker run [options] <image> [command] [arg...]`
* **Core Flags**:
  * `-d`, `--detach`: Runs container in background.
  * `-p`, `--publish <host>:<container>`: Publishes container ports to the host system.
  * `-e`, `--env <key=val>`: Sets environment variables.
  * `--env-file <path>`: Loads a file containing environment variables.
  * `-v`, `--volume <host>:<container>:[options]`: Mounts a directory/volume.
  * `--mount <opts>`: The recommended key-value mounting syntax (e.g. `type=volume,src=vname,dst=/data`).
  * `--name <string>`: Assigns a user-friendly name to the container.
  * `--restart <policy>`: Sets crash recovery rules (`no`, `on-failure`, `always`, `unless-stopped`).
  * `--rm`: Automatically removes the container filesystem when it exits.
  * `-m`, `--memory <limit>`: Sets memory limits (e.g. `500m`, `1g`).
  * `--cpus <limit>`: Sets CPU limits (e.g. `1.5` cores).
* **Examples**:
  ```bash
  # Launch a background redis container with 256MB memory cap
  docker run -d --name cache-store -m 256m redis:alpine

  # Launch an interactive shell and clean up container when exiting
  docker run -it --rm alpine sh
  ```

---

## 2. `docker exec`
Runs a new command inside a *currently running* container.
* **Syntax**: `docker exec [options] <container> <command> [arg...]`
* **Core Flags**:
  * `-i`, `--interactive`: Keeps STDIN open.
  * `-t`, `--tty`: Allocates a pseudo-TTY.
  * `-d`, `--detach`: Runs the command in the background.
  * `-u`, `--user <username>`: Run the command as a specific user.
* **Examples**:
  ```bash
  # Open interactive bash terminal inside running node-app container
  docker exec -it node-app /bin/bash

  # Trigger a database backup in postgres container without attaching
  docker exec db-server pg_dumpall -U postgres > backup.sql
  ```

---

## 3. `docker build`
Builds a new Docker image from a Dockerfile.
* **Syntax**: `docker build [options] <path-or-url>`
* **Core Flags**:
  * `-t`, `--tag <name:tag>`: Name and optionally a tag in the 'name:tag' format.
  * `-f`, `--file <path>`: Name of the Dockerfile (defaults to `PATH/Dockerfile`).
  * `--no-cache`: Do not use cache when building the image.
  * `--build-arg <key=val>`: Set build-time variables (accessed inside Dockerfile via `ARG`).
  * `--pull`: Always attempt to pull a newer version of the parent base image.
* **Examples**:
  ```bash
  # Build and tag an image using the local directory's Dockerfile
  docker build -t my-app:1.2.0 .

  # Build an image using a custom Dockerfile path without caching
  docker build -f Dockerfile.prod -t my-app:prod --no-cache .
  ```

---

## 4. `docker logs`
Retrieves execution output streams (`stdout` and `stderr`) from a container.
* **Syntax**: `docker logs [options] <container>`
* **Core Flags**:
  * `-f`, `--follow`: Stream/follow the log output.
  * `-n`, `--tail <string>`: Number of lines to show from the end of the logs (default "all").
  * `-t`, `--timestamps`: Show timestamps in log outputs.
  * `--since <string>`: Show logs since a timestamp (e.g. `2023-01-01T15:00:00` or `30m` for 30 minutes).
* **Examples**:
  ```bash
  # Stream webserver log outputs, showing timestamps
  docker logs -f -t web-server

  # Inspect logs generated in the last 10 minutes
  docker logs --since 10m api-server
  ```

---

## 5. `docker inspect`
Extracts low-level system configuration metadata for any Docker resource (container, image, volume, network).
* **Syntax**: `docker inspect [options] <name-or-id>`
* **Core Flags**:
  * `-f`, `--format <string>`: Format the output using a Go template.
* **Examples**:
  ```bash
  # Find the IP address of a container using --format template filter
  docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' web-server

  # Query container restart policy settings
  docker inspect -f '{{.HostConfig.RestartPolicy.Name}}' db-server
  ```

---

## 6. `docker system prune`
Reclaims local host disk space by removing unused Docker assets.
* **Syntax**: `docker system prune [options]`
* **Core Flags**:
  * `-a`, `--all`: Remove all unused images, not just dangling ones.
  * `--volumes`: Prune unused volumes along with other objects.
  * `-f`, `--force`: Do not prompt for confirmation.
* **Example**:
  ```bash
  # Deep-clean everything including unused images and volumes
  docker system prune -a --volumes -f
  ```
