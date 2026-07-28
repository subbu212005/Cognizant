# Ready-to-Use Agile Templates

Copy and paste these templates into your project management tools (GitHub, GitLab, Jira) or documentation drives to structure your agile workflows.

---

## 1. User Story Template

Copy this template when creating new issues or tickets in your backlog:

```markdown
# Title: [Brief Action-Oriented Name]

## User Story Description
* **As a** [user persona or role]
* **I want to** [describe the action or feature]
* **So that** [describe the business benefit or value]

---

## Acceptance Criteria (Gherkin Scenarios)

### Scenario 1: [Happy Path Scenario]
* **Given** [the initial state or preconditions]
* **When** [the user performs the action]
* **Then** [the expected outcome]

### Scenario 2: [Alternative/Error Path Scenario]
* **Given** [preconditions]
* **When** [action is taken]
* **Then** [expected outcome]

---

## Technical Tasks (For Developers)
- [ ] Task 1: Create database table schema
- [ ] Task 2: Build API controller and service tests
- [ ] Task 3: Implement frontend UI components
- [ ] Task 4: Hook UI up to backend API

---

## Sizing & Metadata
* **Story Points**: [Fibonacci: 1, 2, 3, 5, 8, 13]
* **Epic Link**: [e.g., Epic-14: User Billing]
* **Dependencies**: [e.g., Blocked by API-12]
```

---

## 2. Sprint Planning Capacity Calculator

Use this template to calculate your team's available bandwidth during Sprint Planning:

```markdown
# Sprint Capacity Sheet

* **Sprint Number**: Sprint [X]
* **Sprint Duration**: [2 Weeks / 10 Working Days]
* **Sprint Goal**: [Write the goal here]

## Developers Available & Capacity

| Developer Name | Working Days | daily hours (Dev) | Focus Factor | Total Capacity (Hours) |
| :--- | :--- | :--- | :--- | :--- |
| Developer A | 10 days | 6 hours | 80% (0.80) | 48.0 hrs |
| Developer B | 10 days | 6 hours | 80% (0.80) | 48.0 hrs |
| Developer C | 8 days (2 PTO) | 6 hours | 80% (0.80) | 38.4 hrs |
| Developer D | 10 days | 6 hours | 80% (0.80) | 48.0 hrs |
| **TOTAL** | **38 days** | | | **182.4 hours** |

*Formula: Working Days × Daily Hours × Focus Factor = Capacity*

---

## Summary Check
* **Total Forecasted Story Points**: [e.g., 28 Points]
* **Total Estimated Task Hours**: [e.g., 172 Hours]
* **Available Capacity**: **182.4 Hours**
* **Capacity Status**: Yes, Under Capacity (10.4 hours safety margin)
```

---

## 3. Sprint Retrospective Templates

Use these templates in your shared documents or whiteboards during retrospectives.

### Option A: Start, Stop, Continue (Action-Oriented)
```markdown
# Sprint Retrospective: Start, Stop, Continue

## START (What should we begin doing?)
* E.g., Start pair programming on complex payment logic to reduce QA reviews.
* E.g., Start updating the API documentation as soon as the PR is merged.

## STOP (What is hurting efficiency that we should stop doing?)
* E.g., Stop pulling in user stories mid-sprint without the PO's approval.
* E.g., Stop holding Daily Scrums that drag on for more than 15 minutes.

## CONTINUE (What went well that we should keep doing?)
* E.g., Continue having weekly backlog refinement sessions.
* E.g., Continue writing Gherkin scenarios for complex checkout stories.
```

### Option B: Glad, Sad, Mad (Emotion & Environment Focus)
```markdown
# Sprint Retrospective: Glad, Sad, Mad

## GLAD (What made you happy or proud?)
* Team collaboration on resolving the payment API blocker was fantastic.
* We successfully hit the Sprint Goal and shipped checkout!

## SAD (What was disappointing or frustrating?)
* Staging environment downtime cost us a full day of testing.
* Technical debt on the legacy user controller made formatting difficult.

## MAD (What made you angry or represents a major risk?)
* Context switching: developers were pulled into three unplanned client calls.
* Code reviews are taking up to 4 days to get reviewed, causing massive backlog.
```
