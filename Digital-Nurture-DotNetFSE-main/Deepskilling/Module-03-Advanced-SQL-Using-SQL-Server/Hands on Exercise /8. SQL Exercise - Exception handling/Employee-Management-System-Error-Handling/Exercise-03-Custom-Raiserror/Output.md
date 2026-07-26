### Expected Output for Exercise-03-Custom-Raiserror

When executing `sp_UpdateEmployeeSalary` for a non-existent employee ID (e.g., `999`), it returns:

| Status | ErrorDetails |
| :--- | :--- |
| Salary Update Failed | Employee with ID 999 does not exist. Cannot update salary. |

#### **Logged Entry in AuditLog Table:**

| LogID | Action | ErrorMessage | ActionDate |
| :--- | :--- | :--- | :--- |
| 1 | UPDATE SALARY FAILED | Employee with ID 999 does not exist. Cannot update salary. | *Timestamp* |
