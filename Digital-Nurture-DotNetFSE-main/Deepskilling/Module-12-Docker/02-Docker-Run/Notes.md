# Mastering `docker run` - Study Notes

The `docker run` command executes a container from a specified image. Understanding its options is essential for configuring container networks, environments, security, and recovery properties.

---

## 1. Foreground vs. Background Modes

### Detached Mode (`-d`)
Runs the container in the background and prints the Container ID.
* Use this for long-running service applications (web servers, databases, queues).
* **Example**:
  ```bash
  docker run -d nginx
  ```

### Interactive/Foreground Mode (`-it`)
Runs the container in the foreground, attaching your terminal console to the container's stdin and tty.
* Use this for testing, debugging, or running shell environments (e.g. bash, sh).
* **`-i` (interactive)**: Keeps STDIN open even if not attached.
* **`-t` (tty)**: Allocates a pseudo-TTY.
* **Example**:
  ```bash
  docker run -it ubuntu /bin/bash
  ```
  *(To exit without stopping the container, press `Ctrl + P`, then `Ctrl + Q`. To exit and stop, type `exit`.)*

---

## 2. Port Mapping (`-p` or `--publish`)

Containers run inside isolated network namespaces and cannot be accessed externally by default. Port mapping bridges the host network to the container network.

* **Syntax**: `-p <HostPort>:<ContainerPort>`
* **Mechanism**: Maps a port on the host machine to a port exposed inside the container.
* **Example**:
  ```bash
  docker run -d -p 8080:80 nginx
  ```
  *Accessing `http://localhost:8080` on your host machine routes traffic to port `80` inside the nginx container.*

> [!WARNING]
> If you leave out the HostPort (e.g., `-p 80`), Docker will automatically allocate a random high-numbered port on the host machine. You can find this port using `docker ps` or `docker port <container-name>`.

---

## 3. Environment Variables (`-e` or `--env`)

Environment variables are the primary mechanism used to configure containerized application runtimes dynamically without rebuilding images.

* **Single variable**: `-e KEY=VALUE`
* **Using an Env file**: `--env-file <path-to-file>`
* **Example**:
  ```bash
  docker run -d --name my-db -e MYSQL_ROOT_PASSWORD=secret mysql:8.0
  ```

---

## 4. Restart Policies (`--restart`)

Restart policies define how Docker handles container crashes, daemon restarts, or system reboots.

| Policy | Description |
|---|---|
| `no` | (Default) Does not automatically restart the container. |
| `on-failure[:max-retries]` | Restarts only if the container exits with a non-zero exit code. |
| `always` | Always restarts the container regardless of the exit code. Also restarts on host reboot. |
| `unless-stopped` | Similar to `always`, but will *not* restart if it was explicitly stopped by the user. |

* **Example**:
  ```bash
  docker run -d --name database --restart unless-stopped postgres:15
  ```

---

## 5. Resource Constraints (Limits)

To prevent a single container from hogging system resources, you can set limits on CPU and Memory.

* **Memory Limit (`-m` or `--memory`)**: Sets the maximum amount of RAM the container can consume.
* **CPU Limit (`--cpus`)**: Restricts the container to a fraction of the host's CPU capacity.
* **Example**:
  ```bash
  # Restrict to 500MB memory and 1.5 CPU cores
  docker run -d --name fast-app -m 500m --cpus 1.5 redis
  ```

---

## 💻 Hands-On Exercise: Spin Up a Web Sandbox

Let's test these flags together by running a database container and an interactive bash shell container.

1. **Step 1: Start a detached database container with environment variables**
   ```bash
   docker run -d --name test-db -e POSTGRES_PASSWORD=mysecretpassword postgres:15
   ```
2. **Step 2: Inspect running state**
   ```bash
   docker ps
   docker logs test-db
   ```
3. **Step 3: Run an interactive container and ping the database**
   ```bash
   docker run -it --name utility-shell alpine sh
   # Inside the alpine shell, run:
   # ping -c 3 <IP of your docker host or inspect container IP>
   exit
   ```
4. **Step 4: Cleanup**
   ```bash
   docker stop test-db utility-shell
   docker rm test-db utility-shell
   ```
