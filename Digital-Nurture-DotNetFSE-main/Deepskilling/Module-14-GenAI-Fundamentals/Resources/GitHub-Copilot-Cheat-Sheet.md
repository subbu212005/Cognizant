# GitHub Copilot Cheat Sheet

This cheat sheet provides a quick reference for keyboard shortcuts and commands to interact with GitHub Copilot inside your IDE.

---

## 1. Keyboard Shortcuts: VS Code (Visual Studio Code)

| Action | Windows / Linux | macOS |
|---|---|---|
| **Accept Completion** | `Tab` | `Tab` |
| **Reject Completion** | `Escape` | `Escape` |
| **Accept Next Word** | `Ctrl + Right Arrow` | `Cmd + Right Arrow` |
| **Accept Next Line** | `Ctrl + Alt + Right Arrow` | `Cmd + Alt + Right Arrow` |
| **Next Suggestion** | `Alt + ]` | `Option + ]` |
| **Previous Suggestion** | `Alt + [` | `Option + [` |
| **Trigger Suggestion Manually** | `Alt + \` | `Option + \` |
| **Open Panel (10 Solutions)** | `Ctrl + Enter` | `Ctrl + Enter` |
| **Open Inline Chat** | `Ctrl + I` | `Cmd + I` |
| **Focus Chat Panel** | `Ctrl + Alt + I` | `Cmd + Alt + I` |

---

## 2. Keyboard Shortcuts: JetBrains (PyCharm, IntelliJ, Rider)

| Action | Windows / Linux | macOS |
|---|---|---|
| **Accept Completion** | `Tab` | `Tab` |
| **Reject Completion** | `Escape` | `Escape` |
| **Accept Next Word** | `Ctrl + Right Arrow` | `Cmd + Right Arrow` |
| **Next Suggestion** | `Alt + ]` | `Option + ]` |
| **Previous Suggestion** | `Alt + [` | `Option + [` |
| **Trigger Suggestion Manually** | `Alt + \` | `Option + \` |

---

## 3. Keyboard Shortcuts: Visual Studio (2022)

| Action | Windows |
|---|---|
| **Accept Completion** | `Tab` or `Right Arrow` |
| **Reject Completion** | `Escape` |
| **Next Suggestion** | `Alt + ]` |
| **Previous Suggestion** | `Alt + [` |
| **Trigger Suggestion Manually** | `Alt + \` |

---

## 4. Copilot Chat Command Reference

### Slash Commands
- `/explain`: Analyzes and explains selected code.
- `/tests`: Generates unit tests for selected code.
- `/fix`: Proposes a fix for compilation or runtime errors.
- `/doc`: Generates documentation comments/docstrings.
- `/clear`: Resets active chat conversation history.

### Context Variables
- `#file`: Refers to a specific file (e.g., `#file:app.py`).
- `#selection`: Refers to highlighted code in the active editor.
- `#editor`: Refers to the visible contents of the active editor.
- `#workspace`: Refers to the full project structure indexing.
