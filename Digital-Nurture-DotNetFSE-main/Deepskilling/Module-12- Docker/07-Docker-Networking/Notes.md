# Docker Networking - Study Notes

Docker networking is used to configure communication tunnels between container instances, the host operating system, and the outside world.

---

## 1. Docker Network Drivers

| Driver | Description | Common Use Case |
|---|---|---|
| **`bridge`** | (Default) Creates a private virtual network on the host. Containers connected to the same bridge can communicate with each other. | Standard applications running on a single host. |
| **`host`** | Bypasses virtual network isolation; container shares host's network namespace and IP directly. | Performance-critical applications or high-throughput services (removes NAT overhead). |
| **`none`** | Disables all networking. Container only has a local loopback interface (`127.0.0.1`). | Highly secure environments, batch processing jobs with no network needs. |
| **`overlay`** | Connects multiple Docker daemons across different hosts together. | Multi-host clustering engines like Docker Swarm. |
| **`macvlan`** | Assigns a physical MAC address to a container, making it look like a physical device on your network router. | Legacy systems needing direct physical IP addresses. |

---

## 2. Network Management Commands

* **List networks**: `docker network ls`
* **Create custom network**: `docker network create [options] <network-name>`
  * Default driver is `bridge` if none is specified using `-d`.
* **Inspect network details**: `docker network inspect <network-name>`
* **Connect container to network**: `docker network connect <network> <container>`
* **Disconnect container from network**: `docker network disconnect <network> <container>`
* **Remove network**: `docker network rm <network-name>`

---

## 3. The Power of User-Defined Bridge Networks

Docker creates a default network named `bridge` when it starts up. However, you should **always create custom bridge networks** for your applications.

### Default Bridge vs. User-Defined Bridge:
1. **Automatic Service Discovery (DNS)**:
   * Inside a **user-defined bridge**, containers can ping and access each other using their **Container Name** as the hostname. Docker runs an internal DNS server to map names to IPs automatically.
   * Inside the **default bridge**, containers can only communicate via raw IP addresses (unless you use legacy `--link` configs).
2. **Better Security & Isolation**:
   * All containers run on the default bridge by default. Creating custom networks isolates your app containers from unrelated containers running on the same host.
3. **Dynamic Network Attachment**:
   * You can connect/disconnect running containers to/from custom networks on the fly.

---

## Hands-On Exercise: Network Isolation & DNS Resolution

Let's create a custom network, run a backend database and a frontend web container, and verify they can communicate using DNS names. We will also verify that containers on a different network cannot reach them.

### Step 1: Create a custom bridge network
```bash
docker network create my-custom-net
```

### Step 2: Spin up a database container on the custom network
```bash
docker run -d --name database-srv --network my-custom-net -e POSTGRES_PASSWORD=secret postgres:15-alpine
```

### Step 3: Spin up a web shell container on the same custom network
```bash
docker run -it --name web-srv --network my-custom-net alpine sh
```
*Now inside the `web-srv` container shell, verify DNS resolution:*
```bash
# Ping the database container by its name!
ping -c 3 database-srv
# Expected: PING database-srv (172.x.x.x) ... 64 bytes ...
exit
```

### Step 4: Test Isolation (Start a container on the default bridge)
Let's launch a container that is *not* on our network and verify it cannot talk to the database.
```bash
docker run -it --name isolated-srv alpine sh
```
*Now inside the `isolated-srv` container shell, try to reach the database:*
```bash
# Attempt to ping database-srv
ping -c 3 database-srv
# Expected: ping: bad address 'database-srv' (DNS doesn't resolve!)
exit
```

### Step 5: Bridge the gap (Connect running container to the network)
While `isolated-srv` is stopped/running, we can manually plug it into our network.
```bash
docker network connect my-custom-net isolated-srv
docker start -ai isolated-srv
# Inside the container again, try to ping:
ping -c 3 database-srv
# Expected: Success!
exit
```

### Step 6: Cleanup
```bash
docker stop database-srv web-srv isolated-srv
docker rm database-srv web-srv isolated-srv
docker network rm my-custom-net
```
