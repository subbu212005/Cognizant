# Chapter 3 Notes: Hands-On Tools & Configs

---

## 1. Self-Hosted vs. SaaS Pipelines

When choosing a CI/CD platform, engineering organizations decide between running their own infrastructure or renting managed systems in the cloud:

| Dimension | Self-Hosted (e.g., Jenkins, self-hosted GitLab Runners) | Managed SaaS (e.g., GitHub Actions, GitLab CI/CD, CircleCI) |
| :--- | :--- | :--- |
| **Control & Customization** | Complete control over hardware, security, memory, and custom plugins. | Bound by cloud provider options, network limits, and virtual environment configs. |
| **Security & Network** | Excellent. Can run completely inside a private VPC behind firewalls. | Requires configuring secure tunnels, API keys, or OIDC to access private resources. |
| **Maintenance & Overhead** | High. Must manage operating system updates, database backups, and scaling agents. | Zero. The cloud provider handles all backend upgrades and server availability. |
| **Cost Model** | Pay for the underlying servers (ECRs, VMs). Idle servers still cost money. | Pay-as-you-go based on build minutes (e.g., billing per second of runner time). |

---

## 2. Jenkins: Architecture and Jenkinsfile Structure

Jenkins is one of the oldest and most widely used self-hosted build automation engines.

### Controller-Agent Architecture
* **Controller (Master)**: Hosts the web interface, manages configuration, coordinates build scheduling, and monitors agents.
* **Agents (Slaves)**: Small executables running on separate machines (VMs, bare metal, or Kubernetes pods) that perform the actual compilation, testing, and deployment.

### Pipeline Syntax: Declarative vs. Scripted
Modern Jenkins pipelines are written as a `Jenkinsfile`. There are two syntaxes:
1. **Scripted Pipeline**: Imperative Groovy code. Powerful but complex to write and maintain.
2. **Declarative Pipeline**: Structured, opinionated format that makes pipelines easier to read and write.

Here is a standard **Declarative Jenkinsfile** template:

```groovy
pipeline {
    // Defines where the pipeline runs (any available agent)
    agent any 

    // Environment variables used throughout the stages
    environment {
        APP_NAME = 'my-web-app'
    }

    stages {
        stage('Install') {
            steps {
                echo 'Installing dependencies...'
                sh 'npm install'
            }
        }
        stage('Test') {
            steps {
                echo 'Running test suite...'
                sh 'npm test'
            }
        }
        stage('Build') {
            steps {
                echo 'Packaging application...'
                sh 'npm run build'
            }
        }
    }

    // Runs after all stages finish, based on status
    post {
        always {
            echo 'Cleaning up workspace...'
        }
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed. Sending alert...'
        }
    }
}
```

---

## 3. GitLab CI/CD: Core Concepts & YAML

GitLab CI/CD uses a YAML file named `.gitlab-ci.yml` placed in the root of the repository. It is tightly integrated with GitLab repositories and merge requests.

### Core Concepts
* **Stages**: Define *when* to run jobs. Jobs in the same stage run in parallel.
* **Jobs**: Define *what* to run. Each job contains a script command to execute on a GitLab Runner.

### Example `.gitlab-ci.yml`
```yaml
# Global docker image to run commands inside
image: node:18-alpine

# Define stage execution order
stages:
  - test
  - build

# Job 1: Run unit tests
run-tests:
  stage: test
  script:
    - npm ci
    - npm run test:unit

# Job 2: Compile application
compile-app:
  stage: build
  script:
    - npm ci
    - npm run build
  artifacts:
    paths:
      - dist/
    expire_in: 1 week
```

---

## 4. GitHub Actions Deep Dive

GitHub Actions is a powerful, modern SaaS-based automation tool integrated directly into GitHub repositories.

### The Architecture
* **Workflow**: An automated procedure written in YAML in the `.github/workflows/` directory.
* **Event**: A specific activity that triggers the workflow (e.g., `push`, `pull_request`, `schedule`).
* **Runner**: A virtual machine (Ubuntu, Windows, macOS) hosted by GitHub (or self-hosted) that executes the jobs.
* **Job**: A set of sequential steps executed on the *same runner*. Jobs run in parallel by default, but can depend on one another.
* **Step**: An individual task. Can be a shell script (running commands) or an **Action** (reusable package).
* **Action**: Reusable code blocks from the GitHub Marketplace (e.g., `actions/checkout` or `actions/setup-node`).

### Re-usable Actions vs. Custom Scripts
An Action is referenced using `uses: creator/action-name@version`. This abstracts complex commands. For example, setting up Node.js with caching takes 20 lines of bash but is simplified with a marketplace action:

```yaml
- name: Set up Node.js
  uses: actions/setup-node@v3
  with:
    node-version: '18'
```

### GitHub Actions Secrets Management
Never hardcode credentials, passwords, or API tokens in your repository. GitHub allows you to store these securely in repository settings:
* Save them under **Settings** > **Secrets and variables** > **Actions**.
* Reference them in your YAML file using the context expression syntax: `${{ secrets.MY_SECRET_NAME }}`.
* GitHub automatically masks secrets in the console logs with asterisks (`***`).

### Cache Management
To speed up pipeline execution, you can cache dependencies (like `node_modules` or `.m2` packages) between builds so the runner doesn't have to download them every time:

```yaml
- name: Cache npm dependencies
  uses: actions/cache@v3
  with:
    path: ~/.npm
    key: ${{ runner.os }}-node-${{ hashFiles('**/package-lock.json') }}
    restore-keys: |
      ${{ runner.os }}-node-
```

---

## 5. Platform Comparison Matrix

| Criteria | Jenkins | GitHub Actions | GitLab CI/CD |
| :--- | :--- | :--- | :--- |
| **Config File** | `Jenkinsfile` (Groovy DSL) | `.github/workflows/*.yml` (YAML) | `.gitlab-ci.yml` (YAML) |
| **Hosting Model** | Self-hosted only | SaaS (Hosted by GitHub) or Self-hosted runners | SaaS (Hosted by GitLab) or Self-hosted runners |
| **Ecosystem** | Thousands of community plugins | Reusable actions in GitHub Marketplace | Built-in features (Auto DevOps, container registry) |
| **Setup Speed** | Slow (requires provisioning a server) | Instant (just commit a YAML file) | Instant (just commit a YAML file) |
| **Integrations** | Highly adaptable via plugins | Native to GitHub | Native to GitLab |
