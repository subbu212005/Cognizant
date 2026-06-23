CREATE PROCEDURE GetStudentById
    @StudentID INT
AS
BEGIN
    SELECT *
    FROM Students
    WHERE StudentID = @StudentID;
END;
