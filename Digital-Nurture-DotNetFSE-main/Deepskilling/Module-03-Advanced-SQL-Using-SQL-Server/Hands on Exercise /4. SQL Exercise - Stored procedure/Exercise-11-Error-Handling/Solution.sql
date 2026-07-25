CREATE PROCEDURE sp_UpdateSalaryWithErrorHandling
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID)
        BEGIN
            RAISERROR('Employee does not exist.', 16, 1);
            RETURN;
        END

        IF @NewSalary < 0
        BEGIN
            RAISERROR('Salary cannot be negative.', 16, 1);
            RETURN;
        END

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
