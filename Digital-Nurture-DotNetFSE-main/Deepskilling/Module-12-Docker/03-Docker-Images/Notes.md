# Building Docker Images - Study Notes

Docker images are composed of read-only layers. Each layer represents an instruction in the image's Dockerfile.

---

## 1. Dockerfile Instruction Reference

A `Dockerfile` is a text document containing all the commands a user could call on the command line to assemble an image.

* **`FROM`**: Sets the base image for subsequent instructions. Must be the first instruction.
  ```dockerfile
  FROM node:18-alpine
  ```
* **`WORKDIR`**: Sets the working directory for any subsequent `RUN`, `CMD`, `ENTRYPOINT`, `COPY`, and `ADD` instructions. If it doesn't exist, it is created.
  ```dockerfile
  WORKDIR /usr/src/app
  ```
* **`COPY` / `ADD`**: Copies files from the host to the container file system.
  * *Tip*: Prefer `COPY` over `ADD`. `ADD` has extra features like remote URL downloads and auto-extraction of tar files, which are usually not needed and can lead to unexpected behavior.
  ```dockerfile
  COPY package*.json ./
  ```
* **`RUN`**: Executes commands in a new layer and commits the results. Used to install dependencies.
  ```dockerfile
  RUN npm install --production
  ```
* **`ENV`**: Sets environment variables that persist when the container runs.
  ```dockerfile
  ENV NODE_ENV=production
  ```
* **`EXPOSE`**: Documentational statement indicating the ports the container listens on at runtime. (Does not actually publish ports).
  ```dockerfile
  EXPOSE 3000
  ```
* **`USER`**: Sets the user name or UID to use when running the image (important for security).
  ```dockerfile
  USER node
  ```

---

## 2. `CMD` vs. `ENTRYPOINT`

Both instructions define the process that runs when the container starts, but they behave differently.

| Instruction | Primary Purpose | Overridability |
|---|---|---|
| **`ENTRYPOINT`** | Defines the main executable of the container. | Hard to override (requires `--entrypoint` flag). |
| **`CMD`** | Defines default arguments passed to `ENTRYPOINT`. Or default command if no `ENTRYPOINT` is defined. | Very easy to override (just pass arguments at the end of `docker run`). |

### Recommended Pattern: Coexistence
Use `ENTRYPOINT` for the main program executable, and `CMD` for the default flags.
```dockerfile
ENTRYPOINT ["ping"]
CMD ["localhost"]
```
* Running `docker run my-ping` executes `ping localhost`.
* Running `docker run my-ping google.com` overrides `CMD` and executes `ping google.com`.

---

## 3. Layer Caching and Build Optimization

Docker caches build layers to speed up subsequent builds. If a layer's instruction or any referenced files haven't changed, Docker reuses the cached layer.

### Rule of Cache Invalidation
If a step is invalidated (e.g., source code changes), **all subsequent steps are also invalidated** and rebuilt from scratch.

### Cache-Optimized Dockerfile Structure
Put instructions that change least frequently at the top, and code that changes frequently at the bottom.
```dockerfile
# GOOD: Dependencies cached separately from code changes
FROM node:18-alpine
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
CMD ["node", "server.js"]
```

---

## 4. Multi-Stage Builds

Multi-stage builds allow you to use multiple temporary images during building, but only copy the final build artifacts into the runtime image. This dramatically reduces final image size.

### Example: Compiling a Go Application
```dockerfile
# --- Stage 1: Build Environment ---
FROM golang:1.20-alpine AS builder
WORKDIR /src
COPY go.mod go.sum ./
RUN go mod download
COPY . .
RUN CGO_ENABLED=0 GOOS=linux go build -o myapp .

# --- Stage 2: Minimal Runtime Environment ---
FROM alpine:3.18
WORKDIR /app
# Copy only the compiled binary from the builder stage
COPY --from=builder /src/myapp /app/myapp
EXPOSE 8080
CMD ["/app/myapp"]
```
*The resulting image only contains the `alpine` OS and the compiled `myapp` binary (typically ~20MB instead of Go compiler size ~800MB).*

---

## 💻 Hands-On Exercise: Containerizing a Simple Node.js App

1. **Create a `package.json`**:
   ```json
   {
     "name": "simple-app",
     "version": "1.0.0",
     "main": "index.js",
     "dependencies": {
       "express": "^4.18.2"
     }
   }
   ```
2. **Create a simple `index.js` web server**:
   ```javascript
   const express = require('express');
   const app = express();
   app.get('/', (req, res) => res.send('Hello from Dockerized App!'));
   app.listen(3000, () => console.log('Listening on port 3000'));
   ```
3. **Write the cache-friendly `Dockerfile`**:
   ```dockerfile
   FROM node:18-alpine
   WORKDIR /usr/src/app
   COPY package*.json ./
   RUN npm install
   COPY . .
   EXPOSE 3000
   CMD ["node", "index.js"]
   ```
4. **Build and test the image**:
   ```bash
   docker build -t simple-app:1.0 .
   docker run -d -p 3000:3000 --name running-app simple-app:1.0
   curl http://localhost:3000
   ```
