# Exercise 8 Output

`sql
EXEC sp_GiveBonus 500.00;
SELECT * FROM Employees WHERE EmployeeID = 3;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          3 Michael    Johnson              3  7500.00 2018-07-30
`
