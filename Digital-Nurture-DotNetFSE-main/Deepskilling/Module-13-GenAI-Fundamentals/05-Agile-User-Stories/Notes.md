# Notes: The 3 C's & Requirement Hierarchy

User stories are not just a replacement for traditional software requirement specifications (PRDs). They are a tool for facilitating collaboration and shared understanding.

---

## The Three C's of User Stories (Ron Jeffries)

A user story has three essential parts, known as the **3 C's**:

```
+-------------------------------------------------------------+
| Card             | Conversation     | Confirmation          |
|                  |                  |                     |
| Short, written   | Ongoing dialogue | Acceptance criteria |
| description on a | to capture the   | to verify that the  |
| physical card.   | details/intent.  | story is complete.  |
+------------------+------------------+---------------------+
```

1. **Card**: The story description written on a physical index card or digital ticket (Jira). It serves as a reminder to talk. It is not a contract, but a placeholder for a future conversation.
2. **Conversation**: The dialogue between the Developers, Product Owner, and stakeholders. This is where details, designs, and approaches are hashed out. The conversation is continuous and happens during backlog refinement and sprint planning.
3. **Confirmation**: The acceptance criteria that represent the agreement on what the story will deliver. This is how the team confirms that the story meets the PO's expectations (Definition of Done).

---

## The Requirement Hierarchy

Requirements are grouped by size and specificity:

```
           [ Theme ]      <-- Strategic Goal (e.g., Global Expansion)
               |
           [ Epic ]       <-- Large Feature (e.g., Payment Gateway)
               |
         [ User Story ]   <-- Deliverable Value (As a user, I want...)
               |
           [ Task ]       <-- Developer Action (e.g., Create DB schema)
```

### 1. Themes
Large, strategic focus areas that span multiple departments or projects (e.g., *"Improve security and compliance across all platforms"*).

### 2. Epics
A large body of work that is too big to be completed in a single sprint. It must be broken down into multiple user stories.
* *Example*: *"User Account Management"* (Includes signup, login, password reset, profile editing, security settings).

### 3. User Stories
A small unit of value that can be comfortably built, tested, and delivered within a single sprint (typically 1 to 5 days of effort).
* *Example*: *"As a registered user, I want to reset my password via email so that I can access my account if I forget it."*

### 4. Tasks (Sub-Tasks)
Technical steps required to implement the user story. Tasks are written by developers, for developers, and do not carry direct business value on their own.
* *Example*: *"Write backend database query to update password token"* or *"Design reset password UI layout."*
