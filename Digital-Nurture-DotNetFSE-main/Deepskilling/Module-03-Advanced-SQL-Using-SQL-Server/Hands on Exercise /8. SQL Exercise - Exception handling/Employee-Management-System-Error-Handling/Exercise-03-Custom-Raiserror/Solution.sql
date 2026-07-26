-- Solution for Exercise-03-Custom-Raiserror
USE EmployeeManagementErrorHandlingDb;
GO

CREATE OR ALTER PROCEDURE sp_UpdateEmployeeSalary
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID)
        BEGIN
            -- RAISERROR with severity 16, state 1
            RAISERROR('Employee with ID %d does not exist. Cannot update salary.', 16, 1, @EmployeeID);
        END

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;
    END TRY
    BEGIN CATCH
        -- Insert log into AuditLog table
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('UPDATE SALARY FAILED', ERROR_MESSAGE());

        -- Return error details
        SELECT 
            'Salary Update Failed' AS Status,
            ERROR_MESSAGE() AS ErrorDetails;
    END CATCH
END;
GO

-- Testing the procedure (expected to trigger custom RAISERROR and log to AuditLog)
EXEC sp_UpdateEmployeeSalary 999, 85000.00;

-- Verify that the error was logged in AuditLog
SELECT * FROM AuditLog;
GO
