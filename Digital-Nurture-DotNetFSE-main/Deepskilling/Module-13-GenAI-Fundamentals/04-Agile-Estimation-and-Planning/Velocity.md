# Velocity: Measuring and Forecasting Team Speed

Velocity is a key metric in Scrum. It measures the amount of work a team can successfully complete (i.e., meet the Definition of Done) during a single sprint.

---

## How to Calculate Velocity

Velocity is calculated by summing the Story Points of all backlog items marked **Done** at the end of a sprint.

### The Golden Rule of Velocity
**Only count fully completed stories.** If a story is 8 points and is 90% done at the end of the sprint, the team gets **0 points** toward velocity for that sprint. The story rolls over to the next sprint, and its points are counted only when it is completed.

### Example Calculation
Let's track a team's velocity over 4 sprints:

| Sprint | Forecasted Points | Completed Points (Done) | Notes |
| :--- | :--- | :--- | :--- |
| **Sprint 1** | 30 | 22 | Rolled over an 8-point story. |
| **Sprint 2** | 30 | 34 | Completed the rollover + new stories. |
| **Sprint 3** | 32 | 28 | One story failed QA. |
| **Sprint 4** | 30 | 32 | Completed ahead of schedule. |
| **Average** | **30.5** | **29** | **Average Velocity = 29 points** |

To forecast future sprints, the team uses their **Average Velocity** (usually calculated over the last 3 to 5 sprints). For the upcoming Sprint 5, the team should forecast around **29 points** of work.

---

## Release Forecasting using Velocity

Product Owners use velocity to estimate project completion dates or forecast features for a specific release.

### Example Scenario
* The Product Owner wants to release a new mobile app module containing **120 Story Points** of features.
* The team's average velocity is **30 points per sprint**.
* Sprints are **2 weeks** long.

$$\text{Sprints Required} = \frac{\text{Total Release Backlog Story Points}}{\text{Average Velocity}} = \frac{120}{30} = 4 \text{ sprints}$$
$$\text{Calendar Time} = 4 \text{ sprints} \times 2 \text{ weeks} = 8 \text{ weeks}$$

The Product Owner can confidently forecast a release in **8 weeks** (assuming velocity remains stable).

---

## Common Velocity Anti-Patterns

Velocity is a **diagnostic planning tool**, not a performance metric. When organizations misuse it, it causes severe issues:

### 1. Comparing Velocity Between Teams
* **The Error**: Management asks: *"Why is Team A's velocity 50 points, while Team B's is only 20 points? Team A must be better."*
* **Why it's wrong**: Story points are relative to each team. Team A's 5-point story might be equivalent to Team B's 2-point story. Comparing them is meaningless.

### 2. Velocity Inflation (Point Bloat)
* **The Error**: When managers demand that teams "increase their velocity," developers respond by inflating their estimates.
* **Why it's wrong**: A story that was estimated as a `3` is now estimated as an `8`. The velocity graph goes up, but the actual volume of shipped software remains exactly the same.

### 3. Weaponizing Velocity
* **The Error**: Using velocity as a performance review metric for individual developers.
* **Why it's wrong**: This kills team collaboration. Developers will refuse to help their peers, pair-program, or write tests because they are focused on claiming points for themselves.
