# Exercise 04: Modify Trigger

### Objective
Modify the existing `trg_AfterInsertEmployee` trigger using `ALTER TRIGGER` to audit both inserts and updates, logging salary changes when updates occur.

### Steps
1. Execute `ALTER TRIGGER trg_AfterInsertEmployee` on the `Employees` table.
2. In the body, detect if the action is an `INSERT` or an `UPDATE` by checking the presence of rows in the `inserted` and `deleted` tables.
3. Verify by executing an update statement on an employee's salary and inspecting the `EmployeeAudit` table.
