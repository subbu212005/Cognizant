# Exercise 5 Output

`sql
DECLARE @Count INT;
EXEC @Count = sp_CountEmployeesByDepartment 1;
SELECT @Count AS 'CountResult';
`

Output:
`
CountResult
-----------
          2
`
