# The Definition of Done (DoD)

The Definition of Done (DoD) is a formal quality checklist that a Product Backlog item must meet before it can be considered a complete, shippable Increment. It ensures the team maintains high technical standards and prevents bugs from slipping into production.

---

## Definition of Done vs. Acceptance Criteria

It is common to confuse the **Definition of Done** with **Acceptance Criteria**. However, they operate at different levels:

| Attribute | Acceptance Criteria (AC) | Definition of Done (DoD) |
| :--- | :--- | :--- |
| **Scope** | **Story-specific**. Applies to one user story. | **Global**. Applies to *all* user stories. |
| **Focus** | Functional requirements and business logic. | Technical quality, engineering standards, and deployment. |
| **Owner** | Product Owner (in collaboration with the team). | The Developers / Organization. |
| **Example** | *"Users must be blocked from typing passwords shorter than 8 characters."* | *"Code reviewed by peer, unit test coverage >= 80%, CI build passes."* |

---

## Sample Definition of Done Checklist

Here is an industry-standard Definition of Done checklist that cross-functional software teams can adopt:

### 1. Code Quality & Standards
* [ ] **Peer Review**: Code has been reviewed by at least one other developer.
* [ ] **Linting & Formatting**: Code conforms to the team's style guide and linting rules.
* [ ] **No Hardcoded Values**: Configuration, secrets, and credentials are externalized.

### 2. Testing & Validation
* [ ] **Unit Tests**: New code has associated unit tests, and no existing tests are broken.
* [ ] **Coverage**: Test coverage meets or exceeds the team threshold (e.g., 80%).
* [ ] **Integration/API Tests**: Critical integration paths have been verified.
* [ ] **Manual Verification**: The feature was tested in a local or staging environment.

### 3. Continuous Integration & Deployment
* [ ] **CI Build Passing**: The branch builds successfully on the build server.
* [ ] **Static Analysis**: Security scanners and code complexity analyzers report zero high-severity warnings.
* [ ] **Deployed to Staging**: The build has successfully deployed to the staging environment.

### 4. Documentation & Compliance
* [ ] **Documentation**: API documentation (Swagger/OpenAPI), READMEs, or user guides are updated.
* [ ] **Release Notes**: A brief summary of user-facing changes is added to the release log.

---

## How to Establish a DoD

1. **Collaborative Definition**: The Scrum Team gathers during a Sprint Retrospective or setup meeting to discuss and agree upon the DoD.
2. **Quality over Speed**: The DoD should be realistic. If the team cannot automate testing yet, do not put "100% automated test coverage" in the DoD. Start with a basic DoD and strengthen it over time.
3. **Never Compromise**: If a story fails a single item in the DoD, it *cannot* be marked as "Done". It goes back to the backlog or stays in progress.

> [!CAUTION]
> **"Done" means Shippable**. If your team says "the code is done, we just need to test it next sprint," then it is **not done**. This creates "technical debt" and distorts velocity calculations.
