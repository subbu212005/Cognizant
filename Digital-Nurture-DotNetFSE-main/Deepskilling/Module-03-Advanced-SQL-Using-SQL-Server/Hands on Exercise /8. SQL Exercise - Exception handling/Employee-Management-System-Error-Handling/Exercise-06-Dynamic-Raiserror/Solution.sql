-- Solution for Exercise-06-Dynamic-Raiserror
USE EmployeeManagementErrorHandlingDb;
GO

CREATE OR ALTER PROCEDURE sp_TransferEmployee
    @EmployeeID INT,
    @NewDepartmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Check if employee exists
        IF NOT EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID)
        BEGIN
            -- RAISERROR with dynamic parameter %d (EmployeeID)
            RAISERROR('Employee ID %d was not found in the database. Transfer aborted.', 16, 1, @EmployeeID);
        END

        -- Check if department exists
        IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @NewDepartmentID)
        BEGIN
            -- RAISERROR with multiple dynamic parameters
            RAISERROR('Department ID %d does not exist. Cannot transfer Employee ID %d.', 16, 1, @NewDepartmentID, @EmployeeID);
        END

        -- Update department if validations pass
        UPDATE Employees
        SET DepartmentID = @NewDepartmentID
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Employee transferred successfully.';
    END TRY
    BEGIN CATCH
        -- Log failure to AuditLog
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('TRANSFER FAILED', ERROR_MESSAGE());

        SELECT 
            'Transfer Failed' AS Status,
            ERROR_MESSAGE() AS ErrorDetails;
    END CATCH
END;
GO

-- Testing the procedure with a non-existent employee ID
EXEC sp_TransferEmployee 999, 1;

-- Testing the procedure with a non-existent department ID
EXEC sp_TransferEmployee 101, 888;

-- Verify that the errors were logged in AuditLog
SELECT * FROM AuditLog;
GO
