-- Solution for Exercise-01-Basic-Try-Catch
USE EmployeeManagementErrorHandlingDb;
GO

BEGIN TRY
    -- Attempting to insert a duplicate department to trigger primary key violation
    INSERT INTO Departments (DepartmentID, DepartmentName)
    VALUES (1, 'Duplicate Human Resources');
END TRY
BEGIN CATCH
    SELECT 
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_SEVERITY() AS ErrorSeverity,
        ERROR_STATE() AS ErrorState,
        ERROR_PROCEDURE() AS ErrorProcedure,
        ERROR_LINE() AS ErrorLine,
        ERROR_MESSAGE() AS ErrorMessage;
END CATCH;
GO
