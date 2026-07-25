# Exercise 10 Output

`sql
EXEC sp_DynamicEmployeeSearch @FirstName='Jane';
EXEC sp_DynamicEmployeeSearch @DepartmentID=2;
`

Output:
`
EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          2 Jane       Smith                2 10000.00 2019-03-22

EmployeeID  FirstName  LastName  DepartmentID Salary   JoinDate
----------- ---------- --------- ------------ -------- ----------
          2 Jane       Smith                2 10000.00 2019-03-22
          6 Alice      Green                2  6700.00 2026-07-25
`
