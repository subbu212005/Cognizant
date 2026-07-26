-- Modify the existing trigger to support both INSERT and UPDATE audits
ALTER TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Handle INSERT (records present in inserted but not deleted)
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO EmployeeAudit (EmployeeID, Action, ActionDate, NewSalary)
        SELECT EmployeeID, 'INSERT', GETDATE(), Salary
        FROM inserted;
    END

    -- Handle UPDATE (records present in both inserted and deleted)
    ELSE IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO EmployeeAudit (EmployeeID, Action, ActionDate, OldSalary, NewSalary)
        SELECT i.EmployeeID, 'UPDATE', GETDATE(), d.Salary, i.Salary
        FROM inserted i
        JOIN deleted d ON i.EmployeeID = d.EmployeeID;
    END
END;
GO
