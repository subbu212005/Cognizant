# Verification Query

```sql
-- Insert a record into the view with a new Department (ID 5: Sales)
INSERT INTO vw_EmployeeDetails (EmployeeID, FirstName, LastName, Salary, JoinDate, DepartmentID, DepartmentName)
VALUES (102, 'Jane', 'Smith', 75000.00, '2023-02-20', 5, 'Sales');

-- Check if department was created
SELECT * FROM Departments WHERE DepartmentID = 5;

-- Check if employee was inserted
SELECT * FROM Employees WHERE EmployeeID = 102;
```

### Expected Output
1. One row in `Departments` for DepartmentID 5 ('Sales').
2. One row in `Employees` for EmployeeID 102 ('Jane Smith').