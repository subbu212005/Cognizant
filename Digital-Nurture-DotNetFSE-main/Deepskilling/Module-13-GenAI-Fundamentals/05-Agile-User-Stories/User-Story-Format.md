# The User Story Format

To keep requirements customer-centric, agile teams use a standard three-part template that focuses on the **Who**, **What**, and **Why** of a feature.

---

## The Standard Template

```
As a... [User Role / Persona]
I want to... [Action / Feature]
So that... [Business Value / Benefit]
```

Let's break down each element:

### 1. "As a... [User Role / Persona]" (The WHO)
* **Purpose**: Identifies the specific target user who will benefit from the feature.
* **Why it matters**: Software has different classes of users. Admin users want different things than regular shoppers. Identifying the persona helps developers design the user interface and logic appropriately.
* *Avoid*: Using a generic word like "user" for every story.
  * 👎 *Bad*: *"As a user..."*
  * 👍 *Good*: *"As a frequent shopper..."* or *"As a database administrator..."*

### 2. "I want to... [Action / Feature]" (The WHAT)
* **Purpose**: Describes the goal the user wants to achieve. It should focus on the action or behavior, not technical components.
* **Why it matters**: It explains the required capability without locking the team into a specific database query or UI component.
* *Avoid*: Technical jargon or specifying the exact implementation details.
  * 👎 *Bad*: *"I want a backend REST endpoint that returns JSON data from the users table."*
  * 👍 *Good*: *"I want to search for products by category."*

### 3. "So that... [Business Value / Benefit]" (The WHY)
* **Purpose**: Explains the underlying benefit or value the user gets. 
* **Why it matters**: **This is the most important part of the story!** It explains why we are spending time and money to build this feature. If you cannot write a convincing "so that" clause, you should probably not build the feature.
* *Benefits of the WHY*:
  1. Prevents building useless features that don't add value.
  2. Enables Developers to propose better technical alternatives that still achieve the user's core goal.
  * 👎 *Bad*: *"...so that I can click the button."* (No real value).
  * 👍 *Good*: *"...so that I can quickly find items without browsing the entire site."*
