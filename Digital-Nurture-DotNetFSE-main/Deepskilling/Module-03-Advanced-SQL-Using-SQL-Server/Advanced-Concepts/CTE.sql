WITH TopStudents AS
(
    SELECT StudentID,
           StudentName,
           Marks
    FROM Students
    WHERE Marks > 80
)
SELECT *
FROM TopStudents;
