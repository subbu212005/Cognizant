CREATE PROCEDURE sp_DynamicEmployeeSearch
    @FirstName VARCHAR(50) = NULL,
    @LastName VARCHAR(50) = NULL,
    @DepartmentID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    DECLARE @Params NVARCHAR(MAX);

    SET @SQL = N'SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate 
                 FROM Employees 
                 WHERE 1=1';

    IF @FirstName IS NOT NULL
        SET @SQL = @SQL + N' AND FirstName LIKE @pFirstName';
    IF @LastName IS NOT NULL
        SET @SQL = @SQL + N' AND LastName LIKE @pLastName';
    IF @DepartmentID IS NOT NULL
        SET @SQL = @SQL + N' AND DepartmentID = @pDepartmentID';

    SET @Params = N'@pFirstName VARCHAR(50), @pLastName VARCHAR(50), @pDepartmentID INT';

    EXEC sp_executesql @SQL, @Params, 
                      @pFirstName = @FirstName, 
                      @pLastName = @LastName, 
                      @pDepartmentID = @DepartmentID;
END;
