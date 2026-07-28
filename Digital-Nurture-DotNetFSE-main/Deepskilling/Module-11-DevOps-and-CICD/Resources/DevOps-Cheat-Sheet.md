# DevOps Cheat Sheet

A quick-reference guide for core DevOps terminology, essential command-line tools, and container basics.

---

## 📖 Core Terminology & Metrics

### Key DevOps Concepts
* **CALMS**: Culture, Automation, Lean, Measurement, Sharing (the DevOps maturity framework).
* **IaC (Infrastructure as Code)**: Managing and provisioning infrastructure through machine-readable definition files rather than manual configuration (e.g., Terraform, CloudFormation).
* **SRE (Site Reliability Engineering)**: Application of software engineering to infrastructure and operations problems.
* **Toil**: Manual, repetitive, automatable, operational work that provides no enduring value and scales linearly with service size.

### DORA Metrics (Four Key Metrics of DevOps Performance)
1. **Deployment Frequency**: How often an organization successfully releases to production.
2. **Lead Time for Changes**: The time it takes for a commit to go from being written to running in production.
3. **Change Failure Rate**: The percentage of deployments causing a failure in production requiring rollback or hotfix.
4. **Time to Restore Service (MTTR)**: How long it takes to recover from a failure in production.

### Service Level Definitions
* **SLI (Service Level Indicator)**: A quantitative measure of a service's performance (e.g., latency, error rate).
* **SLO (Service Level Objective)**: A target value or range of values for a service level that is measured by an SLI (e.g., SLO: Latency < 200ms for 99% of requests).
* **SLA (Service Level Agreement)**: A commitment between a service provider and a client, often specifying financial penalties if SLOs are not met.

---

## 💻 Essential Linux Commands for Pipelines

These commands are frequently used in runner environments or deployment scripts:

```bash
# Check disk usage of the current directory (good for debug/cleanup)
df -h
du -sh *

# Check system memory usage
free -m

# Search for a specific pattern in logs
grep -i "error" /path/to/logfile.log

# Print environment variables
printenv
echo $MY_VAR

# Check permissions of files
ls -la

# Change file permissions (e.g., make a deployment script executable)
chmod +x ./deploy.sh
```

---

## 🌿 Git Workflows Reference

```bash
# Create and switch to a new feature branch
git checkout -b feature/my-new-feature

# Stage all changes and commit with a message
git add .
git commit -m "feat: implement database connection pool"

# Push local commits to remote tracking branch
git push -u origin feature/my-new-feature

# Pull remote changes and rebase your local branch
git pull --rebase origin main

# View status of files in staging/workspace
git status

# Safely view the commit log (showing only the last 5 commits)
git log -n 5 --oneline
```

---

## 🐳 Docker Command Cheat Sheet

Pipelines frequently build, tag, and run Docker containers:

```bash
# Build a Docker image from a local Dockerfile
docker build -t my-app:latest .

# Run a container in detached mode (background) mapping port 8080 to 80
docker run -d -p 8080:80 --name running-app my-app:latest

# List running containers
docker ps

# Stream logs from a running container
docker logs -f running-app

# Execute an interactive shell inside a running container
docker exec -it running-app /bin/sh

# Remove all unused containers, networks, and images (to free runner space)
docker system prune -f

# Tag and push an image to a registry
docker tag my-app:latest myregistry.azurecr.io/my-app:v1.0.0
docker push myregistry.azurecr.io/my-app:v1.0.0
```
