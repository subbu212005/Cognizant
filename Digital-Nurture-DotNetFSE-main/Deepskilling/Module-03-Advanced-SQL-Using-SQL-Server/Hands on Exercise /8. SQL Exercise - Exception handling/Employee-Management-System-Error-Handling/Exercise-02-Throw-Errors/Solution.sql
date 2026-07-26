-- Solution for Exercise-02-Throw-Errors
USE EmployeeManagementErrorHandlingDb;
GO

CREATE OR ALTER PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2),
    @DepartmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Validation: Salary must be greater than zero
    IF @Salary <= 0
    BEGIN
        -- THROW syntax: THROW error_number, message, state;
        -- error_number must be between 50000 and 2147483647
        THROW 50001, 'Salary must be a positive value.', 1;
    END

    -- Validation: Check if department exists
    IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @DepartmentID)
    BEGIN
        THROW 50002, 'Department ID does not exist.', 1;
    END

    INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, Salary, DepartmentID)
    VALUES (@EmployeeID, @FirstName, @LastName, @Email, @Salary, @DepartmentID);
END;
GO

-- Testing the procedure (expected to throw salary error)
BEGIN TRY
    EXEC sp_InsertEmployee 106, 'Alice', 'Wonder', 'alice@example.com', -5000.00, 2;
END TRY
BEGIN CATCH
    SELECT 
        ERROR_MESSAGE() AS ErrorMessage, 
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_STATE() AS ErrorState;
END CATCH;
GO
