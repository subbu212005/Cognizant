USE EmployeeManagementSystemTriggersDb;
GO

-- 1. Create audit table
IF OBJECT_ID('EmployeeAudit', 'U') IS NULL
BEGIN
    CREATE TABLE EmployeeAudit (
        AuditID INT IDENTITY(1,1) PRIMARY KEY,
        EmployeeID INT,
        Action VARCHAR(50),
        ActionDate DATETIME DEFAULT GETDATE(),
        OldSalary DECIMAL(10,2),
        NewSalary DECIMAL(10,2)
    );
END;
GO

-- 2. Create the AFTER Trigger
CREATE OR ALTER TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, Action, ActionDate, NewSalary)
    SELECT EmployeeID, 'INSERT', GETDATE(), Salary
    FROM inserted;
END;
GO

-- 3. TEST & GET OUTPUT (Cleans up old ID 101 first)
DELETE FROM Employees WHERE EmployeeID = 101;
TRUNCATE TABLE EmployeeAudit;

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES (101, 'John', 'Doe', 1, 60000.00, '2023-01-15');

SELECT * FROM EmployeeAudit;