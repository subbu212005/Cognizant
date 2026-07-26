-- Solution for Exercise-04-Nested-Try-Catch
USE EmployeeManagementErrorHandlingDb;
GO

BEGIN TRANSACTION;
BEGIN TRY
    -- Outer Try
    PRINT 'Outer TRY block started.';

    BEGIN TRY
        -- Inner Try: Volatile operation (duplicate email insertion)
        INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, Salary, DepartmentID)
        VALUES (106, 'Bob', 'Martin', 'john.doe@example.com', 55000.00, 2); -- john.doe@example.com already exists
    END TRY
    BEGIN CATCH
        -- Inner Catch: Log the error and throw it to the outer catch
        PRINT 'Inner CATCH block caught the error. Logging...';
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('INSERT EMPLOYEE (INNER)', ERROR_MESSAGE());
        
        -- Re-throw using THROW
        THROW;
    END CATCH

    COMMIT TRANSACTION;
    PRINT 'Transaction committed.';
END TRY
BEGIN CATCH
    -- Outer Catch: Rollback transaction
    PRINT 'Outer CATCH block caught the error. Rolling back...';
    
    -- Check if there is an active transaction before rollback
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Transaction rolled back.';
    END
    
    SELECT 
        ERROR_MESSAGE() AS OuterErrorMessage,
        'Transaction Rolled Back' AS TransactionStatus;
END CATCH;
GO
