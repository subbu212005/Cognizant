# Exercise 1 Output

`sql
EXEC sp_InsertEmployee 5, 'Bob', 'Miller', 1, 4800.00, '2023-05-10';
SELECT * FROM Employees WHERE EmployeeID = 5;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          5 Bob        Miller               1  4800.00 2023-05-10
`
