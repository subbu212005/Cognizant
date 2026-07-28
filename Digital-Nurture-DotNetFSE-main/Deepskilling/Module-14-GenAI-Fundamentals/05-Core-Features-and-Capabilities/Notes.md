# Notes: Core Features and Capabilities

This document explores how to use GitHub Copilot's features to accelerate your software engineering workflows.

---

## 1. Comment-Driven Development (CDD)

Comment-Driven Development is the technique of writing structured comments *before* writing code, using the comments to guide Copilot to generate the desired implementation.

### Best Practices for CDD
- **Be Specific**: Specify input types, output types, library names, and constraints.
- **Break Down Complex Logic**: Write sequential, step-by-step comments for multi-stage processes instead of asking for the whole solution at once.
- **Maintain Context**: Keep relevant files open in other editor tabs so Copilot can infer database schemas, class definitions, or utility functions.

---

## 2. Copilot Chat Slash Commands

Slash commands are shortcuts in Copilot Chat that specify standard software development tasks. They optimize the model's system prompt behind the scenes to yield high-quality outputs.

| Command | Action | Use Case |
|---|---|---|
| `/explain` | Analyzes selected code and describes how it works in plain language. | Understanding legacy code, code reviews, onboarding. |
| `/tests` | Generates unit tests for the selected code block. | Building test suites, improving coverage. |
| `/fix` | Identifies bugs, compilation errors, or runtime issues in the code and proposes a fix. | Quick bug resolution. |
| `/doc` | Generates documentation comments, README files, or API guides. | Standardizing docstrings. |
| `/help` | Explains how to use Copilot Chat or troubleshooting commands. | Tool support. |
| `/clear` | Clears the current chat session history to start a fresh thread. | Resetting session memory. |

---

## 3. Chat Variables and Domain Agents

To pass files and broad context to Copilot Chat, you can use specialized variables and agents:

- **`#file`**: References a specific file from your workspace.
  - *Example*: "Explain the authentication flow in `#file:auth_service.py`"
- **`#selection`**: References the highlighted code in the active editor.
  - *Example*: "Rewrite `#selection` to use async/await"
- **`#workspace`**: Directs Copilot to scan the entire workspace index.
  - *Example*: "Where in `#workspace` are API routing endpoints defined?"
- **`@workspace`**: An agent that has a deep understanding of your codebase structure.
  - *Example*: "`@workspace` How do I add a new database migration?"
- **`@terminal`**: An agent that helps explain command-line tool failures and debug execution errors.

---

## 4. Writing Unit Tests

When using `/tests` or prompting Copilot to write tests, you can guide it to adhere to your project's styling:
1. Highlight the function or class to test.
2. In Copilot Chat, specify the framework (e.g., `pytest`, `unittest`, `Jest`, `JUnit`).
3. Instruct Copilot on boundary conditions, mock objects, and edge cases to test.
4. *Tip*: If you have an existing test file, keep it open in a neighboring tab. Copilot will automatically read its structure and write the new tests in the same style (e.g., using the same assertion style or mock fixtures).

---

## 5. Refactoring and Code Translation

- **Modernization**: Translate old syntax to modern standards (e.g., converting ES5 JavaScript to ES6+, or updating Python 2 code to Python 3).
- **Optimization**: Ask Copilot to optimize time complexity (e.g., reducing nested loops to a single dictionary lookup) or space complexity.
- **Language Translation**: Translate logic from one programming language to another. (e.g., converting a Java class to a TypeScript interface). Keep in mind that system libraries and frameworks will change, so verification is critical.
