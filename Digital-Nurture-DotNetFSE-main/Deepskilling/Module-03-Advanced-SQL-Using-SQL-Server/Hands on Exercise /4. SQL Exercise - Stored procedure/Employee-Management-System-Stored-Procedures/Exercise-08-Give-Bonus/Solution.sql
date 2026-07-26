CREATE PROCEDURE sp_GiveBonus
    @BonusAmount DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = Salary + @BonusAmount;
END;
