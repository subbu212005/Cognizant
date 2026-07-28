# Sprint Planning: Capacity & Commitments

Sprint Planning is the event that kicks off a new sprint. The outcome is a clear Sprint Goal and a committed Sprint Backlog that the team forecasts they can deliver.

---

## Mechanics of Sprint Planning

Sprint Planning is divided into two parts:

### Part 1: What to Build & Why (Value Focus)
* **Goal**: Establish a **Sprint Goal** based on the Product Owner's priorities.
* **Process**: The PO presents the highest-priority backlog items. The team reviews the requirements, ensures they meet the **Definition of Ready** (fully refined), and selects the items that align with the Sprint Goal.

### Part 2: How to Build It (Technical Focus)
* **Goal**: Decompose stories into technical tasks and confirm the team's capacity.
* **Process**: The Developers discuss the technical design, create sub-tasks (usually estimated in hours for tracking), and confirm that they can realistically accomplish the forecasted scope.

---

## Calculating Team Capacity

To avoid over-committing, teams must calculate their **Capacity** (the actual hours/days available for work) before selecting backlog items.

### Capacity Formula
$$Capacity = \text{Developers} \times \text{Working Days} \times \text{Daily Available Hours} \times \text{Focus Factor}$$

#### Variable Explanations:
1. **Developers**: Only count people writing, testing, or designing code. Do not count the Scrum Master or Product Owner.
2. **Working Days**: Total days in the sprint minus holidays and vacation days.
3. **Daily Available Hours**: A standard 8-hour workday is never fully spent on sprint tasks. Meetings, emails, and admin tasks eat up time. Most teams assume **6 hours** of active development time.
4. **Focus Factor**: A percentage reflecting team focus and efficiency (typically **70% to 80%** to account for context switching and unplanned interruptions).

### Example Calculation
* A team of **5 developers** on a **2-week sprint** (10 working days).
* One developer is taking **2 days off** (total working days = $10 + 10 + 10 + 10 + 8 = 48$ developer-days).
* Daily hours = 6. Focus Factor = 80%.

$$Capacity = 48 \text{ days} \times 6 \text{ hours} \times 0.80 = 230.4 \text{ hours}$$

The team has roughly **230 hours** of capacity to complete the sprint tasks.

---

## Establishing the Sprint Goal

A common failure in Scrum is having a list of unrelated tasks without a unifying goal. A true Sprint Goal should be:
* **Specific**: Focus on a single theme or business value.
* **Flexible**: Allows developers to negotiate the scope of user stories if they hit technical roadblocks, while still delivering the core value.
* **Measurable**: The team knows exactly when they have achieved it.

* 👍 *Good Sprint Goal*: *"Enable checkout using credit card payments to launch our payment processing system."*
* 👎 *Bad Sprint Goal*: *"Finish JIRA tickets 124, 185, and 234."*
