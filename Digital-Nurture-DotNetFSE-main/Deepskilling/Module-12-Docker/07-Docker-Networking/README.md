# Module 07: Docker Networking

This sub-module covers the mechanisms that enable Docker containers to communicate with each other, with the host machine, and with external networks. We will cover network drivers, custom network bridges, DNS service resolution, and port publishing.

## 🎯 Learning Objectives
* Understand Docker's network isolation model.
* Differentiate between core network drivers: **bridge**, **host**, **none**, **overlay**, and **macvlan**.
* Create and manage user-defined bridge networks.
* Understand automatic DNS lookup inside custom networks.
* Learn network security configurations and isolation policies.

## 💡 Quick Overview
By default, Docker isolates containers from the host network and other containers. To allow communication, Docker uses virtual network interfaces and iptables rules.

Docker provides various drivers to support different networking configurations:
* **`bridge`**: The default network driver. Best for applications running in standalone containers that need to communicate on the same host.
* **`host`**: Removes network isolation between the container and the Docker host. The container uses the host's networking namespace directly (and shares port space).
* **`none`**: Disables all networking for the container.

Refer to the accompanying **[Notes.md](file:///c:/Users/subbu/Downloads/Module-12-Containerization-Using-Docker/07-Docker-Networking/Notes.md)** for CLI networking commands, DNS resolution details, and hands-on networking exercises.
