# Prompt Examples and Exercises

This file contains real-world prompt examples for software engineering tasks, illustrating the application of the prompt engineering principles covered in the notes.

---

## 1. Code Generation with Role and Constraints

### Objective
Generate a robust Python utility function while specifying code style, error handling, and type safety constraints.

### Prompt
```text
System: You are an expert Python backend engineer specializing in secure coding practices and API integrations.

User:
Write a Python function named `fetch_weather_data` that retrieves weather details from a public API.

Constraints:
1. Use the `requests` library.
2. Accept a string parameter `city_name` and an optional `api_key` string.
3. If no `api_key` is provided, default to looking it up from the environment variable `WEATHER_API_KEY`.
4. Include explicit error handling for connection timeouts, HTTP errors (like 404 or 401), and general exceptions. Return a tuple of (data, error_message).
5. Implement Python type hints for parameters and the return value.
6. Provide a docstring in Google style explaining the parameters, return values, and exceptions raised.

Do not include any introductory or concluding conversational text. Return only the Python code and standard docstring.
```

---

## 2. Few-Shot Data Transformation (Text to JSON Schema)

### Objective
Train the model to convert arbitrary unstructured bug report messages into a structured, validated JSON format.

### Prompt
```text
System: You are a data extraction assistant. Your job is to extract technical details from bug reports and output them in a structured JSON schema.

User:
Convert the following bug reports into the JSON structure shown in the examples.

Example 1:
Report: "We received a reports of the checkout page crashing when users select Apple Pay. It affects Chrome on iOS. Happened around 3 PM today."
Output:
{
  "component": "checkout",
  "issue_type": "crash",
  "affected_platforms": ["Chrome", "iOS"],
  "impact_level": "critical"
}

Example 2:
Report: "The font on the footer is slightly misaligned on mobile screens (Safari). It looks unprofessional."
Output:
{
  "component": "footer",
  "issue_type": "UI alignment",
  "affected_platforms": ["Safari", "mobile"],
  "impact_level": "low"
}

Example 3:
Report: "Users are reporting that registration emails are taking up to 2 hours to arrive. This is happening for all email providers, especially Gmail."
Output:
```

---

## 3. Grounding and QA from Documentation (Contextual Constraints)

### Objective
Ensure the model answers technical questions using *only* the provided documentation to avoid hallucination.

### Prompt
```text
System: You are a technical support agent. Use ONLY the provided document below to answer user queries. If the answer cannot be verified by the text, reply: "I cannot answer this question based on the provided documentation." Do not use external knowledge.

Context Document:
---
Antigravity CLI (agy) Version 2.4.0 Release Notes:
- Added `agy deploy` command to push projects directly to the cloud.
- The `agy login` command now supports single-sign-on (SSO) using the `--sso` flag.
- Dropped support for node versions below v18.0.0.
- Resolved memory leaks associated with standard watcher processes.
---

User: How do I configure single sign-on when logging into the Antigravity CLI?
```

---

## 4. Chain-of-Thought Code Debugging

### Objective
Force the model to analyze a buggy algorithm step-by-step to identify logic flaws before proposing a fix.

### Prompt
```text
User:
I have a Python function that is supposed to find the first non-repeating character in a string. It is returning the wrong index.

Here is the code:
```python
def first_unique_char(s: str) -> int:
    char_counts = {}
    for char in s:
        char_counts[char] = char_counts.get(char, 0) + 1
    
    for i in range(len(s)):
        if char_counts[s[i]] == 0:
            return i
    return -1
```

Analyze this step-by-step:
1. Explain how the character counts dictionary is populated for the input string "swiss". Show the final state of the dictionary.
2. Step through the second loop for "swiss" and explain what value `char_counts[s[i]]` evaluates to for each index `i`.
3. Identify the logical bug in the second loop's conditional statement.
4. Provide the corrected code.
```
