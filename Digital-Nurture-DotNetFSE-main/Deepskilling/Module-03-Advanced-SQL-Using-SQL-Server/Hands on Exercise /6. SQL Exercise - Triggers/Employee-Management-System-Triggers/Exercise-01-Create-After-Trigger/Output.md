# Verification Query

```sql
-- Insert a test employee
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES (101, 'John', 'Doe', 1, 60000.00, '2023-01-15');

-- Verify trigger worked
SELECT * FROM EmployeeAudit;
```

### Expected Output
An audit row showing `EmployeeID = 101`, `Action = 'INSERT'`, and `NewSalary = 60000.00`.