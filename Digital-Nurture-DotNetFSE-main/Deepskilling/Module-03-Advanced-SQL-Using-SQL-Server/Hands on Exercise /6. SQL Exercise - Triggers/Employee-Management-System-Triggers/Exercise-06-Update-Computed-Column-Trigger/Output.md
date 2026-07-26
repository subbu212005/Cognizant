# Verification Query

```sql
-- View current Department Total Salaries
SELECT DepartmentID, DepartmentName, TotalSalary FROM Departments;

-- Insert a new employee into Department 1 (Salary = 50000.00)
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES (103, 'Bob', 'Jones', 1, 50000.00, '2023-03-01');

-- Verify Department 1 TotalSalary updated
SELECT DepartmentID, DepartmentName, TotalSalary FROM Departments WHERE DepartmentID = 1;

-- Update employee salary to 60000.00
UPDATE Employees SET Salary = 60000.00 WHERE EmployeeID = 103;

-- Verify Department 1 TotalSalary updated again
SELECT DepartmentID, DepartmentName, TotalSalary FROM Departments WHERE DepartmentID = 1;

-- Delete the employee
DELETE FROM Employees WHERE EmployeeID = 103;

-- Verify Department 1 TotalSalary returned to previous state
SELECT DepartmentID, DepartmentName, TotalSalary FROM Departments WHERE DepartmentID = 1;
```

### Expected Output
1. Initial: TotalSalary reflects the sum of existing employee salaries.
2. Insert: Department 1 TotalSalary increases by 50000.00.
3. Update: Department 1 TotalSalary increases by another 10000.00 (total increase of 60000.00).
4. Delete: Department 1 TotalSalary decreases by 60000.00 back to its original value.