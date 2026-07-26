# Exercise 6 Output

`sql
DECLARE @Total DECIMAL(10,2);
EXEC sp_TotalSalaryByDepartment 1, @Total OUTPUT;
SELECT @Total AS 'TotalSalary';
`

Output:
`
TotalSalary
------------
     9800.00
`
