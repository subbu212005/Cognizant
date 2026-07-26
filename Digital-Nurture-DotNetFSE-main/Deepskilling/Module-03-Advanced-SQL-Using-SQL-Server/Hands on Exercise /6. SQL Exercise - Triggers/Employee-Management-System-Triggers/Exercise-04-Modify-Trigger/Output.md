# Verification Query

```sql
-- Update salary of Employee 101 from 60000.00 to 65000.00
UPDATE Employees
SET Salary = 65000.00
WHERE EmployeeID = 101;

-- Verify both insert and update records exist in EmployeeAudit
SELECT * FROM EmployeeAudit;
```

### Expected Output
The `EmployeeAudit` table should show two records:
1. The original INSERT event.
2. The new UPDATE event with `OldSalary = 60000.00` and `NewSalary = 65000.00`.