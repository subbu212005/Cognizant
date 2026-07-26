-- SQL solution for Exercise 9
-- Recreate fn_CalculateBonus if deleted in Exercise 5
IF OBJECT_ID('dbo.fn_CalculateBonus', 'FN') IS NULL
BEGIN
    EXEC('CREATE FUNCTION fn_CalculateBonus (@Salary DECIMAL(10,2)) RETURNS DECIMAL(10,2) AS BEGIN RETURN @Salary * 0.15; END;');
END;
GO

CREATE FUNCTION fn_CalculateTotalCompensation
(
    @Salary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN dbo.fn_CalculateAnnualSalary(@Salary) + dbo.fn_CalculateBonus(@Salary);
END;
GO
