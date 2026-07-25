CREATE VIEW vw_EmployeeFullName AS
SELECT EmployeeID, FirstName+' '+LastName AS FullName, Salary, JoinDate FROM Employees;

SELECT * FROM vw_EmployeeFullName;