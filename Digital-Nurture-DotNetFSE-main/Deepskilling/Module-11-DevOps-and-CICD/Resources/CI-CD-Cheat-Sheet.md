# CI/CD Pipeline Cheat Sheet

A technical reference for constructing, optimizing, and debugging deployment pipeline files.

---

## 🐙 GitHub Actions Syntax Reference

A comprehensive, annotated template for a Node.js project that builds, tests, builds a Docker image, and deploys it:

```yaml
# Name of the workflow visible in the GitHub UI
name: Continuous Integration & Deployment

# Define the events that trigger the workflow
on:
  push:
    branches: [ main, release/* ]
  pull_request:
    branches: [ main ]
  # Allows you to run this workflow manually from the Actions tab
  workflow_dispatch:

# Environment variables available to all jobs
env:
  DOCKER_REGISTRY: myregistry.azurecr.io
  IMAGE_NAME: frontend-app

jobs:
  # Job 1: Run automated tests
  test:
    runs-on: ubuntu-latest # OS of the runner
    steps:
      # Step 1: Check out the code
      - name: Checkout Code
        uses: actions/checkout@v3

      # Step 2: Configure runtime environment
      - name: Setup Node.js
        uses: actions/setup-node@v3
        with:
          node-version: '18.x'
          cache: 'npm' # Speeds up installation by caching node_modules

      # Step 3: Install dependencies
      - name: Install Dependencies
        run: npm ci

      # Step 4: Run unit & integration tests
      - name: Run Tests
        run: npm test

  # Job 2: Build and Package Container (Only runs if 'test' succeeds)
  build-and-package:
    needs: test # Creates job dependency
    runs-on: ubuntu-latest
    # Only run build step on push events (commits to main), not on PR checks
    if: github.event_name == 'push'
    
    steps:
      - name: Checkout Code
        uses: actions/checkout@v3

      - name: Set up Docker Buildx
        uses: docker/setup-buildx-action@v2

      # Authenticate to the container registry using repository secrets
      - name: Log in to Registry
        uses: docker/login-action@v2
        with:
          registry: ${{ env.DOCKER_REGISTRY }}
          username: ${{ secrets.REGISTRY_USERNAME }}
          password: ${{ secrets.REGISTRY_PASSWORD }}

      # Build and push the Docker image
      - name: Build and Push Image
        uses: docker/build-push-action@v4
        with:
          context: .
          push: true
          tags: |
            ${{ env.DOCKER_REGISTRY }}/${{ env.IMAGE_NAME }}:${{ github.sha }}
            ${{ env.DOCKER_REGISTRY }}/${{ env.IMAGE_NAME }}:latest
```

---

## 🦊 GitLab CI/CD Syntax Reference

A standard `.gitlab-ci.yml` template structure:

```yaml
# Global docker image to execute steps
image: node:18-alpine

# Define pipeline execution phases
stages:
  - install
  - test
  - deploy

# Define global variables
variables:
  STAGING_SERVER_IP: "192.168.1.50"

# Global caching rules (cache node_modules across jobs)
cache:
  key: ${CI_COMMIT_REF_SLUG}
  paths:
    - .npm/

before_script:
  - npm ci --cache .npm --prefer-offline

# Install dependencies job
install_dependencies:
  stage: install
  script:
    - npm install
  artifacts:
    paths:
      - node_modules/
    expire_in: 1 day

# Run tests job
run_unit_tests:
  stage: test
  dependencies:
    - install_dependencies
  script:
    - npm run test:unit

# Deployment job (triggered manually on main branch)
deploy_to_staging:
  stage: deploy
  dependencies: []
  script:
    - echo "Deploying build to staging server..."
    - ssh deploy_user@$STAGING_SERVER_IP "docker pull my-app:latest && docker run -d my-app:latest"
  rules:
    - if: $CI_COMMIT_BRANCH == "main"
      when: manual # Requires manual approval in UI
```

---

## 💡 Pipeline Best Practices

1. **Pin Action/Plugin Versions**: Avoid using mutable tags like `@master` or `@v1` in production pipelines. Use exact commit hashes or precise version tags (e.g., `actions/checkout@v3.5.2`) to prevent upstream changes from breaking your pipeline.
2. **Fail Fast**: Put fast, lightweight checks (like linting and SAST security scans) at the very beginning of the pipeline. Do not wait for a 20-minute end-to-end integration test to run if there is a basic formatting error.
3. **Use Artifacts for Communication**: Never rebuild application packages between stages. Pass compiler outputs or zipped bundles from one stage to another using the pipeline engine's built-in artifact caching.
4. **Make Jobs Idempotent**: A pipeline job should produce the exact same outcome whether run once or ten times. This is especially true for deployment steps (e.g., use `kubectl apply -f config.yaml` rather than commands that append data).
5. **Enforce Build Time Limits**: Set explicit timeouts on jobs (e.g., `timeout-minutes: 15`). This prevents a stuck command or frozen test suite from running indefinitely and draining your build credit limits.
