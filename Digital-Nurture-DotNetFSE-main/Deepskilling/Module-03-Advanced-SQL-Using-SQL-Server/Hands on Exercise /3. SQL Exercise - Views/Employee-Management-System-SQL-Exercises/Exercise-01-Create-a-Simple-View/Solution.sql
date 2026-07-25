CREATE VIEW vw_EmployeeBasicInfo AS
SELECT E.EmployeeID,E.FirstName,E.LastName,D.DepartmentName
FROM Employees E JOIN Departments D ON E.DepartmentID=D.DepartmentID;

SELECT * FROM vw_EmployeeBasicInfo;