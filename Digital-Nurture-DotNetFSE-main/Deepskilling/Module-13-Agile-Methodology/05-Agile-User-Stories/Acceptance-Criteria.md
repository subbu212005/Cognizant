# Acceptance Criteria & Gherkin Syntax

Acceptance Criteria (AC) define the boundaries of a user story. They specify the exact functional requirements and business rules that must be satisfied for the Product Owner to accept the story as complete.

---

## Two Approaches to Acceptance Criteria

Agile teams generally write Acceptance Criteria in one of two formats:

### 1. Rule-Oriented Format (Checklist)
A simple list of rules or constraints that the software must satisfy. Great for simple validation rules.
* *Example*:
  * [ ] Passwords must be at least 8 characters long.
  * [ ] Passwords must contain at least one special character.
  * [ ] Users are locked out after 5 failed login attempts.

### 2. Scenario-Oriented Format (Gherkin Syntax)
A structured format that describes specific scenarios and system behaviors. This is highly recommended because it maps directly to automated testing frameworks (like Cucumber, SpecFlow, or Playwright).

The Gherkin syntax uses three main keywords:
* **Given**: The initial context or starting state of the system.
* **When**: The action performed by the user or system event.
* **Then**: The expected outcome or resulting state of the system.

---

## Writing Gherkin: A Practical Example

Let's write Scenario-Oriented Acceptance Criteria for a password reset story:

### User Story
> **As a** registered customer,  
> **I want to** reset my password,  
> **So that** I can access my account if I forget it.

### Acceptance Criteria (Scenarios)

```gherkin
Scenario: Successful Password Reset Request
  Given the user is on the password reset page
  When they enter a registered email address "user@example.com"
   And click the "Send Reset Link" button
  Then the system should display a confirmation message "Password reset email sent"
   And send an email containing a unique, secure password reset link to "user@example.com"

Scenario: Attempt to Reset Password with Unregistered Email
  Given the user is on the password reset page
  When they enter an unregistered email address "stranger@unknown.com"
   And click the "Send Reset Link" button
  Then the system should display a confirmation message "Password reset email sent"
   And no email should be sent to "stranger@unknown.com"
  # Note: Displaying the same message prevents email enumeration attacks!
```

---

## Why Acceptance Criteria Matter
1. **Removes Ambiguity**: Prevents situations where the developer builds what they think the PO wants, only to find they misunderstood.
2. **Defines Scope boundaries**: Prevents "scope creep." If a requirement is not in the AC, it is out of scope for the sprint.
3. **QA Foundation**: Quality Assurance engineers use the AC to write manual test cases and automated test scripts before coding even starts.
