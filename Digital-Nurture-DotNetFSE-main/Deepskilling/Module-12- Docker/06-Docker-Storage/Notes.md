# Docker Storage & Data Persistence - Study Notes

By default, container filesystems are ephemeral. If you update files inside a running container and the container is deleted, those modifications vanish. Docker offers mechanisms to mount files from the host system or virtual volumes into the container's virtual directory tree.

---

## 1. Types of Mounts

| Mount Type | Storage Location | Managed By | Use Case |
|---|---|---|---|
| **Volumes** | Host filesystem managed area (`/var/lib/docker/volumes/` on Linux) | Docker CLI & Daemon | Best way to persist data in production (e.g. database storage). Decoupled from host OS structure. |
| **Bind Mounts** | Any user-specified directory/file on the host | The user (can be modified by external processes) | Exposing configuration files, or mounting local project source code during development for hot-reloads. |
| **tmpfs Mounts** | Host system memory (RAM) | Host OS memory manager | High-performance temporary cache files, or writing sensitive data (like keys/tokens) that should never hit disk. |

---

## 2. Managing Docker Volumes

Docker Volumes are directory directories created and managed entirely by the Docker system.

* **Create volume**: `docker volume create <volume-name>`
* **List volumes**: `docker volume ls`
* **Inspect volume detail**: `docker volume inspect <volume-name>`
* **Remove unused volumes**: `docker volume prune`
* **Remove specific volume**: `docker volume rm <volume-name>`

---

## 3. Mount Syntax: `-v` vs. `--mount`

Docker provides two command-line flags to specify mounts during `docker run`.

* **`-v` (or `--volume`)**: Consists of three fields separated by colons (`:`).
  * Field 1: Name of the volume (or absolute host path).
  * Field 2: Target path in the container.
  * Field 3 (Optional): Options like `ro` (read-only).
  * *Note*: If the host path/volume doesn't exist, `-v` will silently create it as a directory.
* **`--mount`**: Key-value pair configuration. More verbose, but much clearer and behaves strictly (errors out if the host path doesn't exist).
  * Syntax: `--mount type=<type>,source=<source>,target=<target>[,readonly]`

### Syntax Comparison:

```bash
# Named Volume using -v
docker run -d -v my-db-data:/var/lib/postgresql/data postgres:15

# Named Volume using --mount (Recommended)
docker run -d --mount type=volume,source=my-db-data,target=/var/lib/postgresql/data postgres:15

# Bind Mount using -v
docker run -d -v /home/user/app:/usr/src/app alpine

# Bind Mount using --mount (Recommended)
docker run -d --mount type=bind,source=/home/user/app,target=/usr/src/app alpine
```

---

## Hands-On Exercises

### Exercise 1: Persisting Database Data (Volumes)
Let's spin up a Postgres database container, add data, delete the container, spin up a new container, and verify that the data persists.

1. **Step 1: Create a named volume**
   ```bash
   docker volume create pg-data
   ```
2. **Step 2: Start a Postgres container using the volume**
   ```bash
   docker run -d --name pg-server -v pg-data:/var/lib/postgresql/data -e POSTGRES_PASSWORD=secret postgres:15
   ```
3. **Step 3: Connect to Postgres and create a table**
   ```bash
   docker exec -it pg-server psql -U postgres -d postgres -c "CREATE TABLE test (id INT, val TEXT); INSERT INTO test VALUES (1, 'Persisted!');"
   ```
4. **Step 4: Verify data was written**
   ```bash
   docker exec -it pg-server psql -U postgres -d postgres -c "SELECT * FROM test;"
   ```
5. **Step 5: Destroy the container**
   ```bash
   docker stop pg-server
   docker rm pg-server
   ```
6. **Step 6: Spin up a brand new container using the same volume**
   ```bash
   docker run -d --name pg-server-new -v pg-data:/var/lib/postgresql/data -e POSTGRES_PASSWORD=secret postgres:15
   ```
7. **Step 7: Check if the table still exists**
   ```bash
   docker exec -it pg-server-new psql -U postgres -d postgres -c "SELECT * FROM test;"
   # Expected output: 1 | Persisted!
   ```

---

### Exercise 2: Live HTML Updates (Bind Mounts)
Let's mount a local HTML file directly into an Nginx container so we can edit the page from our host machine and see changes update in real time.

1. **Step 1: Create an index.html file on your host machine**
   ```bash
   # On Windows PowerShell:
   echo "<h1>Hello from the Host!</h1>" > index.html
   ```
2. **Step 2: Start Nginx with a Bind Mount**
   *(Note: Ensure you pass the absolute path of your current directory using `$(pwd)` or `${PWD}`)*
   ```bash
   docker run -d -p 8080:80 --name local-web -v ${PWD}/index.html:/usr/share/nginx/html/index.html nginx:alpine
   ```
3. **Step 3: Test connection**
   ```bash
   curl http://localhost:8080
   # Returns: <h1>Hello from the Host!</h1>
   ```
4. **Step 4: Modify index.html on your host**
   ```bash
   # Open index.html in an editor, edit the text to "Hello updated!", and save it.
   ```
5. **Step 5: Test connection again**
   ```bash
   curl http://localhost:8080
   # Returns: Hello updated! (instantly changed without rebuilding/restarting!)
   ```
6. **Step 6: Cleanup**
   ```bash
   docker stop local-web && docker rm local-web
   ```
