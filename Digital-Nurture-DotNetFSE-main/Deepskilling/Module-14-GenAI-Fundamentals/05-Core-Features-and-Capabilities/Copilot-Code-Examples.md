# Copilot Code Examples and Exercises

This file contains practical examples of code structures and exercises to practice utilizing GitHub Copilot's features.

---

## 1. Comment-Driven Development (Python)

### Scenario
You need to generate a utility function that validates an email address using regex and returns details about the domain.

### Exercise
Create a new Python file and type the following comments. Let Copilot generate the code line by line.

```python
import re

# Function to validate email and extract domain info
# Parameters:
#   email (str): The email address to check
# Returns:
#   dict: Contains 'is_valid' (bool), 'username' (str), 'domain' (str)
def analyze_email(email: str) -> dict:
    # 1. Define regular expression pattern for standard email validation
    
    # 2. Check if email matches the pattern
    
    # 3. If valid, split the email to extract username and domain
    
    # 4. If invalid, return username and domain as None, with is_valid as False
```

---

## 2. Code Refactoring Exercise

### Scenario
The function below parses a CSV line manually, but it is fragile, prone to issues with escaped characters, and does not handle whitespace.

### Input Code (Before)
```python
def parse_csv_line(line):
    # Split by comma
    parts = line.split(',')
    # Remove whitespace
    result = []
    for part in parts:
        result.append(part.strip())
    return result
```

### Refactoring Prompt
Highlight the code block above, open inline chat (`Ctrl + I` or `Cmd + I`), and type:
```text
/refactor Rewrite this function using the python standard `csv` module to handle escaped commas, quoted strings, and whitespace trimming safely.
```

### Expected Output (After)
```python
import csv
import io

def parse_csv_line(line: str) -> list[str]:
    """Parses a single CSV line securely handling quotes and whitespace.
    
    Args:
        line: A single comma-separated string line.
        
    Returns:
        A list of cleaned string tokens.
    """
    f = io.StringIO(line)
    reader = csv.reader(f, skipinitialspace=True)
    try:
        return next(reader)
    except StopIteration:
        return []
```

---

## 3. Unit Test Generation (Python pytest)

### Scenario
Generate unit tests for the email validator function.

### Code to Test
```python
import re

def is_valid_ip_address(ip: str) -> bool:
    ipv4_pattern = r"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"
    return bool(re.match(ipv4_pattern, ip))
```

### Steps to Generate Tests
1. Highlight the `is_valid_ip_address` function.
2. Open Copilot Chat.
3. Submit the following query:
   ```text
   /tests Generate unit tests for this function using the pytest framework. Include test cases for:
   - A valid IPv4 address (e.g., "192.168.1.1")
   - Boundary inputs (e.g., "255.255.255.255")
   - Out of bounds numbers (e.g., "256.100.0.1")
   - Incorrect segment count (e.g., "192.168.1")
   - Empty input or alphabetic characters
   ```
