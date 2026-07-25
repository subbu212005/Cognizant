CREATE PROCEDURE sp_TotalSalaryByDepartment
    @DepartmentID INT,
    @TotalSalary DECIMAL(10,2) OUTPUT
AS
BEGIN
    SELECT @TotalSalary = SUM(Salary)
    FROM Employees
    WHERE DepartmentID = @DepartmentID;

    IF @TotalSalary IS NULL
        SET @TotalSalary = 0.00;
END;
