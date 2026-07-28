# Popular DevOps Tools Index

A categorized registry of industry-standard tools across the DevOps lifecycle.

---

## 1. Version Control & Collaboration
Manage source code history and facilitate team collaboration.

* **Git**: The open-source distributed version control system that acts as the absolute baseline for DevOps.
* **GitHub**: A cloud-hosted Git hosting service. It serves as the primary platform for collaboration, code reviews, issues, and pipelines (GitHub Actions).
* **GitLab**: An all-in-one DevOps platform offering Git hosting, CI/CD, issue boards, container registries, and security scanning.
* **Bitbucket**: Atlassian's Git-based code hosting tool, heavily integrated with Jira.

---

## 2. Build Automation & Packaging
Compile source code and package application runtimes.

* **npm / yarn / pnpm**: Dependency management and build orchestration for JavaScript/TypeScript applications.
* **Maven / Gradle**: Build systems and dependency management for Java and JVM-based languages.
* **pip / Poetry**: Package installers and virtual environment managers for Python applications.
* **NuGet**: Package manager for the .NET development ecosystem.

---

## 3. Continuous Integration & Delivery (CI/CD)
Automate builds, test suites, and deployments.

* **GitHub Actions**: Modern, YAML-based cloud pipeline runner built directly into GitHub.
* **Jenkins**: The classic self-hosted automation server with an extensive plugin library.
* **GitLab CI/CD**: Native, runner-based pipeline engine built directly into GitLab.
* **Argo CD**: A declarative GitOps continuous delivery tool specifically for Kubernetes. It synchronizes Kubernetes clusters with Git repositories.
* **CircleCI**: A managed cloud CI/CD platform known for speed and YAML flexibility.

---

## 4. Containerization & Orchestration
Isolate applications and run them at scale.

* **Docker**: The standard platform to package applications with their complete file system, runtimes, and libraries into standardized lightweight containers.
* **Kubernetes (K8s)**: An open-source container orchestration engine for automating deployment, scaling, and management of containerized applications.
* **Helm**: The package manager for Kubernetes, allowing you to define, install, and upgrade complex Kubernetes applications using "Charts".

---

## 5. Infrastructure as Code (IaC) & Configuration Management
Automate server provisioning and configuration.

* **Terraform**: HashiCorp’s open-source tool for provisioning cloud resources (AWS, Azure, GCP) using a declarative configuration language (HCL).
* **Ansible**: An agentless, YAML-based configuration management tool used to configure servers, install packages, and manage files on running machines.
* **Pulumi**: Modern IaC platform that lets you write code to provision infrastructure using general-purpose programming languages (Python, TypeScript, Go).

---

## 6. Observability, Monitoring & Logging
Analyze application logs, system performance, and infrastructure health.

* **Prometheus**: An open-source, time-series database and alerting toolkit designed for scraping metrics from targets.
* **Grafana**: A visualization and analytics platform that turns data from Prometheus, Elasticsearch, or cloud metrics into rich dashboards.
* **ELK / EFK Stack**: Elasticsearch (search engine), Logstash/Fluentd (log ingestion), and Kibana (visualization) for centralized log aggregation.
* **Datadog**: A unified SaaS observability platform tracking application, database, network, and infrastructure performance.

---

## 7. Security & Analysis (DevSecOps)
Scan code and dependencies for security vulnerabilities and code smells.

* **SonarQube**: An open-source platform for continuous inspection of code quality, detecting bugs, code smells, and security hotspots.
* **Snyk**: A developer-first security platform scanning third-party libraries, container images, and IaC templates for CVEs.
* **Trivy**: A simple and comprehensive vulnerability scanner for containers, filesystems, and Git repositories.
