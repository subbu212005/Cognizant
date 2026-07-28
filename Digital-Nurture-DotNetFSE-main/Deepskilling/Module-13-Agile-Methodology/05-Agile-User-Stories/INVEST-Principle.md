# The INVEST Principle

The **INVEST** acronym, created by Bill Wake, serves as a quality checklist for writing high-performing user stories. If a story fails any of these criteria, it should be refined before being pulled into a sprint.

---

## INVEST Criteria Breakdown

| Letter | Principle | Description |
| :--- | :--- | :--- |
| **I** | **Independent** | Stories should be self-contained and free of tight coupling with other stories. |
| **N** | **Negotiable** | A story is not a rigid specification; it leaves room for discussion and technical trade-offs. |
| **V** | **Valuable** | The story must deliver clear value to the end-user or business. |
| **E** | **Estimable** | The developers must understand the story well enough to estimate its size/effort. |
| **S** | **Small** | The story should be small enough to be completed comfortably within a single sprint (ideal is 1-4 days). |
| **T** | **Testable** | The story must have clear criteria to verify success or failure (Acceptance Criteria). |

---

## Detailed Explanations & Examples

### 1. Independent
* **Concept**: Avoid chaining stories where Story B cannot start until Story A is fully completed. Dependencies make sprint planning difficult and lead to bottlenecks.
* ❌ *Dependent*: *"Story A: Build the Postgres database schema. Story B: Build the login API. Story C: Build the login page UI."*
* 👍 *Independent (Slicing Vertically)*: *"As a guest, I want to log in using my email and password so that I can access my profile."* (Builds vertical slices of database, API, and UI together).

### 2. Negotiable
* **Concept**: The story should describe what needs to be achieved, not how. It is an invitation to a conversation where the PO and developers discuss the best implementation.
* ❌ *Non-Negotiable*: *"We must use a SQL stored procedure on the checkout server to process payments by Thursday morning."*
* 👍 *Negotiable*: *"As a shopper, I want to pay using a credit card so that I can complete my purchase."*

### 3. Valuable
* **Concept**: Stories must deliver value to the user, not just technical tasks.
* ❌ *No Direct Value*: *"Refactor the checkout database query."* (This is a task/refactoring. If needed, wrap it under a user-facing story, or make it a technical task).
* 👍 *Valuable*: *"As a shopper, I want checkout to load in under 2 seconds so that I don't abandon my cart."*

### 4. Estimable
* **Concept**: If developers say *"We can't estimate this,"* it means the requirement is too vague, or the technical domain is unknown.
* *Solution*: If there is too much uncertainty, create a **Spike** (a timeboxed research task to write prototype code and gather information), then estimate the story in the next refinement session.

### 5. Small (Sized Appropriately)
* **Concept**: Large stories (Epics) represent high risk because they are difficult to test and coordinate.
* ❌ *Too Large*: *"Build the entire billing system."*
* 👍 *Small*: *"Allow users to add a credit card"* or *"Generate a PDF receipt."*

### 6. Testable
* **Concept**: If you cannot test a story, you will never know when it is done. Avoid subjective words like "fast," "user-friendly," or "robust."
* ❌ *Untestable*: *"Make the search page run really fast and look beautiful."*
* 👍 *Testable*: *"Search results must load in under 1 second when searching by keyword. The search page layout must match the Figma design mocks."*
