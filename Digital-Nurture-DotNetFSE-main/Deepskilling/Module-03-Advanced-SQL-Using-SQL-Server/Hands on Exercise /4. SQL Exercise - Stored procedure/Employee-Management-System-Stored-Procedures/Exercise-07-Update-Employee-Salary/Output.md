# Exercise 7 Output

`sql
EXEC sp_UpdateEmployeeSalary 2, 9500.00;
SELECT * FROM Employees WHERE EmployeeID = 2;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          2 Jane       Smith                2  9500.00 2019-03-22
`
