### Expected Output for Exercise-05-Transaction-Error-Logging

When calling `sp_SafeDeleteDepartment` to delete Department ID `2` (which contains active employees):

1. **Console Prints:**
   ```text
   Transaction rolled back due to error.
   ```

2. **Result Set returned:**

   | Status | ErrorDetails |
   | :--- | :--- |
   | Delete Failed | The DELETE statement conflicted with the REFERENCE constraint "FK__Employees__Depar__4D94879B". The conflict occurred in database "EmployeeManagementErrorHandlingDb", table "dbo.Employees", column 'DepartmentID'. |

3. **Logged Entry in AuditLog Table:**

   | Action | ErrorMessage |
   | :--- | :--- |
   | DELETE DEPARTMENT FAILED | The DELETE statement conflicted with the REFERENCE constraint... |
