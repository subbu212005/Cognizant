-- Solution for Exercise-05-Transaction-Error-Logging
USE EmployeeManagementErrorHandlingDb;
GO

CREATE OR ALTER PROCEDURE sp_SafeDeleteDepartment
    @DepartmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Attempt to delete a department
        DELETE FROM Departments
        WHERE DepartmentID = @DepartmentID;

        -- If successful, commit the transaction
        COMMIT TRANSACTION;
        PRINT 'Department deleted successfully.';
    END TRY
    BEGIN CATCH
        -- Check if transaction is active and rollback-ready
        -- XACT_STATE() = -1 means transaction is uncommittable and must be rolled back.
        -- XACT_STATE() = 1 means transaction is committable.
        IF XACT_STATE() <> 0
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'Transaction rolled back due to error.';
        END

        -- Log failure to AuditLog table (AuditLog is a heap / table and doesn't belong to the transaction context)
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('DELETE DEPARTMENT FAILED', ERROR_MESSAGE());

        SELECT 
            'Delete Failed' AS Status,
            ERROR_MESSAGE() AS ErrorDetails;
    END CATCH
END;
GO

-- Testing the procedure by attempting to delete Department 2 (Engineering - has Employees referencing it)
EXEC sp_SafeDeleteDepartment 2;

-- Verify that the delete failure was logged
SELECT * FROM AuditLog;
GO
