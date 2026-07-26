# Exercise 2 Output

`sql
EXEC sp_InsertEmployee 6, 'Alice', 'Green', 2, 6200.00;
SELECT * FROM Employees WHERE EmployeeID = 6;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          6 Alice      Green                2  6200.00 2026-07-25
`
