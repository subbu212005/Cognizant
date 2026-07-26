-- 1. Add TotalSalary column to Departments if it doesn't exist
IF NOT EXISTS (
    SELECT 1 
    FROM sys.columns 
    WHERE object_id = OBJECT_ID('Departments') AND name = 'TotalSalary'
)
BEGIN
    ALTER TABLE Departments ADD TotalSalary DECIMAL(12,2) DEFAULT 0.00;
END;
GO

-- 2. Initialize existing total salaries
UPDATE d
SET d.TotalSalary = ISNULL((SELECT SUM(e.Salary) FROM Employees e WHERE e.DepartmentID = d.DepartmentID), 0.00)
FROM Departments d;
GO

-- 3. Create the AFTER trigger to automatically maintain TotalSalary
CREATE OR ALTER TRIGGER trg_UpdateDepartmentTotalSalary
ON Employees
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Update Departments that had employees added or details modified
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE d
        SET d.TotalSalary = ISNULL((SELECT SUM(e.Salary) FROM Employees e WHERE e.DepartmentID = d.DepartmentID), 0.00)
        FROM Departments d
        WHERE d.DepartmentID IN (SELECT DISTINCT DepartmentID FROM inserted);
    END;

    -- Update Departments that had employees removed or changed departments
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE d
        SET d.TotalSalary = ISNULL((SELECT SUM(e.Salary) FROM Employees e WHERE e.DepartmentID = d.DepartmentID), 0.00)
        FROM Departments d
        WHERE d.DepartmentID IN (SELECT DISTINCT DepartmentID FROM deleted);
    END;
END;
GO
