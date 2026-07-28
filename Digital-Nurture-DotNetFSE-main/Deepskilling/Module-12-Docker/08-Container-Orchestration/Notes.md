# Container Orchestration - Study Notes

When moving from a single development laptop to production clusters containing hundreds of servers, standalone Docker is no longer sufficient. Container Orchestrators automate the deployment, scaling, networking, and availability of containerized workloads.

---

## 1. Key Production Challenges Solved by Orchestration

1. **High Availability / Self-Healing**: If a server (node) hosting your application crashes, the orchestrator detects the failure and automatically redeploys those containers on operational servers.
2. **Horizontal Scaling**: Scale the number of container replicas up or down dynamically depending on traffic load.
3. **Load Balancing**: Distribute network traffic evenly across all running container replicas.
4. **Service Discovery**: Allow containers to find and communicate with each other dynamically across a multi-host network.
5. **Rolling Updates & Rollbacks**: Update applications to new versions one container at a time without causing system-wide downtime. If an update fails, automatically roll back to the previous version.
6. **Secret and Config Management**: Securely inject API keys, certificates, and configuration parameters into running containers without baking them into images.

---

## 2. Docker Swarm vs. Kubernetes (K8s)

These are the two primary tools used to orchestrate containerized applications.

| Feature | Docker Swarm | Kubernetes (K8s) |
|---|---|---|
| **Origin & Focus** | Created by Docker. Focuses on simplicity and integration. | Open-sourced by Google. Focuses on scaling, complexity, and extensibility. |
| **Learning Curve** | Extremely low. Uses standard Docker CLI and compose-like syntax. | Very high. Requires understanding many new concepts and API objects. |
| **Installation & Setup** | Built into Docker Engine (`docker swarm init`). Runs out-of-the-box. | Complex to set up from scratch. Typically uses managed clouds (EKS, GKE) or local test tools (Minikube). |
| **Scalability** | Good for small to medium workloads. | Exceptional. Scales to thousands of nodes and tens of thousands of pods. |
| **Ecosystem & Community** | Smaller, stable, less active. | Massive. The industry standard with a huge community (CNCF) and thousands of plugins. |

---

## 3. Core Orchestration Concepts

To understand how orchestrators work, you must grasp these fundamental design patterns:

### A. Declarative State vs. Actual State
* **Desired State (Declarative)**: The user defines *what* the application should look like (e.g., "Run exactly 5 replicas of `my-web-app` version 2.0").
* **Actual State**: The current real-world status of the cluster (e.g., Only 4 replicas are running because one crashed).
* **Reconciliation Loop**: The core control loop of the orchestrator. It continuously monitors the cluster, detects when `Actual State != Desired State`, and executes commands to fix the gap (e.g., launches 1 new container to restore the count to 5).

### B. Cluster Topology: Control Plane & Workers
* **Control Plane (Master Nodes)**: The brains of the cluster. It makes global decisions (e.g. scheduling containers), detects events, and manages the state registry.
* **Worker Nodes**: The muscles of the cluster. These servers run the actual containers and execute instructions received from the Control Plane.

### C. Basic Kubernetes API Abstractions (Introductory)
* **Pod**: The smallest deployable unit in Kubernetes. A Pod hosts one or more tightly coupled containers that share network and storage resources.
* **Deployment**: Declares the desired state for Pods (e.g., replica count, image version) and manages rolling updates.
* **Service**: Defines a logical set of Pods and a policy to access them (provides a stable IP address and DNS name to balance load across the pods).
* **Namespace**: Virtual clusters within a physical cluster to partition resources and provide tenancy isolation.
