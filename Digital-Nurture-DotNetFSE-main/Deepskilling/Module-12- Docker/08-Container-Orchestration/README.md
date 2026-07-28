# Module 08: Container Orchestration

This sub-module introduces **Container Orchestration**, the practice of managing, scaling, and automating containerized applications across a cluster of multiple host machines (servers). While Docker is great for managing containers on a single host, orchestrators manage containers at scale in production environments.

## Learning Objectives
* Understand why orchestration is required for production deployments.
* Identify the key problems solved by orchestrators (high availability, scaling, load balancing, rolling updates, self-healing).
* Contrast Docker Swarm with Kubernetes (K8s).
* Define core orchestrator concepts: Nodes, Services, Tasks, Pods, and Reconciliation Loops.

## Quick Overview
As your containerized applications grow, managing them manually becomes impossible. You need tools to solve production challenges:
* **How do you deploy containers across 100 servers?**
* **What if a server crashes?** (Self-healing: automatically restart containers on healthy nodes).
* **How do you handle traffic spikes?** (Scaling: run more container replicas).
* **How do you update applications with zero downtime?** (Rolling updates).

Orchestrators continuously monitor the cluster's state and compare it to the declared desired state. If a node fails, the orchestrator automatically schedules new containers elsewhere to reconcile the difference.

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/08-Container-Orchestration/Notes.md)** for a comparison of orchestrators, system architecture components, and scaling workflows.
