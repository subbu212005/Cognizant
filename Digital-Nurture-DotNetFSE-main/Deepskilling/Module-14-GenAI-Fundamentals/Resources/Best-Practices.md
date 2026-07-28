# Best Practices for AI-Assisted Development

This document outlines standard guidelines and workflows to maximize productivity while maintaining code quality and security when working with AI tools.

---

## 1. Context Management

GitHub Copilot relies on surrounding editor context to generate accurate suggestions. Manage this context actively:

- **Keep Relevant Files Open**: Copilot reads open editor tabs. If your task involves writing code that integrates with a database helper, keep the database helper file open in a neighboring tab.
- **Set Up Clear File Names**: Good file names and directory structures help Copilot infer the architecture and framework choices.
- **Define Imports First**: Start your files by writing the import statements. This tells Copilot which libraries you intend to use.

---

## 2. Interactive Development Workflow

Avoid accepting large blocks of code without verifying the logic:

- **Incremental Tab-Accept**: Do not accept massive 50-line blocks in one go if you are unsure of the logic. Accept a few lines, let Copilot adjust its next suggestion based on what you accepted, and proceed.
- **Write Tests First (or Simultaneously)**: Have a test suite ready. When Copilot generates a function, run it against tests immediately to verify boundary behaviors.
- **Verify Edge Cases**: Copilot is excellent at standard paths, but it can miss complex error states or null pointer checks. Add comments to force Copilot to handle edge cases.

---

## 3. Human-in-the-Loop Review

The developer is ultimately responsible for the safety, correctness, and efficiency of the code:

- **Code Audits**: Treat AI suggestions as if they were written by a contractor or junior developer. Review variables, logic flows, and error handling.
- **Security Checklists**: Scan generated code for SQL injection, unsanitized HTML output, hardcoded secrets, and outdated cryptographic functions.
- **License Compliance**: If your project is closed-source, ensure public code suggestions are filtered or reviewed to avoid copyleft violations.

---

## 4. Prompt Engineering for Developers

When communicating with Copilot Chat or LLMs:

- **Adopt Roles**: Tell the AI who it is (e.g., "Act as a security auditor," "Act as a performance optimization expert").
- **Provide Input Formats**: If you want a specific style of output, demonstrate it using a few-shot structure.
- **Define Constraints Upfront**: Specify language versions, prohibited libraries, formatting styles, and length restrictions.
