# Exercise 01: Create AFTER Trigger

### Objective
Create an `AFTER INSERT` trigger on the `Employees` table that automatically logs any new employee additions into a table called `EmployeeAudit`.

### Steps
1. Create the `EmployeeAudit` table to store audit logs.
2. Create the `trg_AfterInsertEmployee` trigger on the `Employees` table.
3. Verify the trigger by inserting a new employee and checking the `EmployeeAudit` table.
