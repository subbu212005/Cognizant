# Multi-Container Coordination with Docker Compose - Study Notes

Docker Compose allows you to write declarative configuration files in YAML format to orchestrate complex, multi-container application topologies on a single Docker host.

---

## 1. Anatomy of `docker-compose.yml`

A Compose file uses a hierarchical structure to configure the infrastructure components of your application.

```yaml
version: '3.8' # Represents Compose file format version (optional in modern Compose)

services:    # Defines the containers that make up your app
  web:
    build: .             # Path to Dockerfile for building the image
    ports:
      - "5000:5000"      # Port mapping (Host:Container)
    volumes:
      - .:/code          # Bind mount host directory to container path
    environment:
      - FLASK_ENV=development
    depends_on:          # Container dependency order
      - redis

  redis:
    image: "redis:alpine" # Pull pre-built image instead of building

volumes:     # Named volumes shared across services or for persistent data
  db-data:

networks:    # Custom networks to isolate service communication
  frontend:
  backend:
```

### Key Elements:
* **`services`**: Each entry represents a container to run.
* **`build`**: Instructs Compose to compile the image using a Dockerfile at the specified path instead of downloading it.
* **`depends_on`**: Dictates the startup sequence of containers. In the example above, `redis` starts *before* `web`. Note: It only waits for the container to start, not for it to be "healthy" (unless health checks are specified).
* **`networks`**: By default, Compose creates a single default network for your app. All service containers join it and can communicate using their service names as hostnames (e.g. `web` can ping `redis` by typing `ping redis`).

---

## 2. Docker Compose CLI Commands

Ensure you run these commands from the directory containing your `docker-compose.yml` file.

* **`docker compose up`**: Builds, (re)creates, starts, and attaches to containers for a service.
  * `-d` : Run in background (detached mode).
  * `--build` : Force rebuilding images before starting.
* **`docker compose down`**: Stops and removes containers, networks, volumes, and images created by `up`.
  * `-v` : Also remove named volumes declared in the configuration.
* **`docker compose ps`**: Lists containers associated with the compose stack and their states.
* **`docker compose logs`**: View aggregated output logs from all running services.
  * `-f` : Follow log stream.
* **`docker compose exec <service> <command>`**: Runs an interactive command inside a running service container.
  * Example: `docker compose exec db psql -U postgres`

---

## Hands-On Exercise: Python Flask + Redis Hit Counter

Let's build a simple multi-container web app that increments a counter in Redis every time you visit the page.

### 1. The Python App (`app.py`)
```python
import time
import redis
from flask import Flask

app = Flask(__name__)
# Compose DNS resolution allows us to use 'redis' as the hostname!
cache = redis.Redis(host='redis', port=6379)

def get_hit_count():
    retries = 5
    while True:
        try:
            return cache.incr('hits')
        except redis.exceptions.ConnectionError as exc:
            if retries == 0:
                raise exc
            retries -= 1
            time.sleep(0.5)

@app.route('/')
def hello():
    count = get_hit_count()
    return f'Hello World! I have been seen {count} times.\n'
```

### 2. The Python Requirements (`requirements.txt`)
```text
flask
redis
```

### 3. The Dockerfile
```dockerfile
FROM python:3.9-slim
WORKDIR /code
COPY requirements.txt requirements.txt
RUN pip install -r requirements.txt
COPY . .
EXPOSE 5000
CMD ["flask", "run", "--host=0.0.0.0"]
```

### 4. The `docker-compose.yml`
```yaml
version: '3.8'
services:
  web:
    build: .
    ports:
      - "8000:5000"
    environment:
      FLASK_APP: app.py
  redis:
    image: "redis:alpine"
```

### 5. Running and stopping the stack:
```bash
# Start the stack
docker compose up -d

# Verify both containers are running
docker compose ps

# Access your app
curl http://localhost:8000
curl http://localhost:8000

# Stop and clean up the stack
docker compose down
```
