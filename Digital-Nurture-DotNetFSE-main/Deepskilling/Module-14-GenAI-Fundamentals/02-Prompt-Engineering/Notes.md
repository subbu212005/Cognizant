# Notes: Prompt Engineering

Prompt Engineering is the practice of structuring, refining, and optimizing text inputs (prompts) to guide Generative AI models to produce the most accurate, relevant, and useful outputs. Since LLMs operate based on probabilistic associations, the way you frame a request directly impacts the quality of the response.

---

## 1. Anatomy of a Well-Structured Prompt

A highly effective prompt typically consists of four main components. While not every prompt requires all four, combining them yields the most deterministic results:

1. **Instruction**: The specific task or action you want the model to perform (e.g., "Summarize", "Translate", "Refactor", "Analyze").
2. **Context**: Background information or constraints that scope the model's domain (e.g., "Assume the target reader is a junior developer," "Use Python 3.10 guidelines," "Limit the response to historical data before 1990").
3. **Input Data**: The actual text, code, or payload that needs to be processed (e.g., the article to summarize, the code to refactor, or the JSON log to parse).
4. **Output Indicator/Formatting**: The desired structure, style, or format of the output (e.g., "Output as a bulleted list," "Provide the final answer in valid JSON," "Format as a Markdown table").

---

## 2. Core Prompting Techniques

### Zero-Shot Prompting
Providing a task instruction directly to the model without any examples of the expected input-output behavior.
- *Use Case*: Simple, standard tasks like language translation, basic summarization, or answering common questions.
- *Example*:
  ```text
  Classify the sentiment of the following product review as Positive, Neutral, or Negative.
  Review: "The screen is bright, but the battery runs out in under two hours."
  Sentiment:
  ```

### Few-Shot Prompting
Providing the model with one or more examples (demonstrations) of the task being performed correctly before asking the model to perform the task on new input.
- *Use Case*: Custom classification, strict output syntax, complex data formatting, or tone matching.
- *Example*:
  ```text
  Translate the customer complaint into a standard JSON ticket.

  Input: "My package hasn't arrived. It was supposed to be here last Tuesday!"
  Output: {"category": "shipping", "severity": "high", "requires_refund": false}

  Input: "I ordered a blue shirt but received a red one."
  Output: {"category": "wrong_item", "severity": "medium", "requires_refund": true}

  Input: "The app crashes every time I try to click the save button."
  Output:
  ```

### Chain-of-Thought (CoT) Prompting
Encouraging the model to generate its intermediate reasoning steps before providing the final answer. This significantly improves accuracy on reasoning, logical, mathematical, and coding tasks.
- *Use Case*: Math word problems, logical reasoning, multi-step code debugging.
- *Implementation*: This can be triggered by adding phrases like "Let's think step by step" or by providing few-shot examples that demonstrate reasoning steps.
- *Example*:
  ```text
  A cafeteria has 23 apples. If they use 20 to make lunch and buy 6 more, how many apples do they have?
  Let's think step by step:
  1. The cafeteria starts with 23 apples.
  2. They use 20 for lunch, which leaves 23 - 20 = 3 apples.
  3. They buy 6 more, which means they now have 3 + 6 = 9 apples.
  The answer is 9.

  A clothing store has 15 red shirts, 22 blue shirts, and 12 green shirts. They sell 10 blue shirts and buy 5 more green shirts. How many total shirts do they have left?
  Let's think step by step:
  ```

---

## 3. Advanced Prompt Engineering Concepts

### System Instructions vs. User Prompts
Modern model architectures (such as OpenAI's and Google's APIs) allow prompts to be split into distinct roles:
- **System Prompt**: Sets the permanent behavior, rules, boundaries, and persona of the assistant. It acts as the "operating system" for the chat session and cannot be easily overridden by the user.
- **User Prompt**: Represents the specific, dynamic query or message sent by the user during the chat session.

### Role Prompting (Persona Adoption)
Instructing the model to adopt a specific persona to align its vocabulary, depth of explanation, and technical style.
- *Example*: "Act as a Senior Cyber Security Auditor. Review the following code snippet for potential OWASP Top 10 vulnerabilities..."

### Grounding and Context Injection
To prevent hallucinations, you ground the model by explicitly providing the factual text (e.g., standard documentation, database search results, or manual pages) and telling the model to *only* answer using the provided information.
- *Example*: "Using only the documentation provided below, answer the user's question. If the answer cannot be found in the documentation, say 'I do not know.' Do not make up information."
