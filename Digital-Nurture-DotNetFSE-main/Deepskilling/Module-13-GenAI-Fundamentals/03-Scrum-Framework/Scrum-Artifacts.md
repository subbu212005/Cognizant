# The Scrum Artifacts

Scrum's artifacts represent work or value. They are designed to maximize transparency of key information. Each artifact contains a commitment to provide information that enhances transparency and measures progress.

---

## Artifacts and Commitments at a Glance

| Artifact | Description | Commitment | Purpose of Commitment |
| :--- | :--- | :--- | :--- |
| **Product Backlog** | An ordered, emerging list of what is needed to improve the product. | **Product Goal** | Describes a future state of the product which can serve as a target for the team to plan against. |
| **Sprint Backlog** | The set of Product Backlog items selected for the Sprint, plus a plan for delivering them. | **Sprint Goal** | The single objective for the Sprint, creating focus and alignment. |
| **Increment** | A concrete step toward the Product Goal. Each Increment is additive to all prior Increments. | **Definition of Done** | A formal description of the state of the Increment when it meets the quality measures required for the product. |

---

## Detailed Breakdown of Artifacts

### 1. The Product Backlog
The single source of work for the Scrum Team. It is dynamic, constantly changing to incorporate new customer insights, business requirements, and technical improvements.
* **Refinement**: The act of breaking down and further defining Product Backlog items into smaller, more precise items. This is an ongoing activity to add details, estimates, and order.
* **Commitment: The Product Goal**: The Product Goal describes a future state of the product that can serve as a target for the Scrum Team to plan against. The team must fulfill (or abandon) one goal before taking on the next.

### 2. The Sprint Backlog
The Sprint Backlog is composed of:
1. The **Sprint Goal** (Why we are doing the sprint).
2. The set of **Product Backlog items** selected for the Sprint (What we are building).
3. An **actionable plan** for delivering the Increment (How we are building it).
* **Ownership**: The Sprint Backlog is created by and for the Developers. It is updated throughout the Sprint as more is learned.

### 3. The Increment
An Increment is a concrete stepping stone toward the Product Goal. Multiple Increments may be created within a Sprint. The sum of all Increments is presented at the Sprint Review.
* **Potentially Releasable**: An Increment must be usable and meet the Definition of Done. It can be released to users at any time (even mid-sprint) at the Product Owner's discretion.
* **Commitment: The Definition of Done (DoD)**: A formal declaration of quality. The moment a Product Backlog item meets the Definition of Done, an Increment is born. If an item does not meet the DoD, it cannot be released or presented at the Sprint Review.

---

## Artifact Transparency and the Board
Agile teams often use a **Kanban Board** or **Scrum Board** to visually radiate the status of these artifacts. This ensures anyone inside or outside the team can see the status of the work instantly.

```
+-------------------------------------------------------------+
|                       SPRINT BOARD                          |
|  Sprint Goal: Enable secure checkout using credit cards     |
+---------------------+---------------------+-----------------+
|     TO DO           |     IN PROGRESS     |      DONE       |
+---------------------+---------------------+-----------------+
| [ ] Integrate API   | [/] Build Card Form | [x] Create DB   |
| [ ] Add Validation  |                     |     Schema      |
+---------------------+---------------------+-----------------+
```
