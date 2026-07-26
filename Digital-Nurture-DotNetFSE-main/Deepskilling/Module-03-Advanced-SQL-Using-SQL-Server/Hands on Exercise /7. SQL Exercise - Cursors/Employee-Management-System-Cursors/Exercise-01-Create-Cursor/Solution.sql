-- SQL solution for Exercise-01-Create-Cursor
DECLARE @FirstName VARCHAR(50);
DECLARE @LastName VARCHAR(50);
DECLARE @DeptName VARCHAR(100);
DECLARE @Salary DECIMAL(10,2);

DECLARE emp_cursor CURSOR FOR
SELECT e.FirstName, e.LastName, d.DepartmentName, e.Salary
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

OPEN emp_cursor;

FETCH NEXT FROM emp_cursor INTO @FirstName, @LastName, @DeptName, @Salary;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Employee: ' + @FirstName + ' ' + @LastName + ' | Department: ' + @DeptName + ' | Salary: $' + CAST(@Salary AS VARCHAR(10));
    FETCH NEXT FROM emp_cursor INTO @FirstName, @LastName, @DeptName, @Salary;
END;

CLOSE emp_cursor;
DEALLOCATE emp_cursor;
