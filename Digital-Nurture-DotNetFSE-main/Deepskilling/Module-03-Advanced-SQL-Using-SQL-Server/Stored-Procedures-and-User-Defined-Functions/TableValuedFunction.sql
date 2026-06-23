CREATE FUNCTION GetTopStudents()
RETURNS TABLE
AS
RETURN
(
    SELECT StudentID,
           StudentName,
           Marks
    FROM Students
    WHERE Marks>80
);
