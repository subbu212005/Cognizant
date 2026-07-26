-- Create the View if it doesn't exist
IF OBJECT_ID('vw_EmployeeDetails', 'V') IS NOT NULL
    DROP VIEW vw_EmployeeDetails;
GO

CREATE VIEW vw_EmployeeDetails AS
SELECT 
    e.EmployeeID, 
    e.FirstName, 
    e.LastName, 
    e.Salary, 
    e.JoinDate, 
    d.DepartmentID, 
    d.DepartmentName
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID;
GO

-- Create the INSTEAD OF INSERT trigger on the view
CREATE OR ALTER TRIGGER trg_InsteadOfInsertEmployee
ON vw_EmployeeDetails
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert Department if it doesn't already exist
    INSERT INTO Departments (DepartmentID, DepartmentName)
    SELECT DISTINCT i.DepartmentID, i.DepartmentName
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1 FROM Departments d WHERE d.DepartmentID = i.DepartmentID
    );

    -- Insert Employee
    INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
    SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
    FROM inserted;
END;
GO
