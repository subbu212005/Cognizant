CREATE VIEW vw_EmployeeReport AS
SELECT E.EmployeeID,E.FirstName+' '+E.LastName AS FullName,D.DepartmentName,E.Salary*12 AS AnnualSalary,(E.Salary*12)*0.10 AS Bonus FROM Employees E JOIN Departments D ON E.DepartmentID=D.DepartmentID;

SELECT * FROM vw_EmployeeReport;