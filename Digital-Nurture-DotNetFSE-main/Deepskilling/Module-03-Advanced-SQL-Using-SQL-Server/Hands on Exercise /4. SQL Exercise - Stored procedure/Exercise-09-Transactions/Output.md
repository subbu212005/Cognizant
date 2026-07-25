# Exercise 9 Output

`sql
EXEC sp_UpdateSalaryTransaction 3, 8500.00;
SELECT * FROM Employees WHERE EmployeeID = 3;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          3 Michael    Johnson              3  8500.00 2018-07-30
`
