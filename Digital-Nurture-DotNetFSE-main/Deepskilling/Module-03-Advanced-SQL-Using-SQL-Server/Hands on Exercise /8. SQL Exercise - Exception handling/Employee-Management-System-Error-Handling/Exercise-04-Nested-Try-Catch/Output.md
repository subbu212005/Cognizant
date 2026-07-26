### Expected Output for Exercise-04-Nested-Try-Catch

When executing the nested Try-Catch block:

1. **Console Prints:**
   ```text
   Outer TRY block started.
   Inner CATCH block caught the error. Logging...
   Outer CATCH block caught the error. Rolling back...
   Transaction rolled back.
   ```

2. **Result Set returned:**

   | OuterErrorMessage | TransactionStatus |
   | :--- | :--- |
   | Violation of UNIQUE KEY constraint 'UQ__Employee__A9D10534B0984BDE'. Cannot insert duplicate key in object 'dbo.Employees'. The duplicate key value is (john.doe@example.com). | Transaction Rolled Back |

3. **Logged Entry in AuditLog Table:**

   | Action | ErrorMessage |
   | :--- | :--- |
   | INSERT EMPLOYEE (INNER) | Violation of UNIQUE KEY constraint... |
