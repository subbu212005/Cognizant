# Agile & Scrum Cheat Sheet

A quick-reference guide for agile developers, Scrum Masters, and Product Owners.

---

## Scrum Roles Quick Ref

* **Product Owner (PO)**: Focuses on **value and scope**. Owns the *Product Backlog*. Decides *What* to build and *Why*.
* **Scrum Master (SM)**: Focuses on **process and effectiveness**. Servant leader, coach, process champion, and impediment remover.
* **Developers**: Focus on **technical delivery and quality**. Own the *Sprint Backlog*. Decide *How* to build and *When* (forecast).

---

## Scrum Events & Timeboxes (For 2-Week Sprint)

* **The Sprint**: 2 Weeks (fixed container).
* **Sprint Planning**: 4 Hours max (Goal: create Sprint Goal and Sprint Backlog).
* **Daily Scrum**: 15 Minutes daily (Goal: inspect progress toward Sprint Goal, plan next 24 hours).
* **Sprint Review**: 2 Hours max (Goal: demonstrate working software, gather feedback).
* **Sprint Retrospective**: 1.5 Hours max (Goal: inspect process, plan team improvements).

---

## Artifacts & Commitments

* **Product Backlog** -> Commitment: **Product Goal** (The long-term vision).
* **Sprint Backlog** -> Commitment: **Sprint Goal** (The focus of the sprint).
* **Increment** -> Commitment: **Definition of Done (DoD)** (The quality bar).

---

## Agile Formulas

### 1. Sprint Capacity
$$\text{Capacity} = \text{Developers} \times \text{Working Days} \times \text{Active Dev Hours/Day} \times \text{Focus Factor}$$
* *Default hours*: 6 hours/day.
* *Default Focus Factor*: 70% to 80% (0.7 to 0.8).

### 2. Velocity Forecasting
$$\text{Average Velocity} = \frac{\text{Sum of Completed Story Points in Past Sprints}}{\text{Number of Sprints}}$$
* Use average velocity of the last 3-5 sprints to forecast capacity for the next sprint.

### 3. Release Estimation
$$\text{Sprints Required} = \frac{\text{Total Release Backlog Story Points}}{\text{Average Velocity}}$$

---

## Story Writing Checklists

### INVEST Criteria (Story Quality)
* **I**ndependent: Sliced vertically, can be delivered on its own.
* **N**egotiable: Invitation to conversation, not a contract.
* **V**aluable: Delivers clear benefit to the user.
* **E**stimable: Developers understand it enough to size.
* **S**mall: Can be done in 1-4 days of work.
* **T**estable: Clear success criteria.

### The 3 C's
1. **Card**: The placeholder/ticket description.
2. **Conversation**: Collaborative discussions to refine understanding.
3. **Confirmation**: Acceptance criteria (tests) that confirm completion.
