# Prompt Engineering Cheat Sheet

This cheat sheet provides a quick reference for techniques and structures when writing prompts for Large Language Models.

---

## 1. Core Prompting Techniques

| Technique | Description | Quick Example |
|---|---|---|
| **Zero-Shot** | Direct task request without any input-output examples. | "Translate 'hello' to Spanish." |
| **Few-Shot** | Providing 1 or more input-output examples to teach style or schema. | "Bad -> 1 star\nGood -> 5 stars\nOkay ->" |
| **Chain-of-Thought (CoT)** | Adding a request for step-by-step reasoning before the answer. | "...Explain your steps before calculating the sum." |
| **Role Prompting** | Instructing the model to adopt a persona with specialized knowledge. | "Act as a senior database administrator..." |
| **Grounding Context** | Providing source material and restricting responses to that material. | "Based on the text below, answer..." |
| **Output Constraints** | Defining target format, character limits, or language rules. | "Format as valid JSON using key 'result'." |

---

## 2. Standard Prompt Framework (The CREATE Formula)

When building complex prompts, incorporate these six elements:

1. **C**haracter (Persona): "Act as a technical writer."
2. **R**equest (Task): "Create an API tutorial."
3. **E**xamples (Demonstrations): Provide one or two expected output blocks.
4. **A**djustments (Constraints): "Do not use external libraries. Limit to 300 words."
5. **T**ype (Format): "Output in Markdown format."
6. **E**xplanation (Reasoning): "Explain why this solution is selected."

---

## 3. Quick Refinement Rules

- **Prefer Positive Instructions**: Tell the model *what to do* instead of *what not to do*. (e.g., Use "Keep responses short" instead of "Do not write a long response").
- **Delimiters**: Use triple quotes (`"""`), backticks (```` ``` ````), XML tags (`<data></data>`), or brackets to separate instructions from input text.
- **Order Matters**: Put your main instruction at the very beginning or the very end of the prompt. Large inputs in the middle can cause the model to lose focus on the instruction.
- **Manage Temperature**:
  - Set to `0.0` or `0.2` for logical, mathematical, or coding tasks.
  - Set to `0.7` or higher for brainstorming, copy editing, or creative writing.
