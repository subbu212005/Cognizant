SELECT
    Course,
    Gender,
    COUNT(*) AS TotalStudents
FROM Students
GROUP BY CUBE(Course, Gender);
